/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
using System.Text.Json;

public interface Servicios{
    public string imprimirPosicion(int posicion);
    public int cantidadActual();
    public List<string> imprimirListado();
}

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
        this.ID = ID;
        this.nombres = nombres;
        this.apellidos = apellidos;
        this.email = email;
    }
    public virtual string toString(){
        return $"Persona: {ID} {nombres} {apellidos} {email}";
    }
}

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
        this.codigo = codigo;
        this.programa = programa;
        this.activo = activo;
        this.promedio = promedio;
    }
    public override string toString(){
        return $"Estudiante: {base.toString()} {codigo} {programa} {activo} {promedio}";
    } 
}

public class Profesor: Persona
{
    private string _tipoContrato;
    public string tipoContrato { get{return _tipoContrato;} set{ _tipoContrato = value; }}

    public Profesor( double ID, string nombres, string  apellidos, string email, string tipoContrato): base(ID, nombres, apellidos, email){
        this.tipoContrato = tipoContrato;
    }
    public override string toString(){
        return $"Profesor: {base.toString()} {tipoContrato}";
    }
}
public class Facultad
{
    private double _id; 
    private string _nombre;
    private Persona _decano;

    public double ID {get { return _id; } set { _id = value; }}
    public string nombre { get { return _nombre; } set { _nombre = value;}}
    public Persona decano { get { return _decano; }  set { _decano = value; }}

    public string toString(){
        return $"Facultad: {ID} {nombre} {decano}";
    }
}
public class Programa
{
    private double _id; 
    private double _duracion;
    private Facultad _facultad;
    private string _nombre;
    private string _registro;
    public double ID{ get { return _id; } set { _id = value; }}
    public double duracion { get { return _duracion;} set { _duracion = value;}}
    public Facultad facultad{ get { return _facultad;} set { _facultad = value;}}
    public string nombre { get { return _nombre;} set { _nombre = value;}}
    public string registro { get { return _registro;} set { _registro = value;}}


    public string toString(){
        return $"Programa: {ID} {nombre} {duracion} {registro} {facultad}";
    }
}

public class Curso
{
    private int _ID;
    private string _nombre;
    private Programa _programa;
    private bool _activo;
    public int ID {get{return _ID;}}
    public string nombre {get{return _nombre;} set{ _nombre = value;}}
    public Programa programa { get{return _programa;} set{ _programa = value;}}
    public bool activo { get{return _activo;} set{ _activo = value;}} 

    public string toString(){
        return $"Curso: {ID} {nombre} {programa} {activo}";
    }
}

public class Inscripcion{
    private Curso _curso;
    private int _anio;
    private int _semestre;
    private Estudiante _estudiante;

    public Curso curso { get{return _curso;} set{_curso = value;} }
    public int anio { get{return _anio;} set{_anio = value;} }
    public int semestre { get{return _semestre;} set{_semestre = value;} }
    public Estudiante estudiante { get{return _estudiante;} set{_estudiante = value;} }
    public string toString(){
        return $"Inscripcion: {curso} {anio} {semestre} {estudiante}";
    }
}

public class CursoProfesor
{
    private Profesor profesor { get; set; }
    private int anio { get; set; }
    private int semestre { get; set; }
    private Curso curso { get; set; }

    public string toString(){
        return $"Curso profesor: {curso} {profesor}  {semestre} {anio}";
    }
}

class InscripcionesPersonas
{
    private List<Persona> listado { get; set; }

    public void inscribir(Persona persona){
        listado.Add(persona);
    }
    public void eliminar(Persona persona){
        listado.RemoveAt(buscarPersona(persona));
    }
    private int buscarPersona(Persona persona){
        return listado.FindIndex(person => person.ID == persona.ID);
    }
    public void actualizar(Persona persona){
        listado[buscarPersona(persona)] = persona;
    }

    public void guardarInformacion(Persona persona){

    }
    public void cargarDatos(){

    }
}

public class CursosProfesores : Servicios
{
    private List<CursoProfesor> listado { get; set; }

    public void inscribir(CursoProfesor cursoProfesor){
        listado.Add(cursoProfesor);
    }
    public void guardarInformacion(CursoProfesor cursoProfesor){

    }
    public void cargarDatos(){

    }
    public List<string> toString(){
        List<string> temp = new List<string>();
        foreach(CursoProfesor cc in listado){
            temp.Add(cc.toString());
        }
        return temp;
    }

    public string imprimirPosicion(int posicion){
        return listado[posicion].toString();
    }
    public int cantidadActual(){
        return listado.Count;
    }

    public List<string> imprimirListado(){
        return this.toString();
    }
}

public class CursosInscritos : Servicios {
    private List<Inscripcion> listado { get; set; }

    public void inscribir(Inscripcion inscripcion){
        listado.Add(inscripcion);
    }
    public void eliminar(Inscripcion inscripcion){
        listado.RemoveAt(buscarInscripcion(inscripcion));
    }
    private int buscarInscripcion(Inscripcion inscripcion){
        return listado.FindIndex(insc => insc.estudiante.ID == inscripcion.estudiante.ID && insc.curso.ID == inscripcion.curso.ID);
    }
    public void actualizar(Inscripcion inscripcion){
        listado[buscarInscripcion(inscripcion)] = inscripcion;
    }
    public void guardarInformacion(CursoProfesor cursoProfesor){
       
    }
    public void cargarDatos(){

    }

    public List<string> toString(){
        List<string> temp = new List<string>();
        foreach(Inscripcion ii in listado){
            temp.Add(ii.toString());
        }
        return temp;
    }

    public string imprimirPosicion(int posicion){
        return listado[posicion].toString();
    }
    public int cantidadActual(){
        return listado.Count;
    }

    public List<string> imprimirListado(){
        return this.toString();
    }
}




class Principal {
  static void Main() {
    Console.WriteLine("Hello World");
      
  }
}