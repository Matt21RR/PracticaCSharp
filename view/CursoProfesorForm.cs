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
    public partial class CursoProfesorForm : UserControl
    {
        CentralDatos centralDatos;
        public CursoProfesorForm(CentralDatos centralDatos)
        {
            InitializeComponent();
            this.centralDatos = centralDatos;

            cursoCombo.DataSource = centralDatos.Cursos;
            cursoCombo.DisplayMember = "nombre";

            profesorCombo.DataSource = centralDatos.Profesores;
            profesorCombo.DisplayMember = "NombreCompleto";
        }

        private void guardarCursoProfesor_Click(object sender, EventArgs e)
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

            CursoProfesor cursoProfesor = new CursoProfesor(profesor, anio, semestre, curso);

            centralDatos.CursosProfesores.inscribir(cursoProfesor);
            
            MessageBox.Show("¡Se Creo correctamente!\n\n" + cursoProfesor.toString());
        }
    }
}
