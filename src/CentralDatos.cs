using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.src
{
    public class CentralDatos
    {
        private InscripcionesPersonas inscripcionesPersonas;
        private CursosInscritos cursosInscritos;
        private CursosProfesores cursosProfesores;

        public List<Curso> Cursos { get; private set; }
        public List<Estudiante> Estudiantes { get; private set; }
        public List<Profesor> Profesores { get; private set; }
        public List<Facultad> Facultades { get; private set; }
        public List<Programa> Programas { get; private set; }
        public List<Persona> Personas { get; private set; }


        public CentralDatos(InscripcionesPersonas inscripcionesPersonas, CursosInscritos cursosInscritos, CursosProfesores cursosProfesores)
        {
            this.inscripcionesPersonas = inscripcionesPersonas;
            this.cursosInscritos = cursosInscritos;
            this.cursosProfesores = cursosProfesores;

            cargarDatos();
            inicializarListas();
        }

        private void cargarDatos()
        {
            inscripcionesPersonas.cargarDatos();
            cursosInscritos.cargarDatos();
            cursosProfesores.cargarDatos();
        }

        private void inicializarListas() { 
            Personas = inscripcionesPersonas.listado;
            Estudiantes = inscripcionesPersonas.listado.OfType<Estudiante>().ToList();
            inscripcionesPersonas.listado.OfType<Profesor>().ToList();
            Cursos = cursosInscritos.listado.Select(i => i.curso).Distinct().ToList();
            Facultades = cursosInscritos.listado.Select(i => i.curso.programa.facultad).Distinct().ToList();
            Programas = cursosInscritos.listado.Select(i => i.curso.programa).Distinct().ToList();
        }
    }
}
