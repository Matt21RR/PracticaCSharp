using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Actividad.src
{
    public class CentralDatos
    {
        public InscripcionesPersonas InscripcionesPersonas { get; private set; }
        public CursosInscritos CursosInscritos { get; private set; }
        public CursosProfesores CursosProfesores { get; private set; }

        // Estas listas fue pensada para que las listas desplegables de los formularios se generen de manera dinamica y sin duplicados
        public BindingList<Curso> Cursos { get; private set; }
        public BindingList<Estudiante> Estudiantes { get; private set; }
        public BindingList<Profesor> Profesores { get; private set; }
        public BindingList<Facultad> Facultades { get; private set; }
        public BindingList<Programa> Programas { get; private set; }
        public BindingList<Persona> Personas { get; private set; }

        public CentralDatos(InscripcionesPersonas inscripcionesPersonas, CursosInscritos cursosInscritos, CursosProfesores cursosProfesores)
        {
            this.InscripcionesPersonas = inscripcionesPersonas;
            this.CursosInscritos = cursosInscritos;
            this.CursosProfesores = cursosProfesores;

            cargarDatos();
            inicializarListas();
        }

        private void cargarDatos()
        {
            if (LeerEscribirArchivos.existe("InscripcionesPersonas.json")) InscripcionesPersonas.cargarDatos();
            if (LeerEscribirArchivos.existe("CursosInscritos.json")) CursosInscritos.cargarDatos();
            if (LeerEscribirArchivos.existe("CursosProfesores.json")) CursosProfesores.cargarDatos();
        }

        private void inicializarListas()
        {
            Personas = FiltrarDuplicados(InscripcionesPersonas.listado, p => p.ID);
            Estudiantes = FiltrarDuplicados(InscripcionesPersonas.listado.OfType<Estudiante>(), e => e.ID);
            Profesores = FiltrarDuplicados(InscripcionesPersonas.listado.OfType<Profesor>(), p => p.ID);
            Cursos = FiltrarDuplicados(CursosInscritos.listado.Select(i => i.curso), c => c.ID);
            Facultades = FiltrarDuplicados(CursosInscritos.listado.Select(i => i.curso.programa.facultad), f => f.ID);
            Programas = FiltrarDuplicados(CursosInscritos.listado.Select(i => i.curso.programa), p => p.ID);
            Profesores = FiltrarDuplicados(CursosProfesores.listado.Select(i => i.profesor), p => p.ID);
        }

        // Método genérico para filtrar duplicados usando un diccionario
        private BindingList<T> FiltrarDuplicados<T>(IEnumerable<T> elementos, Func<T, int> obtenerId)
        {
            // Verificar si la colección es nula o está vacía
            if (elementos == null || !elementos.Any())
            {
                return new BindingList<T>();
            }

            var diccionario = new Dictionary<int, T>();

            foreach (var elemento in elementos)
            {
                if (elemento == null) continue; // Ignorar elementos nulos

                int id = obtenerId(elemento);
                if (!diccionario.ContainsKey(id))
                {
                    diccionario.Add(id, elemento);
                }
            }

            return new BindingList<T>(diccionario.Values.ToList());
        }
    }
}