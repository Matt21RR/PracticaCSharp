public class Profesor: Persona
{
    private string _tipoContrato;
    public string tipoContrato { get{return _tipoContrato;} set{ _tipoContrato = value; }}

    public Profesor( double ID, string nombres, string  apellidos, string email, string tipoContrato): base(ID, nombres, apellidos, email){
        this._tipoContrato = tipoContrato;
    }
    public override string toString(){
        return $"Profesor: {base.toString()} {tipoContrato}";
    }
}