public class Facultad
{
    private double _id; 
    private string _nombre;
    private Persona _decano;

    public double ID {get { return _id; } set { _id = value; }}
    public string nombre { get { return _nombre; } set { _nombre = value;}}
    public Persona decano { get { return _decano; }  set { _decano = value; }}

    public Facultad(double ID, string nombre, Persona decano){
        this._id = ID;
        this._nombre = nombre;
        this._decano = decano;
    }

    public string toString(){
        return $"Facultad: {ID} {nombre} {decano}";
    }
}