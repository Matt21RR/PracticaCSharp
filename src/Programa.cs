public class Programa
{
    private double _ID; 
    private double _duracion;
    private Facultad _facultad;
    private string _nombre;
    private string _registro;

    public double ID{ get { return _ID; } set { _ID = value; }}
    public double duracion { get { return _duracion;} set { _duracion = value;}}
    public Facultad facultad{ get { return _facultad;} set { _facultad = value;}}
    public string nombre { get { return _nombre;} set { _nombre = value;}}
    public string registro { get { return _registro;} set { _registro = value;}}

    public Programa(double ID, string nombre, double duracion, string registro, Facultad facultad){
        this._ID = ID;
        this._nombre = nombre;
        this._duracion = duracion;
        this._registro = registro;
        this._facultad = facultad;
    }

    public string toString(){
        return $"Programa: {_ID} {_nombre} {_duracion} {_registro} {_facultad}";
    }
}