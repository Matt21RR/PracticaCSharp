public class Inscripcion{
    private Curso _curso;
    private int _anio;
    private int _semestre;
    private Estudiante _estudiante;

    public Curso curso { get{return _curso;} set{_curso = value;} }
    public int anio { get{return _anio;} set{_anio = value;} }
    public int semestre { get{return _semestre;} set{_semestre = value;} }
    public Estudiante estudiante { get{return _estudiante;} set{_estudiante = value;} }


    public Inscripcion(Curso curso, int anio, int semestre, Estudiante estudiante){
        this._curso = curso;
        this._anio = anio;
        this._semestre = semestre;
        this._estudiante = estudiante;
    }
     
    public string toString(){
        return $"Inscripcion: \n\t{_curso.toString().Replace("\t ","\t\t ")} \n\tAño:{_anio} \n\tSemestre:{_semestre} \n\t{_estudiante.toString().Replace("\t ","\t\t ")}";
    }
}