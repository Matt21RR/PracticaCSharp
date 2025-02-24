public class CursoProfesor
{
    private Profesor _profesor;
    private int _anio;
    private int _semestre;
    private Curso _curso;

    public Profesor profesor { get{return _profesor;} set{_profesor = value;} }
    public int anio { get{return _anio;} set{_anio = value;} }
    public int semestre { get{return _semestre;} set{_semestre = value;} }
    public Curso curso { get{return _curso;} set{_curso = value;} }

    public CursoProfesor(Profesor profesor, int anio, int semestre, Curso curso){
        this._profesor = profesor;
        this._anio = anio;
        this._semestre = semestre;
        this._curso = curso;
    }

    public string toString(){
        return $"Curso profesor:\n\t {_curso.toString().Replace("\t ","\t\t ")}\n\t {_profesor.toString().Replace("\t ","\t\t")}\n\t Semestre:{_semestre}\n\t Año:{_anio}";
    }
}