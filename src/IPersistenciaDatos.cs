using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.src
{
    public interface IPersistenciaDatos
    {
        void CargarDatos(
        BindingList<Persona> personas,
        BindingList<Estudiante> estudiantes,
        BindingList<Profesor> profesores,
        BindingList<Curso> cursos,
        BindingList<Facultad> facultades,
        BindingList<Programa> programas
    );
    }
}
