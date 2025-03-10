using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Actividad.src
{
    public class CentralDatos
    {
        // Propiedades existentes
        public InscripcionesPersonas InscripcionesPersonas { get; private set; }
        public CursosInscritos CursosInscritos { get; private set; }
        public CursosProfesores CursosProfesores { get; private set; }
        public BindingList<Curso> Cursos { get; private set; }
        public BindingList<Estudiante> Estudiantes { get; private set; }
        public BindingList<Profesor> Profesores { get; private set; }
        public BindingList<Facultad> Facultades { get; private set; }
        public BindingList<Programa> Programas { get; private set; }
        public BindingList<Persona> Personas { get; private set; }

        private IPersistenciaDatos _cargadorDatos;

        // Diccionario para mapear tipos a listas
        private Dictionary<string, System.Collections.IList> _listasPorTipo;

        public CentralDatos(InscripcionesPersonas inscripcionesPersonas, CursosInscritos cursosInscritos, CursosProfesores cursosProfesores, IPersistenciaDatos cargadorDatos)
        {
            this.InscripcionesPersonas = inscripcionesPersonas;
            this.CursosInscritos = cursosInscritos;
            this.CursosProfesores = cursosProfesores;
            this._cargadorDatos = cargadorDatos;

            inicializar();

            _listasPorTipo = new Dictionary<string, System.Collections.IList>
            {
                { "Estudiante", Estudiantes },
                { "Persona", Personas },
                { "Programa", Programas },
                { "Facultad", Facultades },
                { "Profesor", Profesores },
                { "Curso", Cursos },
                { "Inscripcion", CursosInscritos.listado },
                { "Curso con profesor", CursosProfesores.listado },
                { "InscripcionesPersonas", InscripcionesPersonas.listado}
            };
        }

        private void inicializar()
        {
            // Inicializar las listas
            Personas = new BindingList<Persona>();
            Estudiantes = new BindingList<Estudiante>();
            Profesores = new BindingList<Profesor>();
            Cursos = new BindingList<Curso>();
            Facultades = new BindingList<Facultad>();
            Programas = new BindingList<Programa>();

            _cargadorDatos.CargarDatos(Personas, Estudiantes, Profesores, Cursos, Facultades, Programas);
        }

        // Métodos CRUD existentes
        public void Insertar<T>(T elementoInsertar)
        {
            CRUD.insertar(elementoInsertar);
        }

        public void Actualizar<T>(T elementoActualizar)
        {
            CRUD.actualizar(elementoActualizar);
            _cargadorDatos.CargarDatos(Personas, Estudiantes, Profesores, Cursos, Facultades, Programas);
        }

        public void Eliminar<T>(T elementoEliminar)
        {
            CRUD.borrar(elementoEliminar);
            _cargadorDatos.CargarDatos(Personas, Estudiantes, Profesores, Cursos, Facultades, Programas);
        }

        // Método para eliminar un elemento usando el diccionario
        public void EliminarElemento(object elemento, string tipo)
        {
            if (_listasPorTipo.TryGetValue(tipo, out var lista))
            {
                Eliminar(elemento);
                lista.Remove(elemento);

                if (tipo == "Persona" && elemento != null)
                {
                    InscripcionesPersonas.listado.Remove((Persona)elemento);
                }
                
            }
            else
            {
                throw new ArgumentException("Tipo de elemento no válido.");
            }
        }

        // Método para obtener la lista según el tipo usando el diccionario
        public object ObtenerLista(string tipo)
        {
            if (_listasPorTipo.TryGetValue(tipo, out var lista))
            {
                return lista;
            }
            throw new ArgumentException("Tipo de lista no válido.");
        }

        // Método para obtener el DisplayMember según el tipo
        public string ObtenerDisplayMember(string tipo)
        {
            switch (tipo)
            {
                case "Estudiante":
                case "Persona":
                case "Profesor":
                    return "NombreCompleto";
                case "Programa":
                case "Facultad":
                case "Curso":
                    return "nombre";
                case "Inscripcion":
                case "Curso con profesor":
                    return "ID";
                default:
                    throw new ArgumentException("Tipo de elemento no válido.");
            }
        }
    }
}