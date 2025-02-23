using System;
using System.IO;
using System.Text.Json;

public class CursosInscritos : Servicios {
    private List<Inscripcion> _listado;

    public List<Inscripcion> listado { get { return _listado; } set { _listado = value; } }

    public CursosInscritos()
    {
        this._listado = new List<Inscripcion>();
    }
    public CursosInscritos(List<Inscripcion> listado)
    {
        this._listado = listado;
    }
    ~CursosInscritos()
    {
        actualizarInformacionGuardada();
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
    public void guardarInformacion(Inscripcion inscripcion)
    {
        LeerEscribirArchivos.escribir(inscripcion, "CursosInscritos.json");
    }
    public void cargarDatos()
    {
        _listado = LeerEscribirArchivos.leer<List<Inscripcion>>("CursosInscritos.json");
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

    private void actualizarInformacionGuardada()
    {
        LeerEscribirArchivos.eliminar("CursosInscritos.json");
        foreach (Inscripcion ii in _listado)
        {
            guardarInformacion(ii);
        }
    }
}