using System.Linq;
using System.Reflection;
using MySql.Data.MySqlClient;

public class BaseDeDatos
{
    private static string connectionString = "Server=127.0.0.1;Database=csharp;Uid=root@localhost;Pwd=;";

    private static MySqlConnection GetConnection()
    {
        return new MySqlConnection(connectionString);
    }

    public static void EjecutarInsert(string nombreTabla, List<string> indices, Dictionary<string,object> datos){
      string sql = "";
      sql += "INSERT INTO " +nombreTabla;
      sql += " ( "+string.Join(",",indices)+" ) ";
      sql += " VALUES ";
      sql += " ( "+string.Join(",",indices.Select(el => "@"+el).ToArray())+" ) ";

      Console.WriteLine(sql);

      MySqlConnection conexion = GetConnection();
      conexion.Open();
      MySqlCommand cmd = new MySqlCommand(sql, conexion);

      //Obtener y reemplazar los valores en el sql
      foreach (var llave in indices){
        if(llave.Contains("_")){
          string llaveA = llave.Split("_")[0];
          string llaveB = llave.Split("_")[1];
          if (datos[llaveA] is IDictionary<string, object> nestedDict){
            cmd.Parameters.AddWithValue("@"+llave, nestedDict[llaveB]);
          }
        }else{
          cmd.Parameters.AddWithValue("@"+llave,datos[llave]);
        }
      }
      cmd.ExecuteNonQuery();
      conexion.Close();
    }

    public static Dictionary<string,object> EjecutarSelectEspecifico(string nombreTabla, List<string> indicesClave, Dictionary<string,object> datos){
      string sql = "";
      sql += "SELECT * FROM " +nombreTabla;
      sql += " WHERE ";
      sql += " ( "+string.Join(" AND ",indicesClave.Select(el => el+" = @"+el).ToArray())+" ) ";

      Console.WriteLine(sql);

      MySqlConnection conexion = GetConnection();
      conexion.Open();
      MySqlCommand cmd = new MySqlCommand(sql, conexion);

      //Obtener y reemplazar los valores en el sql
      foreach (var llave in indicesClave){
        if(llave.Contains("_")){
          string llaveA = llave.Split("_")[0];
          string llaveB = llave.Split("_")[1];
          if (datos[llaveA] is IDictionary<string, object> nestedDict){
            cmd.Parameters.AddWithValue("@"+llave, nestedDict[llaveB]);
          }
        }else{
          cmd.Parameters.AddWithValue("@"+llave,datos[llave]);
        }
      }
      using (MySqlDataReader reader = cmd.ExecuteReader()){
        conexion.Close();
        if (reader.Read()){// Si se encuentra el usuario
          return Enumerable.Range(0, reader.FieldCount).ToDictionary(reader.GetName, reader.GetValue);
        }else{
          throw new Exception("Registro no encontrado en la tabla "+nombreTabla);
        }
      }
    }

    public static List<Dictionary<string,object>> EjecutarSelectGeneral(string nombreTabla){
      string sql = "";
      sql += "SELECT * FROM " +nombreTabla;

      Console.WriteLine(sql);

      MySqlConnection conexion = GetConnection();
      conexion.Open();
      MySqlCommand cmd = new MySqlCommand(sql, conexion);

      List<Dictionary<string,object>> resList = [];
      using (MySqlDataReader reader = cmd.ExecuteReader()){
        while (reader.Read()){// Si se encuentra el usuario
          resList.Add(Enumerable.Range(0, reader.FieldCount).ToDictionary(reader.GetName, reader.GetValue));
        }
      }

      conexion.Close();

      return resList;
    }


    public static void EjecutarUpdate(string nombreTabla, List<string> indices, List<string> indicesClave, Dictionary<string,object> datos){
      string sql = "";
      sql += "UPDATE " +nombreTabla;
      sql += " SET ";
      sql += string.Join(" , ",indices.Where(indice=>!indicesClave.Contains(indice)).Select(el => el+" = @"+el).ToArray());
      sql += " WHERE ";
      sql += string.Join(" AND ",indicesClave.Select(el => el+" = @"+el).ToArray());

      Console.WriteLine(sql);

      MySqlConnection conexion = GetConnection();
      conexion.Open();
      MySqlCommand cmd = new MySqlCommand(sql, conexion);

      //Obtener y reemplazar los valores en el sql
      foreach (var llave in indices){
        if(llave.Contains("_")){
          string llaveA = llave.Split("_")[0];
          string llaveB = llave.Split("_")[1];
          if (datos[llaveA] is IDictionary<string, object> nestedDict){
            cmd.Parameters.AddWithValue("@"+llave, nestedDict[llaveB]);
          }
        }else{
          cmd.Parameters.AddWithValue("@"+llave,datos[llave]);
        }
      }
      cmd.ExecuteNonQuery();
      conexion.Close();
    }

