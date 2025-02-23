public class Persona
{
    private double _id; 
    private string _nombres;
    private string _apellidos;
    private string _email;
    public double ID{get { return _id; }set { _id = value; }}
    public string nombres { get{return _nombres;} set{ _nombres = value; } }
    public string apellidos { get{return _apellidos;} set{ _apellidos = value;}}
    public string email { get{return _email;} set{ _email = value; } }
    
    public Persona(double ID, string nombres, string  apellidos, string email){
        this._id = ID;
        this._nombres = nombres;
        this._apellidos = apellidos;
        this._email = email;
    }
    public virtual string toString(){
        return $"Persona: {ID} {nombres} {apellidos} {email}";
    }
}