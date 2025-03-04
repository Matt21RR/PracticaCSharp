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
    public partial class InscripcionForm : UserControl, ModificarElemento
    {
        CentralDatos centralDatos;
        Inscripcion inscripcionEditar;
        public InscripcionForm(CentralDatos centralDatos, Inscripcion inscripcionEditar = null)
        {
            InitializeComponent();
            this.centralDatos = centralDatos;

            estudianteCombo.DataSource = centralDatos.Estudiantes;
            estudianteCombo.DisplayMember = "NombreCompleto";

            cursoCombo.DataSource = centralDatos.Cursos;
            cursoCombo.DisplayMember = "nombre";

            this.inscripcionEditar = inscripcionEditar;

            if (inscripcionEditar != null)
            {
                estudianteCombo.SelectedItem = inscripcionEditar.estudiante;
                cursoCombo.SelectedItem = inscripcionEditar.curso;
                anioInput.Value = inscripcionEditar.anio;
                semestreInput.Value = inscripcionEditar.semestre;
            }
        }

        private void guardarInscripcion_Click(object sender, EventArgs e)
        {
            crearOEditar();
        }

        public void crearOEditar()
        {
            Estudiante estudiante = (Estudiante)estudianteCombo.SelectedItem;
            Curso curso = (Curso)cursoCombo.SelectedItem;
            int anio = Convert.ToInt32(anioInput.Value);
            int semestre = Convert.ToInt32(semestreInput.Value);

            if (estudiante is null || curso is null)
            {
                MessageBox.Show("Por favor, llena todos los campos.");
                return;
            }

            if (inscripcionEditar != null)
            {
                inscripcionEditar.estudiante = estudiante;
                inscripcionEditar.curso = curso;
                inscripcionEditar.anio = anio;
                inscripcionEditar.semestre = semestre;
                centralDatos.Actualizar(inscripcionEditar);
                MessageBox.Show("¡Se edito correctamente!\n\n" + inscripcionEditar.toString());
                return;
            }

            Inscripcion inscripcion = new Inscripcion(curso, anio, semestre, estudiante);
            centralDatos.CursosInscritos.inscribirCurso(inscripcion);
            centralDatos.Insertar(inscripcion);
            MessageBox.Show("¡Se Creo correctamente!\n\n" + inscripcion.toString());
        }
    }
}
