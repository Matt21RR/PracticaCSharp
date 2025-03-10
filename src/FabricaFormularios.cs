using Actividad.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.src
{
    public static class FabricaFormularios
    {

        // Método que crea un formulario de acuerdo al tipo de elemento que se desea crear o editar,
        // Si se desea editar un elemento se debe pasar el elemento como argumento
        public static UserControl CrearFormulario(string tipo, CentralDatos centralDatos, object elemento = null)
        {
            switch (tipo)
            {
                case "Estudiante":
                    return new EstudianteForm(centralDatos, (Estudiante)elemento);
                case "Persona":
                    return new PersonaForm(centralDatos, (Persona)elemento);
                case "Programa":
                    return new ProgramaForm(centralDatos, (Programa)elemento);
                case "Facultad":
                    return new FacultadForm(centralDatos, (Facultad)elemento);
                case "Profesor":
                    return new ProfesorForm(centralDatos, (Profesor)elemento);
                case "Curso":
                    return new CursoForm(centralDatos, (Curso)elemento);
                case "Inscripcion":
                    return new InscripcionForm(centralDatos, (Inscripcion)elemento);
                case "Curso con profesor":
                    return new CursoProfesorForm(centralDatos, (CursoProfesor)elemento);
                default:
                    throw new ArgumentException("Tipo de formulario no válido.");
            }
        }
    }
}
