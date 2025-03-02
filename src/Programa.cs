public class Programa
{
    private int _ID; 
    private double _duracion;
    private Facultad _facultad;
    private string _nombre;
    private DateTime _registro;

    public int ID { get { return _ID; } set { _ID = value; }}
    public double duracion { get { return _duracion;} set { _duracion = value;}}
    public Facultad facultad{ get { return _facultad;} set { _facultad = value;}}
    public string nombre { get { return _nombre;} set { _nombre = value;}}
    public DateTime registro { get { return _registro;} set { _registro = value;}}

    public Programa(int ID, string nombre, double duracion, DateTime registro, Facultad facultad){
        this._ID = ID;
        this._nombre = nombre;
        this._duracion = duracion;
        this._registro = registro;
        this._facultad = facultad;
    }

    public string toString(){
        return $"-->Programa:\n\t Id:{_ID}\n\t Nombre:{_nombre}\n\t Duracion:{_duracion}\n\t Registro:{_registro.ToString()}\n\t Facultad:{_facultad}";
    }
}