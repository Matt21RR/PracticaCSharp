class Principal
{
    static void Main()
    {
        Persona decanoIngenieria = new Persona(1, "Juan", "Perez", "juanp@unillanos.edu.co");

        Facultad facultad = new Facultad(1, "Facultad de Ingeniería", decanoIngenieria);



    }

    void cargarInformacionDesdeArchivo()
    {
        InscripcionesPersonas inscripcionesPersonas = new InscripcionesPersonas();
        inscripcionesPersonas.cargarDatos();


    }
}