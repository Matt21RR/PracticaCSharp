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

        private IPersistenciaDatos _cargadorDatos;
        public CentralDatos(InscripcionesPersonas inscripcionesPersonas, CursosInscritos cursosInscritos, CursosProfesores cursosProfesores, IPersistenciaDatos cargadorDatos)
        {
            this.InscripcionesPersonas = inscripcionesPersonas;
            this.CursosInscritos = cursosInscritos;
            this.CursosProfesores = cursosProfesores;
            this._cargadorDatos = cargadorDatos;

            // Inicializar las listas
            Personas = new BindingList<Persona>();
            Estudiantes = new BindingList<Estudiante>();
            Profesores = new BindingList<Profesor>();
            Cursos = new BindingList<Curso>();
            Facultades = new BindingList<Facultad>();
            Programas = new BindingList<Programa>();

            _cargadorDatos.CargarDatos(Personas, Estudiantes, Profesores, Cursos, Facultades, Programas);
        }

        public void Insertar<T>(T elementoInsertar)
        {
            CRUD.insertar(elementoInsertar);
        }

        public void Actualizar<T>(T elementoActualizar)
        {
            CRUD.actualizar(elementoActualizar);
        }

        public void Eliminar<T>(T elementoEliminar)
        {
            CRUD.borrar(elementoEliminar);
        }

    }
}