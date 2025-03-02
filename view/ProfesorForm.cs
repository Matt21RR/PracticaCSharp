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
    public partial class ProfesorForm : UserControl
    {
        CentralDatos centralDatos;
        public ProfesorForm(CentralDatos centralDatos)
        {
            InitializeComponent();
            this.centralDatos = centralDatos;
        }

        private void guardarProfesor_Click(object sender, EventArgs e)
        {
            string nombre = nombreInput.Text;
            string apellido = apellidoInput.Text;
            string correo = correoElectronicoInput.Text;
            string tipoContrato = tipoContratoInput.Text;

            if (nombre == "" || apellido == "" || correo == "" || tipoContrato == "")
            {
                MessageBox.Show("Por favor, llena todos los campos.");
                return;
            }
            // TODO: Aqui tener en cuenta la ID de profesor es correspondiente a la lista de personas
            Profesor profesor = new Profesor(centralDatos.Personas.Count + 1, nombre, apellido, correo, tipoContrato);

            centralDatos.Personas.Add(profesor);
            centralDatos.Profesores.Add(profesor);
            centralDatos.InscripcionesPersonas.inscribir(profesor);

            MessageBox.Show("¡Se Creo correctamente!\n\n" + profesor.toString());
        }
    }
}
