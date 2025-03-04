using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.src
{
    class CargadorDatosJson : IPersistenciaDatos
    {
        private InscripcionesPersonas _inscripcionesPersonas;
        private CursosInscritos _cursosInscritos;
        private CursosProfesores _cursosProfesores;

        public CargadorDatosJson(InscripcionesPersonas inscripcionesPersonas, CursosInscritos cursosInscritos, CursosProfesores cursosProfesores)
        {
            _inscripcionesPersonas = inscripcionesPersonas;
            _cursosInscritos = cursosInscritos;
            _cursosProfesores = cursosProfesores;
        }

        public void CargarDatos(
            BindingList<Persona> personas,
            BindingList<Estudiante> estudiantes,
            BindingList<Profesor> profesores,
            BindingList<Curso> cursos,
            BindingList<Facultad> facultades,
            BindingList<Programa> programas
        )
        {
            if (LeerEscribirArchivos.existe("InscripcionesPersonas.json")) _inscripcionesPersonas.cargarDatos();
            if (LeerEscribirArchivos.existe("CursosInscritos.json")) _cursosInscritos.cargarDatos();
            if (LeerEscribirArchivos.existe("CursosProfesores.json")) _cursosProfesores.cargarDatos();

            // Inicializar las listas
            personas.Clear();
            estudiantes.Clear();
            profesores.Clear();
            cursos.Clear();
            facultades.Clear();
            programas.Clear();

            personas = FiltrarDuplicados(_inscripcionesPersonas.listado, p => p.ID);
            estudiantes = FiltrarDuplicados(_inscripcionesPersonas.listado.OfType<Estudiante>(), e => e.ID);
            profesores = FiltrarDuplicados(_inscripcionesPersonas.listado.OfType<Profesor>(), p => p.ID);
            cursos = FiltrarDuplicados(_cursosInscritos.listado.Select(i => i.curso), c => c.ID);
            facultades = FiltrarDuplicados(_cursosInscritos.listado.Select(i => i.curso.programa.facultad), f => f.ID);
            programas = FiltrarDuplicados(_cursosInscritos.listado.Select(i => i.curso.programa), p => p.ID);
        }

        public void GuardarDatos()
        {
            _inscripcionesPersonas.actualizarInformacionGuardada();
            _cursosInscritos.actualizarInformacionGuardada();
            _cursosProfesores.actualizarInformacionGuardada();
        }

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
