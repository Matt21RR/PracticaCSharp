using Actividad.src;

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

    public Estudiante(string nombres, string  apellidos, string email, Programa programa, bool activo, double promedio): base(nombres, apellidos, email) {
        this._codigo = GeneradorIds.ObtenerNuevoId(typeof(Estudiante));
        this._programa = programa;
        this._activo = activo;
        this._promedio = promedio;
    }

    public override string toString(){
        return $"-->Estudiante:\n\t {base.toString().Replace("\t ","\t\t ")}\n\t Codigo:{_codigo}\n\t Programa: {_programa}\n\t Promedio:{_promedio}\n\t Activo:{_activo} ";
    } 
}