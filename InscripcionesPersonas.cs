using System;
using System.IO;
using System.Text.Json;

public class InscripcionesPersonas
{
    private List<Persona> _listado { get; set; }

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
      //TODO: Modificar para que no se sobreescriba la información
      string jsonString = JsonSerializer.Serialize(persona);
      File.WriteAllText("InscripcionesPersonas.json", jsonString);
    }
    public void cargarDatos(){
      string jsonString = File.ReadAllText("InscripcionesPersonas.json");
      _listado = JsonSerializer.Deserialize<List<Persona>>(jsonString);
    }
}