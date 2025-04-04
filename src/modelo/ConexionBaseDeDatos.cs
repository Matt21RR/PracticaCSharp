using MySql.Data.MySqlClient;

public sealed class ConexionBaseDeDatos{

    private static string _defaultConfigConexionDB = "Server=127.0.0.1;Database=csharp;Uid=csharp;Pwd=csharp;";
    private static ConexionBaseDeDatos _instance;
    private static MySqlConnection _databaseConnection;

    private ConexionBaseDeDatos(){
      _databaseConnection = new MySqlConnection(obtenerConfigConexionDB());
    }

    private static string obtenerConfigConexionDB(){
      if(!LeerEscribirArchivos.existe("dbConfig.conf")){
        LeerEscribirArchivos.escribir(_defaultConfigConexionDB.Replace(";",";"+Environment.NewLine),"dbConfig.conf");
      }
      return LeerEscribirArchivos.leer<string>("dbConfig.conf").Replace(Environment.NewLine, "");
    }

    public static ConexionBaseDeDatos getInstance()
    {
      if(_instance == null){
        _instance = new ConexionBaseDeDatos();
      }
      return _instance;
    }

    public MySqlConnection getConnection(){
      //La conexion a la BD se entregará abierta
      if(_databaseConnection.State.ToString() != "Open"){
        _databaseConnection.Open();
      }
      return _databaseConnection;
    }
}