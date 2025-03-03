using Actividad.src;

public class Facultad
{
    private int _ID; 
    private string _nombre;
    private Persona _decano;

    public int ID {get { return _ID; } set { _ID = value; }}
    public string nombre { get { return _nombre; } set { _nombre = value;}}
    public Persona decano { get { return _decano; }  set { _decano = value; }}

    public Facultad(string nombre, Persona decano){
        this._ID = GeneradorIds.ObtenerNuevoId(typeof(Facultad));
        this._nombre = nombre;
        this._decano = decano;
    }

    public string toString(){
        return $"-->Facultad:\n\t Id:{_ID}\n\t Nombre:{_nombre}\n\t Decano:{_decano}";
    }
}