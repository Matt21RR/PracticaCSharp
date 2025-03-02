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
    public partial class CursoForm : UserControl
    {
        CentralDatos centralDatos;
        public CursoForm(CentralDatos centralDatos)
        {
            InitializeComponent();
            this.centralDatos = centralDatos;
            programaCombo.DataSource = centralDatos.Programas;
            programaCombo.DisplayMember = "nombre";
        }

        private void guardarCurso_Click(object sender, EventArgs e)
        {
            string nombre = nombreInput.Text;
            Programa programa = (Programa)programaCombo.SelectedItem;
            bool activo = activoCheckBox.Checked;
            Curso curso = new Curso(centralDatos.Cursos.Count + 1,nombre, programa, activo);

            centralDatos.Cursos.Add(curso);
        }
    }
}
