using System;
using System.IO;
using System.Text.Json;


public static class WR
{
    public static void write<T>(T value, string path){
        string jsonString = JsonSerializer.Serialize(value);
        File.AppendAllText(path, jsonString+"\n");
    }

    public static void delete(string path){
        File.Delete(path);
    }

    public static T read<T>(string path){
        string jsonString = "[";
        if (File.Exists("InscripcionesPersonas.json")){
          IEnumerable<string> lines = File.ReadLines(path);
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