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
    public partial class EstudianteForm : UserControl
    {
        CentralDatos centralDatos;
        public EstudianteForm(CentralDatos centralDatos)
        {
            this.centralDatos = centralDatos;
            InitializeComponent();

            programaCombo.DataSource = centralDatos.Programas;
            programaCombo.DisplayMember = "nombre";
        }

        private void guardarEstudiante_Click(object sender, EventArgs e)
        {
            string nombre = nombreInput.Text;
            string apellido = apellidoInput.Text;
            string correo = correoElectronicoInput.Text;
            Programa programa = (Programa)programaCombo.SelectedItem;
            double promedio = Convert.ToDouble(promedioInput.Value);
            bool activo = activoCheckBox.Checked;

            if (nombre == "" || apellido == "" || correo == "" || programa is null)
            {
                MessageBox.Show("Por favor, llena todos los campos.");
                return;
            }

            // TODO: Aqui tener en cuenta la ID de estudiante es correspondiente a la lista de personas, el codigo es el que esta en la lista de estudiantes
            Estudiante estudiante = new Estudiante(centralDatos.Personas.Count + 1, nombre, apellido, correo, centralDatos.Estudiantes.Count + 1, programa, activo , promedio );

            centralDatos.Personas.Add(estudiante);
            centralDatos.Estudiantes.Add(estudiante);
            centralDatos.InscripcionesPersonas.inscribir(estudiante);

            MessageBox.Show("¡Se Creo correctamente!\n\n" + estudiante.toString());

        }
    }
}
