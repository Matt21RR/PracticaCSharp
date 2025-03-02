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
    public partial class ProgramaForm : UserControl
    {
        CentralDatos centralDatos;
        public ProgramaForm(CentralDatos centralDatos)
        {
            InitializeComponent();
            this.centralDatos = centralDatos;

            facultadCombo.DataSource = centralDatos.Facultades;
            facultadCombo.DisplayMember = "nombre";
        }

        private void crearPrograma_Click(object sender, EventArgs e)
        {
            string nombre = nombreInput.Text;
            Facultad facultad = (Facultad)facultadCombo.SelectedItem;
            double duracion = Convert.ToDouble(duracionInput.Value);
            DateTime registro = registroDate.Value;

            if (nombre == "" || facultad is null)
            {
                MessageBox.Show("Por favor, llena todos los campos.");
                return;
            }

            Programa programa = new Programa(centralDatos.Programas.Count + 1, nombre, duracion, registro, facultad);

            centralDatos.Programas.Add(programa);

            MessageBox.Show("¡Se Creo correctamente!\n\n" + programa.toString());
        }
    }
}
