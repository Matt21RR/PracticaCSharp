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
    public partial class PersonaForm : UserControl, ModificarElemento
    {
        CentralDatos centralDatos;
        Persona personaEditar;
        public PersonaForm(CentralDatos centralDatos, Persona personaEditar = null)
        {
            InitializeComponent();
            this.centralDatos = centralDatos;

            this.personaEditar = personaEditar;
            if (personaEditar != null)
            {
                nombreInput.Text = personaEditar.nombres;
                apellidoInput.Text = personaEditar.apellidos;
                correoElectronicoInput.Text = personaEditar.email;
            }
        }

        private void guardarPersona_Click(object sender, EventArgs e)
        {
            crearOEditar();
        }

        public void crearOEditar()
        {
            string nombre = nombreInput.Text;
            string apellido = apellidoInput.Text;
            string correo = correoElectronicoInput.Text;

            if (nombre == "" || apellido == "" || correo == "")
            {
                MessageBox.Show("Por favor, llena todos los campos.");
                return;
            }

            if(personaEditar != null)
            {
                personaEditar.nombres = nombre;
                personaEditar.apellidos = apellido;
                personaEditar.email = correo;
                centralDatos.Actualizar(personaEditar);
                MessageBox.Show("¡Se edito correctamente!\n\n" + personaEditar.toString());
                return;
            }

            Persona persona = new Persona(CRUD.idSiguiente(Tablas.Persona), nombre, apellido, correo);
            centralDatos.Personas.Add(persona);
            centralDatos.InscripcionesPersonas.inscribir(persona);
            centralDatos.Insertar(persona);
            MessageBox.Show("¡Se Creo correctamente!\n\n" + persona.toString());
        }
    }
}
