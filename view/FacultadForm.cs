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
    public partial class FacultadForm : UserControl, ModificarElemento
    {
        CentralDatos centralDatos;
        Facultad facultadEditar;
        public FacultadForm(CentralDatos centralDatos, Facultad facultadEditar = null)
        {
            InitializeComponent();
            this.centralDatos = centralDatos;

            decanoCombo.DataSource = centralDatos.Personas;
            decanoCombo.DisplayMember = "NombreCompleto";
            this.facultadEditar = facultadEditar;

            if (facultadEditar != null)
            {
                nombreInput.Text = facultadEditar.nombre;
                decanoCombo.SelectedItem = facultadEditar.decano;
            }
        }

        private void guardarFacultad_Click(object sender, EventArgs e)
        {
            crearOEditar();
        }

        public void crearOEditar()
        {
            string nombre = nombreInput.Text;
            Persona decano = (Persona)decanoCombo.SelectedItem;
            if (nombre == "" || decano is null)
            {
                MessageBox.Show("Por favor, llena todos los campos.");
                return;
            }
            if (facultadEditar != null)
            {
                facultadEditar.nombre = nombre;
                facultadEditar.decano = decano;
                centralDatos.Actualizar(facultadEditar);
                MessageBox.Show("¡Se edito correctamente!\n\n" + facultadEditar.toString());
                return;
            }
            Facultad facultad = new Facultad(nombre, decano);
            centralDatos.Facultades.Add(facultad);
            centralDatos.Insertar(facultad);
            MessageBox.Show("¡Se Creo correctamente!\n\n" + facultad.toString());
        }
    }
}
