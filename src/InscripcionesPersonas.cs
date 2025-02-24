using System;
using System.IO;
using System.Text.Json;

public class InscripcionesPersonas
{
    private List<Persona> _listado;
    public List<Persona> listado { get { return _listado; } set { _listado = value; } }

    public InscripcionesPersonas()
    {
        this._listado = new List<Persona>();
    }
    public InscripcionesPersonas(List<Persona> listado)
    {
        this._listado = listado;
    }
   

    public void inscribir(Persona persona){
        _listado.Add(persona);
    }
    public void eliminar(Persona persona){
        _listado.RemoveAt(buscarPersona(persona));
    }
    private int buscarPersona(Persona persona){
        return _listado.FindIndex(person => person.ID == persona.ID);
    }
    public void actualizar(Persona persona){
        _listado[buscarPersona(persona)] = persona;
    }

    public void guardarInformacion(Persona persona){
        LeerEscribirArchivos.escribir(persona, "InscripcionesPersonas.json");
    }
    public void cargarDatos(){
        _listado = LeerEscribirArchivos.leer<List<Persona>>("InscripcionesPersonas.json");
    }


    public void actualizarInformacionGuardada()
    {
        LeerEscribirArchivos.vaciar("InscripcionesPersonas.json");
        foreach (Persona pp in _listado)
        {
            guardarInformacion(pp);
        }
    }
}