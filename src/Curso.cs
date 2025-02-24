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


    public Curso(int ID, string nombre, Programa programa, bool activo){
        this._ID = ID;
        this._nombre = nombre;
        this._programa = programa;
        this._activo = activo;
    }
    public string toString(){
        return $"Curso: {_ID} {_nombre} {_programa} {_activo}";
    }
}