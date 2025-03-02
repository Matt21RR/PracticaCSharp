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
    public partial class InscripcionForm : UserControl
    {
        CentralDatos centralDatos;
        public InscripcionForm(CentralDatos centralDatos)
        {
            InitializeComponent();
            this.centralDatos = centralDatos;

            estudianteCombo.DataSource = centralDatos.Estudiantes;
            estudianteCombo.DisplayMember = "NombreCompleto";

            cursoCombo.DataSource = centralDatos.Cursos;
            cursoCombo.DisplayMember = "nombre";
        }

        private void guardarInscripcion_Click(object sender, EventArgs e)
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

            Inscripcion inscripcion = new Inscripcion(curso, anio, semestre, estudiante);
            centralDatos.CursosInscritos.inscribirCurso(inscripcion);

            MessageBox.Show("¡Se Creo correctamente!\n\n" + inscripcion.toString());
        }

    }
}
