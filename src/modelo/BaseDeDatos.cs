using System.Linq;
using MySql.Data.MySqlClient;

public class BaseDeDatos
{
    private static MySqlConnection GetConnection()
    {
        ConexionBaseDeDatos s1 = ConexionBaseDeDatos.getInstance();
        return s1.getConnection();
    }

    public static void EjecutarInsert(string nombreTabla, List<string> indices, Dictionary<string,object> datos){
      string sql = "";
      sql += "INSERT INTO " +nombreTabla;
      sql += " ( "+string.Join(",",indices)+" ) ";
      sql += " VALUES ";
      sql += " ( "+string.Join(",",indices.Select(el => "@"+el).ToArray())+" ) ";

      Console.WriteLine(sql);

      MySqlConnection conexion = GetConnection();

      MySqlCommand cmd = new MySqlCommand(sql, conexion);

      //Obtener y reemplazar los valores en el sql
      foreach (var llave in indices){
        if(llave.Contains("_")){
          string llaveA = llave.Split("_")[0];
          string llaveB = llave.Split("_")[1];
          cmd.Parameters.AddWithValue("@"+llave, datos[llaveA].GetType().GetProperty(llaveB).GetValue(datos[llaveA]));
        }else{
          cmd.Parameters.AddWithValue("@"+llave,datos[llave]);
        }
      }
      cmd.ExecuteNonQuery();
    }

    public static Dictionary<string,object> EjecutarSelectEspecifico(string nombreTabla, List<string> indicesClave, Dictionary<string,object> datos){
      string sql = "";
      sql += "SELECT * FROM " +nombreTabla;
      sql += " WHERE ";
      sql += " ( "+string.Join(" AND ",indicesClave.Select(el => el+" = @"+el).ToArray())+" ) ";

      Console.WriteLine(sql);

      MySqlConnection conexion = GetConnection();

      MySqlCommand cmd = new MySqlCommand(sql, conexion);

      //Obtener y reemplazar los valores en el sql
      foreach (var llave in indicesClave){
        if(llave.Contains("_")){
          string llaveA = llave.Split("_")[0];
          string llaveB = llave.Split("_")[1];
          cmd.Parameters.AddWithValue("@"+llave, datos[llaveA].GetType().GetProperty(llaveB).GetValue(datos[llaveA]));
        }else{
          cmd.Parameters.AddWithValue("@"+llave,datos[llave]);
        }
      }
      using (MySqlDataReader reader = cmd.ExecuteReader()){
        if (reader.Read()){// Si se encuentra el usuario
          Dictionary<string,object> res = Enumerable.Range(0, reader.FieldCount).ToDictionary(reader.GetName, reader.GetValue);
          reader.Close();
          return res;
        }else{
          reader.Close();
          throw new Exception("Registro no encontrado en la tabla "+nombreTabla);
        }
      }
    }

    public static List<Dictionary<string,object>> EjecutarSelectGeneral(string nombreTabla){
      string sql = "";
      sql += "SELECT * FROM " +nombreTabla;

      Console.WriteLine(sql);

      MySqlConnection conexion = GetConnection();
      MySqlCommand cmd = new MySqlCommand(sql, conexion);

      List<Dictionary<string,object>> resList = [];
      using (MySqlDataReader reader = cmd.ExecuteReader()){
        while (reader.Read()){// Si se encuentra el usuario
          resList.Add(Enumerable.Range(0, reader.FieldCount).ToDictionary(reader.GetName, reader.GetValue));
        }
        reader.Close();
      }
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
      MySqlCommand cmd = new MySqlCommand(sql, conexion);

      //Obtener y reemplazar los valores en el sql
      foreach (var llave in indices){
        if(llave.Contains("_")){
          string llaveA = llave.Split("_")[0];
          string llaveB = llave.Split("_")[1];
          cmd.Parameters.AddWithValue("@"+llave, datos[llaveA].GetType().GetProperty(llaveB).GetValue(datos[llaveA]));
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
      sql += string.Join(" AND ",indicesClave.Select(el => el+" = @"+el).ToArray());

      Console.WriteLine(sql);

      MySqlConnection conexion = GetConnection();
      MySqlCommand cmd = new MySqlCommand(sql, conexion);

      //Obtener y reemplazar los valores en el sql
      foreach (var llave in indicesClave){
        if(llave.Contains("_")){
          string llaveA = llave.Split("_")[0];
          string llaveB = llave.Split("_")[1];
          cmd.Parameters.AddWithValue("@"+llave, datos[llaveA].GetType().GetProperty(llaveB).GetValue(datos[llaveA]));
        }else{
          cmd.Parameters.AddWithValue("@"+llave,datos[llave]);
        }
      }
      cmd.ExecuteNonQuery();
    }

}