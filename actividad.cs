using System;
using System.Text.Json;

class Principal
{
    static void das()
    {
        InscripcionesPersonas inscripcionesPersonas = new InscripcionesPersonas();
        if (LeerEscribirArchivos.existe("InscripcionesPersonas.json")) inscripcionesPersonas.cargarDatos();

        CursosInscritos cursosInscritos = new CursosInscritos();
        if (LeerEscribirArchivos.existe("CursosInscritos.json")) cursosInscritos.cargarDatos();

        CursosProfesores cursosProfesores = new CursosProfesores();
        if (LeerEscribirArchivos.existe("CursosProfesores.json")) cursosProfesores.cargarDatos();

        
        crearEjemplo(cursosInscritos, inscripcionesPersonas, cursosProfesores);


        Console.WriteLine(string.Join(Environment.NewLine, cursosInscritos.imprimirListado()));
        Console.WriteLine(string.Join(Environment.NewLine, cursosProfesores.imprimirListado()));

        guardarTodo(cursosInscritos, inscripcionesPersonas, cursosProfesores);
    }

    static void crearEjemplo(CursosInscritos cursosInscritos, InscripcionesPersonas inscripcionesPersonas, CursosProfesores cursosProfesores)
    {
        Persona decanoCamilo = new Persona( "Camilo", "Reyes", "camrey@unillanos.edu.co");

        Facultad cienciasBasEIng = new Facultad( "Facultad de Ciencias Basicas e Ingenieria", decanoCamilo);

        Programa ingSistemas = new Programa( "Ingenieria de Sistemas", 10, new DateTime(2004, 12, 21), cienciasBasEIng);
        Programa ingElectronica = new Programa( "Ingenieria de Electronica", 10, new DateTime(2004, 12, 21), cienciasBasEIng);

        Estudiante estudianteJuan = new Estudiante( "Juan", "Perez", "juanp@unillanos.edu.co",  ingSistemas, true, 4.5f);
        Estudiante estudiantePedro = new Estudiante( "Pedro", "Gomez", "pedrog@unillanos.edu.co",  ingSistemas, true, 4.0f);
        Estudiante estudianteMaria = new Estudiante( "Maria", "Lopez", "marial@unillanos.edu.co",  ingElectronica, true, 4.2f);

        Curso programacion1 = new Curso( "Programacion I", ingSistemas, true);
        Curso programacion2 = new Curso( "Programacion II", ingSistemas, true);
        Curso circuitos = new Curso( "Circuitos", ingElectronica, true);

        Inscripcion inscripcionJuan = new Inscripcion(programacion1, 2023, 2, estudianteJuan);
        Inscripcion inscripcionPedro = new Inscripcion(programacion2, 2023, 2, estudiantePedro);
        Inscripcion inscripcionMaria = new Inscripcion(circuitos, 2023, 2, estudianteMaria);

        Profesor profesorCarlos = new Profesor( "Nestor", "Herrera", "nestorh@unillanos.edu.co", "Temporal");
        CursoProfesor cursoProfesor1 = new CursoProfesor(profesorCarlos, 2023, 2, programacion1);
        CursoProfesor cursoProfesor2 = new CursoProfesor(profesorCarlos, 2024, 3, programacion2);


        inscripcionesPersonas.inscribir(decanoCamilo);
        inscripcionesPersonas.inscribir(estudianteJuan);
        inscripcionesPersonas.inscribir(estudiantePedro);
        inscripcionesPersonas.inscribir(estudianteMaria);
        inscripcionesPersonas.inscribir(profesorCarlos);

        cursosInscritos.inscribirCurso(inscripcionJuan);
        cursosInscritos.inscribirCurso(inscripcionPedro);
        cursosInscritos.inscribirCurso(inscripcionMaria);

        cursosProfesores.inscribir(cursoProfesor1);
        cursosProfesores.inscribir(cursoProfesor2);
    }
    static void guardarTodo(CursosInscritos cursosInscritos, InscripcionesPersonas inscripcionesPersonas, CursosProfesores cursosProfesores)
    {
        inscripcionesPersonas.actualizarInformacionGuardada();
        cursosInscritos.actualizarInformacionGuardada();
        cursosProfesores.actualizarInformacionGuardada();
    }
}
