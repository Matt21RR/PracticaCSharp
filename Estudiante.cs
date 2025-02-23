public class Estudiante: Persona
{
    private double _codigo;
    private Programa _programa ;
    private bool _activo ;
    private double _promedio ;
    public double codigo { get{return _codigo;} set{ _codigo = value; }}
    public Programa programa { get{return _programa;} set{ _programa = value; }}
    public bool activo { get{return _activo;} set{ _activo = value; }}
    public double promedio { get{return _promedio;} set{ _promedio = value; }}

    public Estudiante( double ID, string nombres, string  apellidos, string email, double codigo, Programa programa, bool activo, double promedio): base(ID, nombres, apellidos, email) {
        this._codigo = codigo;
        this._programa = programa;
        this._activo = activo;
        this._promedio = promedio;
    }
    public override string toString(){
        return $"Estudiante: {base.toString()} {codigo} {programa} {activo} {promedio}";
    } 
}