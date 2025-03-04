using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Actividad.src;

namespace Actividad.view
{
    public partial class CursoProfesorForm : UserControl, ModificarElemento
    {
        CentralDatos centralDatos;
        CursoProfesor cursoProfesorEditar;
        public CursoProfesorForm(CentralDatos centralDatos, CursoProfesor cursoProfesorEditar = null)
        {
            InitializeComponent();
            this.centralDatos = centralDatos;

            cursoCombo.DataSource = centralDatos.Cursos;
            cursoCombo.DisplayMember = "nombre";

            profesorCombo.DataSource = centralDatos.Profesores;
            profesorCombo.DisplayMember = "NombreCompleto";

            this.cursoProfesorEditar = cursoProfesorEditar;

            if (cursoProfesorEditar != null)
            {
                cursoCombo.SelectedItem = cursoProfesorEditar.curso;
                profesorCombo.SelectedItem = cursoProfesorEditar.profesor;
                anioInput.Value = cursoProfesorEditar.anio;
                semestreInput.Value = cursoProfesorEditar.semestre;
            }
        }

        private void guardarCursoProfesor_Click(object sender, EventArgs e)
        {
            crearOEditar();
        }

        public void crearOEditar()
        {

            Curso curso = (Curso)cursoCombo.SelectedItem;
            Profesor profesor = (Profesor)profesorCombo.SelectedItem;
            int anio = Convert.ToInt32(anioInput.Value);
            int semestre = Convert.ToInt32(semestreInput.Value);

            if (curso is null || profesor is null)
            {
                MessageBox.Show("Por favor, llena todos los campos.");
                return;
            }

            if (cursoProfesorEditar != null)
            {
                cursoProfesorEditar.curso = curso;
                cursoProfesorEditar.profesor = profesor;
                cursoProfesorEditar.anio = anio;
                cursoProfesorEditar.semestre = semestre;
                centralDatos.Actualizar(cursoProfesorEditar);
                MessageBox.Show("¡Se edito correctamente!\n\n" + cursoProfesorEditar.toString());
                return;
            }

            CursoProfesor cursoProfesor = new CursoProfesor(profesor, anio, semestre, curso);

            centralDatos.CursosProfesores.inscribir(cursoProfesor);
            centralDatos.Insertar(cursoProfesor);
            MessageBox.Show("¡Se Creo correctamente!\n\n" + cursoProfesor.toString());
        }
    }
}
