using System;
using System.IO;
using System.Text.Json;

public class CursosProfesores : Servicios
{
    private List<CursoProfesor> _listado;
    public List<CursoProfesor> listado { get { return _listado; } set { _listado = value; } }

    public CursosProfesores()
    {
        this._listado = new List<CursoProfesor>();
    }
    public CursosProfesores(List<CursoProfesor> listado)
    {
        this._listado = listado;
    }
    public void inscribir(CursoProfesor cursoProfesor){
        _listado.Add(cursoProfesor);
    }
    public void guardarInformacion(CursoProfesor cursoProfesor)
    {
        LeerEscribirArchivos.escribir(cursoProfesor, "CursosProfesores.json");
    }
    public void cargarDatos()
    {
        _listado = LeerEscribirArchivos.leer<List<CursoProfesor>>("CursosProfesores.json");
    }
    public void eliminar(CursoProfesor cursoProfesor)
    {
        _listado.Remove(cursoProfesor);
    }

    public List<string> toString(){
        List<string> temp = new List<string>();
        foreach(CursoProfesor cc in _listado){
            temp.Add(cc.toString());
        }
        return temp;
    }

    public string ImprimirPosicion(int posicion){
        return _listado[posicion].toString();
    }
    public int cantidadActual(){
        return _listado.Count;
    }

    public List<string> imprimirListado(){
      return this.toString();
    }

    public void actualizarInformacionGuardada()
    {
        LeerEscribirArchivos.vaciar("CursosProfesores.json");
        foreach (CursoProfesor cc in _listado)
        {
            guardarInformacion(cc);
        }
    }
}