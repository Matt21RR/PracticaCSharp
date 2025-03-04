using System.Runtime.InteropServices;

namespace Actividad
{
    internal static class Program
    {
        // Importar la función AllocConsole de la API de Windows
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool AllocConsole();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            AllocConsole();//Permitirá enlazar el programa a una consola

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}