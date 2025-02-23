class Principal
{

    static void Main()
    {
        //InscripcionesPersonas inscripcionesPersonas = new InscripcionesPersonas();
        //if (LeerEscribirArchivos.existe("InscripcionesPersonas.json"))  inscripcionesPersonas.cargarDatos();
        //
        CursosInscritos cursosInscritos = new CursosInscritos();
        if (LeerEscribirArchivos.existe("CursosInscritos.json")) cursosInscritos.cargarDatos();
        //
        //CursosProfesores cursosProfesores = new CursosProfesores();
        //if (LeerEscribirArchivos.existe("CursosProfesores.json")) cursosProfesores.cargarDatos();

        Persona decanoCamilo = new Persona(1, "Camilo", "Reyes", "camrey@unillanos.edu.co");


        Facultad cienciasBasEIng = new Facultad(1,"Facultad de Ciencias Basicas e Ingenieria", decanoCamilo);


        Programa ingSistemas = new Programa(1, "Ingenieria de Sistemas", 10, "NA", cienciasBasEIng);
        Programa ingElectronica = new Programa(2, "Ingenieria de Electronica", 10, "NA", cienciasBasEIng);


        Estudiante estudianteJuan = new Estudiante(2, "Juan", "Perez", "juanp@unillanos.edu.co", 16001,
                                                ingSistemas, true, 4.5f);
        Estudiante estudiantePedro = new Estudiante(3, "Pedro", "Gomez", "pedrog@unillanos.edu.co", 16002,
                                                ingSistemas, true, 4.0f);

        Curso programacion1 = new Curso(1, "Programacion I", ingSistemas, true);
        Curso programacion2 = new Curso(2, "Programacion II", ingSistemas, true);

        Inscripcion inscripcionJuan = new Inscripcion(programacion1, 2023, 2, estudiantePedro);

        Console.WriteLine(inscripcionJuan.toString());

        cursosInscritos.inscribirCurso(inscripcionJuan);
    }
}