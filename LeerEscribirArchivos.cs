using System;
using System.IO;
using System.Text.Json;


public static class LeerEscribirArchivos
{
    public static void escribir<T>(T value, string nombreArchivo){
        string jsonString = JsonSerializer.Serialize(value);
        File.AppendAllText(nombreArchivo, jsonString+"\n");
    }

    public static void eliminar(string nombreArchivo)
    {
        if (existe(nombreArchivo))
            File.Delete(nombreArchivo);
    }
    public static bool existe(string nombreArchivo)
    {
        return File.Exists(nombreArchivo);
    }
    public static T leer<T>(string nombreArchivo){
        string jsonString = "[";
        if (existe(nombreArchivo)){
          IEnumerable<string> lines = File.ReadLines(nombreArchivo);
          for(int i = 0; i < lines.Count(); i++){
              if(i != 0){
                jsonString += ",";
              }
              jsonString += lines.ElementAt(i);
          }
        }
        jsonString += "]";

        jsonString = jsonString.Replace("\n", "");

        return JsonSerializer.Deserialize<T>(jsonString);
    }
}