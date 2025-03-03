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

    public static void EjecutarInsert<T>(string nombreTabla, List<string> indices, Dictionary<string,T> datos){
      MySqlConnection conexion = GetConnection();

      string sql = "";
      sql += "INSERT INTO " +nombreTabla;
      sql += " ( "+indices.ToString()+" ) ";
      sql += " VALUES ";
      sql += " ( "+indices.Select(el => "@"+el).ToArray().ToString()+" ) ";

      MySqlCommand cmd = new MySqlCommand(sql, conexion);

      //Obtener y reemplazar los valores en el sql
      foreach (var llave in indices)
      {
        if(llave.Contains("_")){
          string llaveA = llave.Split("_")[0];
          string llaveB = llave.Split("_")[1];
          //! ESTA CHIMBADA VA A REVENTARSE ACA
          if (datos[llaveA] is IDictionary<string, object> nestedDict){
            cmd.Parameters.AddWithValue("@"+llave, nestedDict[llaveB]);
          }
        }else{
          cmd.Parameters.AddWithValue("@"+llave,datos[llave]);
        }
      }
      cmd.ExecuteNonQuery();
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

  private static string getTableNameFromEnum(int enumTabla){
    return keySets.ToList()[enumTabla].Key;
  }
// Método genérico para convertir un objeto a un diccionario
  private static Dictionary<string, T> ConvertirADiccionario<T>(T objeto)
  {
      var diccionario = new Dictionary<string, T>();
      var propiedades = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

      foreach (var propiedad in propiedades)
      {
          var valor = propiedad.GetValue(objeto);
          if (valor != null)
          {
              diccionario.Add(propiedad.Name, (T)valor);
          }
      }

      return diccionario;
  }
  public static void insertar<T>(T instancia){
    var nombreTabla = instancia.GetType().ToString();
    var diccionarioInstancia = ConvertirADiccionario(instancia);
    List<string> keys = keySets[nombreTabla];
    
    BaseDeDatos.EjecutarInsert(nombreTabla,keys,diccionarioInstancia);
  }
  public static void leer<T>(T instancia){
    var nombreTabla = instancia.GetType().ToString();

  }

  public static void listar(int enumTabla){
    string nombreTabla = getTableNameFromEnum(enumTabla);
  }

  public static void actualizar<T>(T instancia){
    var nombreTabla = instancia.GetType().ToString();

  }
  public static void borrar<T>(T instancia){
    var nombreTabla = instancia.GetType().ToString();

  }
}