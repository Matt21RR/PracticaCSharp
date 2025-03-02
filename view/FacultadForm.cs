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
    public partial class FacultadForm : UserControl
    {
        CentralDatos centralDatos;
        public FacultadForm(CentralDatos centralDatos)
        {
            InitializeComponent();
            this.centralDatos = centralDatos;

            decanoCombo.DataSource = centralDatos.Personas;
            decanoCombo.DisplayMember = "NombreCompleto";
        }

        private void guardarFacultad_Click(object sender, EventArgs e)
        {
            string nombre = nombreInput.Text;
            Persona decano = (Persona)decanoCombo.SelectedItem;

            if (nombre == "" || decano is null)
            {
                MessageBox.Show("Por favor, llena todos los campos.");
                return;
            }

            Facultad facultad = new Facultad(centralDatos.Facultades.Count + 1, nombre, decano);

            centralDatos.Facultades.Add(facultad);

            MessageBox.Show("¡Se Creo correctamente!\n\n" + facultad.toString());
        }
    }
}
