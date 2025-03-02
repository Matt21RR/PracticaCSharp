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
    public partial class PersonaForm : UserControl
    {
        CentralDatos centralDatos;
        public PersonaForm(CentralDatos centralDatos)
        {
            InitializeComponent();
            this.centralDatos = centralDatos;
        }

        private void guardarPersona_Click(object sender, EventArgs e)
        {
            string nombre = nombreInput.Text;
            string apellido = apellidoInput.Text;
            string correo = correoElectronicoInput.Text;

            if (nombre == "" || apellido == "" || correo == "")
            {
                MessageBox.Show("Por favor, llena todos los campos.");
                return;
            }

            Persona persona = new Persona(centralDatos.Personas.Count + 1, nombre, apellido, correo);
            centralDatos.Personas.Add(persona);
            centralDatos.InscripcionesPersonas.inscribir(persona);

            MessageBox.Show("¡Se Creo correctamente!\n\n" + persona.toString());
        }
    }
}
