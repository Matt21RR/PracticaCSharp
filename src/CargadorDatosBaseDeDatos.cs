using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.src
{
    class CargadorDatosBaseDeDatos: IPersistenciaDatos
    {
        private InscripcionesPersonas _inscripcionesPersonas;
        private CursosInscritos _cursosInscritos;
        private CursosProfesores _cursosProfesores;

        public CargadorDatosBaseDeDatos(InscripcionesPersonas inscripcionesPersonas, CursosInscritos cursosInscritos, CursosProfesores cursosProfesores)
        {
            _inscripcionesPersonas = inscripcionesPersonas;
            _cursosInscritos = cursosInscritos;
            _cursosProfesores = cursosProfesores;
        }

        public CargadorDatosBaseDeDatos(CentralDatos centralDatos)
        {
            _inscripcionesPersonas = centralDatos.InscripcionesPersonas;
            _cursosInscritos = centralDatos.CursosInscritos;
            _cursosProfesores = centralDatos.CursosProfesores;
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
            // Inicializar las listas
            personas.Clear();
            estudiantes.Clear();
            profesores.Clear();
            cursos.Clear();
            facultades.Clear();
            programas.Clear();

            // Cargar datos de la base de datos
            foreach (var p in CRUD.listar(Tablas.Persona))
            {
                personas.Add(new Persona(
                    (int)p["ID"],
                    (string)p["nombres"], 
                    (string)p["apellidos"], 
                    (string)p["email"]));
            }
            foreach(var f in CRUD.listar(Tablas.Facultad))
            {
                facultades.Add(new Facultad(
                    (int)f["ID"],
                    (string)f["nombre"],
                    (Persona)personas.FirstOrDefault(p => p.ID == (int)f["decano_ID"])));
            }
            foreach (var p in CRUD.listar(Tablas.Programa))
            {
                programas.Add(new Programa(
                    (int)p["ID"],
                    (string)p["nombre"], 
                    (double)p["duracion"],
                    (DateTime)p["registro"], 
                    (Facultad)facultades.FirstOrDefault(f => f.ID == (int)p["facultad_ID"])));
            }
            foreach (var e in CRUD.listar(Tablas.Estudiante))
            {
                estudiantes.Add(new Estudiante(
                    (Persona)personas.FirstOrDefault(p => p.ID == (int)e["ID"]),
                    (int)e["codigo"],
                    (Programa)programas.FirstOrDefault(p => p.ID == (int)e["programa_ID"]),
                    (bool)e["activo"],
                    (double)e["promedio"]));
            }
            foreach (var p in CRUD.listar(Tablas.Profesor))
            {
                profesores.Add(new Profesor(
                    (Persona)personas.FirstOrDefault(pe => pe.ID == (int)p["ID"]),
                    (string)p["TipoContrato"]));
            }
            foreach (var c in CRUD.listar(Tablas.Curso))
            {
                cursos.Add(new Curso(
                    (int)c["ID"],
                    (string)c["nombre"],
                    (Programa)programas.FirstOrDefault(p => p.ID == (int)c["programa_ID"]),
                    (bool)c["activo"]));
            }
            foreach (var i in CRUD.listar(Tablas.Inscripcion))
            {
                _cursosInscritos.inscribirCurso(new Inscripcion(
                    (Curso)cursos.FirstOrDefault(c => c.ID == (int)i["curso_ID"]),
                    (int)i["anio"],
                    (int)i["semestre"],
                    (Estudiante)estudiantes.FirstOrDefault(e => e.ID == (int)i["estudiante_codigo"])));
            }
            foreach (var c in CRUD.listar(Tablas.CursoProfesor))
            {
                _cursosProfesores.inscribir(new CursoProfesor(
                    (Profesor)profesores.FirstOrDefault(p => p.ID == (int)c["profesor_ID"]),
                    (int)c["anio"],
                    (int)c["semestre"],
                    (Curso)cursos.FirstOrDefault(cu => cu.ID == (int)c["curso_ID"])));
            }
        }

        
    }
}
