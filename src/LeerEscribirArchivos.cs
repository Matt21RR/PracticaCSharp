using System;
using System.IO;
using System.Text;
using System.Text.Json;

public static class LeerEscribirArchivos
{
    private static string rutaDirectorioDatosPrograma = Path.Combine(Environment.CurrentDirectory, "./programData/");
    private static void crearDirectorioDatosPrograma()
    {
        if (!Directory.Exists(rutaDirectorioDatosPrograma))
        {
            Directory.CreateDirectory(rutaDirectorioDatosPrograma);
        }
    }
    public static void escribir<T>(T value, string nombreArchivo)
    {
        nombreArchivo = Path.Combine(rutaDirectorioDatosPrograma, nombreArchivo);
        crearDirectorioDatosPrograma();
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
        nombreArchivo = Path.Combine(rutaDirectorioDatosPrograma, nombreArchivo);
        File.Delete(nombreArchivo);
    }
    public static void vaciar(string nombreArchivo)
    {
        nombreArchivo = Path.Combine(rutaDirectorioDatosPrograma, nombreArchivo);
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
        nombreArchivo = Path.Combine(rutaDirectorioDatosPrograma, nombreArchivo);
        return File.Exists(nombreArchivo);
    }

    public static T leer<T>(string nombreArchivo)
    {
        nombreArchivo = Path.Combine(rutaDirectorioDatosPrograma, nombreArchivo);
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
