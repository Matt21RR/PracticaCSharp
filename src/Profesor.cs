public class Profesor: Persona
{
    private string _tipoContrato;
    public string tipoContrato { get{return _tipoContrato;} set{ _tipoContrato = value; }}

    public Profesor(int ID, string nombres, string  apellidos, string email, string tipoContrato): base(ID, nombres, apellidos, email){
        this._tipoContrato = tipoContrato;
    }

    public Profesor(Persona persona, string tipoContrato)  
    {
        this.ID = persona.ID;
        this.nombres = persona.nombres;
        this.apellidos = persona.apellidos;
        this.email = persona.email;

        this._tipoContrato = tipoContrato;
    }

    public override string toString(){
        return $"-->Profesor:\n\t {base.toString().Replace("\t ","\t\t ")}\n\t Tipo Contrato:{_tipoContrato}";
    }
}