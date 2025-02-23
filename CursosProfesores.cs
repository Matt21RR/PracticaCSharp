using System;
using System.IO;
using System.Text.Json;

public class CursosProfesores : Servicios
{
    private List<CursoProfesor> _listado { get; set; }

    public void inscribir(CursoProfesor cursoProfesor){
        _listado.Add(cursoProfesor);
    }
    public void guardarInformacion(CursoProfesor cursoProfesor){
      //TODO: Modificar para que no se sobreescriba la información
      string jsonString = JsonSerializer.Serialize(cursoProfesor);
      File.WriteAllText("CursosProfesores.json", jsonString);

    }
    public void cargarDatos(){
      string jsonString = File.ReadAllText("CursosProfesores.json");
      _listado = JsonSerializer.Deserialize<List<CursoProfesor>>(jsonString);
      //? Borra el archivo después de cargar los datos?
    }
    public List<string> toString(){
        List<string> temp = new List<string>();
        foreach(CursoProfesor cc in _listado){
            temp.Add(cc.toString());
        }
        return temp;
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