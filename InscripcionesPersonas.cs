using System;
using System.IO;
using System.Text.Json;

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
      //TODO: Modificar para que no se sobreescriba la información
      string jsonString = JsonSerializer.Serialize(persona);
      File.WriteAllText("InscripcionesPersonas.json", jsonString);
    }
    public void cargarDatos(){
      string jsonString = File.ReadAllText("InscripcionesPersonas.json");
      listado = JsonSerializer.Deserialize<List<Persona>>(jsonString);
      //? Borra el archivo después de cargar los datos?
    }
}