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

            Persona persona0 = new Persona("Jesus","Pena","dfvillegas@unillanos.edu.co");
            persona0.ID = 2;
            CRUD.insertar(persona0);

            Persona persona = new Persona("Miguel","Traslaviña","matraslavina@unillanos.edu.co");
            persona.ID = 3;

            CRUD.insertar(persona);
            Facultad facultad = new Facultad("Basicas e Ingeniería",persona);
            CRUD.insertar(facultad);
            Programa programa = new Programa("Sistemas",10,new DateTime(),facultad);
            CRUD.insertar(programa);
            Estudiante estudiante = new Estudiante("Cristian","Soto","assdas@gmail.com",programa,true,3.2);
            CRUD.insertar(estudiante);
            

            //Imprimiendo los registros
            foreach (var registro in CRUD.listar(Tablas.Persona))
            {
                Console.WriteLine("\n");
                foreach (var celda in registro)
                {
                    Console.WriteLine(celda.Key+" : "+celda.Value);
                }
            } 
            // Console.WriteLine(string.Join(",",CRUD.leer(persona).Keys));
            // Console.WriteLine(string.Join(",",CRUD.leer(persona).Values));
            // CRUD.actualizar(persona);
            // Console.WriteLine(string.Join(",",CRUD.leer(persona).Values));

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}