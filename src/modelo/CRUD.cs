using System.Linq;
using System.Reflection;

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

  public static List<Dictionary<string,object>> listar(Tablas enumTabla){
    string nombreTabla = getTableNameFromEnum((int)enumTabla);
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