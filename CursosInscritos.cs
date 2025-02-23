using System;
using System.IO;
using System.Text.Json;

public class CursosInscritos : Servicios {
    private List<Inscripcion> _listado { get; set; }

    public List<Inscripcion> listado { get { return _listado; } set { _listado = value; } }

    public CursosInscritos()
    {
        this._listado = new List<Inscripcion>();
    }
    public CursosInscritos(List<Inscripcion> listado)
    {
        this._listado = listado;
    }
    public void inscribirCurso(Inscripcion inscripcion){
        _listado.Add(inscripcion);
    }
    public void eliminar(Inscripcion inscripcion){
        _listado.RemoveAt(buscarInscripcion(inscripcion));
    }
    private int buscarInscripcion(Inscripcion inscripcion){
        return _listado.FindIndex(insc => insc.estudiante.ID == inscripcion.estudiante.ID && insc.curso.ID == inscripcion.curso.ID);
    }
    public void actualizar(Inscripcion inscripcion){
        _listado[buscarInscripcion(inscripcion)] = inscripcion;
    }
    public void guardarInformacion(Inscripcion inscripcion){
      //TODO: Modificar para que no se sobreescriba la información
      string jsonString = JsonSerializer.Serialize(inscripcion);
      File.WriteAllText("CursosProfesores.json", jsonString);
    }
    public void cargarDatos(){  
      string jsonString = File.ReadAllText("CursosProfesores.json");
      _listado = JsonSerializer.Deserialize<List<Inscripcion>>(jsonString);
      //? Borra el archivo después de cargar los datos?
    }

    public List<string> toString(){
        List<string> listaCursosInscritos = new List<string>();
        foreach(Inscripcion ii in _listado){
            listaCursosInscritos.Add(ii.toString());
        }
        return listaCursosInscritos;
    }

    public string imprimirPosicion(int posicion){
        return _listado[posicion].toString();
    }
    public int cantidadActual(){
        return _listado.Count;
    }

    public List<string> imprimirListado(){
        return this.toString();
    }
}