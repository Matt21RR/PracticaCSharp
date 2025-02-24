using System;
using System.IO;
using System.Text;
using System.Text.Json;

public static class LeerEscribirArchivos
{
    public static void escribir<T>(T value, string nombreArchivo)
    {
        try
        {
            string jsonString = JsonSerializer.Serialize(value);
            File.AppendAllText(nombreArchivo, jsonString + Environment.NewLine);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error writing to file: {ex.Message}");
        }
    }

    public static void eliminar(string nombreArchivo)
    {
        File.Delete(nombreArchivo);
    }
    public static void vaciar(string nombreArchivo)
    {
        try
        {
            if (!existe(nombreArchivo))
                return;
            File.WriteAllText(nombreArchivo, "");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error vaciando el archivo: {ex.Message}");
        }
    }
    public static bool existe(string nombreArchivo)
    {
        return File.Exists(nombreArchivo);
    }

    public static T leer<T>(string nombreArchivo)
    {
        try
        {
            if (!existe(nombreArchivo))
                throw new FileNotFoundException("File not found");

            string jsonString = File.ReadAllText(nombreArchivo);
            jsonString = "[" + jsonString.Replace(Environment.NewLine, ",").TrimEnd(',') + "]";

            return JsonSerializer.Deserialize<T>(jsonString);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
            return default;
        }
    }
}
