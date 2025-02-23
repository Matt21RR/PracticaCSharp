using System;
using System.IO;
using System.Text.Json;

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
      //TODO: Modificar para que no se sobreescriba la información
      string jsonString = JsonSerializer.Serialize(cursoProfesor);
      File.WriteAllText("CursosProfesores.json", jsonString);
    }
    public void cargarDatos(){  
      string jsonString = File.ReadAllText("CursosProfesores.json");
      listado = JsonSerializer.Deserialize<List<Inscripcion>>(jsonString);
      //? Borra el archivo después de cargar los datos?
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