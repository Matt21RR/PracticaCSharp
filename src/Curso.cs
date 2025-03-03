using Actividad.src;

public class Curso
{
    private int _ID;
    private string _nombre;
    private Programa _programa;
    private bool _activo;

    public int ID {get{return _ID;}}
    public string nombre {get{return _nombre;} set{ _nombre = value;}}
    public Programa programa { get{return _programa;} set{ _programa = value;}}
    public bool activo { get{return _activo;} set{ _activo = value;}} 


    public Curso(string nombre, Programa programa, bool activo){
        this._ID = GeneradorIds.ObtenerNuevoId(typeof(Curso));
        this._nombre = nombre;
        this._programa = programa;
        this._activo = activo;
    }

    public string toString(){
        return $"-->Curso:\n\t id:{_ID}\n\t Nombre:{_nombre}\n\t {_programa.toString().Replace("\t ","\t\t ")}\n\t Activo:{_activo}";
    }
}