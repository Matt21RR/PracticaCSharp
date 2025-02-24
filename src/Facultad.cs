public class Facultad
{
    private double _ID; 
    private string _nombre;
    private Persona _decano;

    public double ID {get { return _ID; } set { _ID = value; }}
    public string nombre { get { return _nombre; } set { _nombre = value;}}
    public Persona decano { get { return _decano; }  set { _decano = value; }}

    public Facultad(double ID, string nombre, Persona decano){
        this._ID = ID;
        this._nombre = nombre;
        this._decano = decano;
    }

    public string toString(){
        return $"Facultad: {_ID} {_nombre} {_decano}";
    }
}