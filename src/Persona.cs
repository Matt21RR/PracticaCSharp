public class Persona
{
    private double _ID; 
    private string _nombres;
    private string _apellidos;
    private string _email;
    public double ID{get { return _ID; }set { _ID = value; }}
    public string nombres { get{return _nombres;} set{ _nombres = value; } }
    public string apellidos { get{return _apellidos;} set{ _apellidos = value;}}
    public string email { get{return _email;} set{ _email = value; } }
    
    public Persona(double ID, string nombres, string  apellidos, string email){
        this._ID = ID;
        this._nombres = nombres;
        this._apellidos = apellidos;
        this._email = email;
    }
    public virtual string toString(){
        return $"-->Persona:\n\t Id:{_ID}\n\t Nombres:{_nombres}\n\t Apellidos:{_apellidos}\n\t Email:{_email}";
    }
}