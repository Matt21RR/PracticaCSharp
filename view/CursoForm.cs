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
    public partial class CursoForm : UserControl, ModificarElemento
    {
        CentralDatos centralDatos;
        Curso cursoEditar;
        public CursoForm(CentralDatos centralDatos, Curso cursoEditar = null)
        {
            InitializeComponent();
            this.centralDatos = centralDatos;
            programaCombo.DataSource = centralDatos.Programas;
            programaCombo.DisplayMember = "nombre";
            this.cursoEditar = cursoEditar;

            if (cursoEditar != null)
            {
                nombreInput.Text = cursoEditar.nombre;
                programaCombo.SelectedItem = cursoEditar.programa;
                activoCheckBox.Checked = cursoEditar.activo;
            }
        }

        private void guardarCurso_Click(object sender, EventArgs e)
        {
            crearOEditar();
        }

        public void crearOEditar()
        {
            string nombre = nombreInput.Text;
            Programa programa = (Programa)programaCombo.SelectedItem;
            bool activo = activoCheckBox.Checked;

            if (nombre == "" || programa is null)
            {
                MessageBox.Show("Por favor, llena todos los campos.");
                return;
            }

            if (cursoEditar != null)
            {
                cursoEditar.nombre = nombre;
                cursoEditar.programa = programa;
                cursoEditar.activo = activo;
                MessageBox.Show("¡Se edito correctamente!\n\n" + cursoEditar.toString());
                return;
            }

            Curso curso = new Curso(nombre, programa, activo);

            centralDatos.Cursos.Add(curso);
            MessageBox.Show("¡Se Creo correctamente!\n\n" + curso.toString());
        }
    }
}