    public static void EjecutarDelete(string nombreTabla, List<string> indicesClave, Dictionary<string,object> datos){
      string sql = "";
      sql += "DELETE FROM " +nombreTabla;
      sql += " WHERE ";
      sql += " ( "+string.Join(" AND ",indicesClave.Select(el => el+" = @"+el).ToArray())+" ) ";

      Console.WriteLine(sql);

      MySqlConnection conexion = GetConnection();
      conexion.Open();
      MySqlCommand cmd = new MySqlCommand(sql, conexion);

      //Obtener y reemplazar los valores en el sql
      foreach (var llave in indicesClave){
        if(llave.Contains("_")){
          string llaveA = llave.Split("_")[0];
          string llaveB = llave.Split("_")[1];
          if (datos[llaveA] is IDictionary<string, object> nestedDict){
            cmd.Parameters.AddWithValue("@"+llave, nestedDict[llaveB]);
          }
        }else{
          cmd.Parameters.AddWithValue("@"+llave,datos[llave]);
        }
      }
      cmd.ExecuteNonQuery();
      conexion.Close();
    }

}

public enum Tablas {
  Persona,
  Facultad,
  Programa,
  Estudiante,
  Profesor,
  Curso,
  Inscripcion,
  CursoProfesor,
}
public static class CRUD
{
  private static Dictionary<string,List<string>> keySets = new Dictionary<string, List<string>>
  {
    {"Persona",["ID","nombres","apellidos","email"]},
    {"Facultad",["ID","nombre","decano_ID"]},
    {"Programa",["ID","nombre","duracion","registro","facultad_ID"]},
    {"Estudiante",["ID","codigo","programa_ID","activo","promedio"]},//id de la clase base persona
    {"Profesor",["ID","TipoContrato"]},//id de la clase base persona
    {"Curso",["ID","nombre","programa_ID","activo"]},
    {"Inscripcion",["curso_ID","anio","semestre","estudiante_codigo"]},
    {"CursoProfesor",["profesor_ID","anio","semestre","curso_ID"]}
  };

  private static Dictionary<string,List<string>> primaryKeySets = new Dictionary<string,List<string>>
  {
    {"Persona",["ID"]},
    {"Facultad",["ID"]},
    {"Programa",["ID"]},
    {"Estudiante",["codigo"]},
    {"Profesor",["ID"]},
    {"Curso",["ID"]},
    {"Inscripcion",["curso_ID","anio","semestre","estudiante_codigo"]},
    {"CursoProfesor",["profesor_ID","anio","semestre","curso_ID"]}
  };

  private static string getTableNameFromEnum(int enumTabla){
    return keySets.ToList()[enumTabla].Key;
  }
// Método genérico para convertir un objeto a un diccionario
  private static Dictionary<string, object> ConvertirADiccionario<T>(T objeto)
  {
      var diccionario = new Dictionary<string, object>();
      var propiedades = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

      foreach (var propiedad in propiedades)
      {
          var valor = propiedad.GetValue(objeto);
          if (valor != null)
          {
              diccionario.Add(propiedad.Name, valor);
          }
      }

      return diccionario;
  }
  public static void insertar<T>(T instancia){
    var nombreTabla = instancia.GetType().ToString();
    List<string> keys = keySets[nombreTabla];
    var diccionarioInstancia = ConvertirADiccionario(instancia);
    
    BaseDeDatos.EjecutarInsert(nombreTabla,keys,diccionarioInstancia);
  }
  public static Dictionary<string,object> leer<T>(T instancia){
    var nombreTabla = instancia.GetType().ToString();
    List<string> primaryKeys = primaryKeySets[nombreTabla];
    var diccionarioInstancia = ConvertirADiccionario(instancia);

    return BaseDeDatos.EjecutarSelectEspecifico(nombreTabla,primaryKeys,diccionarioInstancia);
  }

  public static List<Dictionary<string,object>> listar(int enumTabla){
    string nombreTabla = getTableNameFromEnum(enumTabla);
    return BaseDeDatos.EjecutarSelectGeneral(nombreTabla);
  }

  public static void actualizar<T>(T instancia){
    var nombreTabla = instancia.GetType().ToString();
    List<string> keys = keySets[nombreTabla];
    List<string> primaryKeys = primaryKeySets[nombreTabla];
    var diccionarioInstancia = ConvertirADiccionario(instancia);

    BaseDeDatos.EjecutarUpdate(nombreTabla,keys,primaryKeys,diccionarioInstancia);

  }
  public static void borrar<T>(T instancia){
    var nombreTabla = instancia.GetType().ToString();
    List<string> primaryKeys = primaryKeySets[nombreTabla];
    var diccionarioInstancia = ConvertirADiccionario(instancia);

    BaseDeDatos.EjecutarDelete(nombreTabla,primaryKeys,diccionarioInstancia);

  }
}