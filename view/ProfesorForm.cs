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
    public partial class ProfesorForm : UserControl, ModificarElemento
    {
        CentralDatos centralDatos;
        Profesor profesorEditar;
        public ProfesorForm(CentralDatos centralDatos, Profesor profesorEditar = null)
        {
            InitializeComponent();
            this.centralDatos = centralDatos;
            this.profesorEditar = profesorEditar;

            if (profesorEditar != null)
            {
                nombreInput.Text = profesorEditar.nombres;
                apellidoInput.Text = profesorEditar.apellidos;
                correoElectronicoInput.Text = profesorEditar.email;
                tipoContratoInput.Text = profesorEditar.tipoContrato;
            }
        }

        private void guardarProfesor_Click(object sender, EventArgs e)
        {
            crearOEditar();
        }

        public void crearOEditar()
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

            if (profesorEditar != null)
            {
                profesorEditar.nombres = nombre;
                profesorEditar.apellidos = apellido;
                profesorEditar.email = correo;
                profesorEditar.tipoContrato = tipoContrato;
                centralDatos.Actualizar(profesorEditar);
                MessageBox.Show("¡Se edito correctamente!\n\n" + profesorEditar.toString());
                return;
            }

            // TODO: Aqui tener en cuenta la ID de profesor es correspondiente a la lista de personas
            Profesor profesor = new Profesor(nombre, apellido, correo, tipoContrato);

            centralDatos.Personas.Add(profesor);
            centralDatos.Profesores.Add(profesor);
            centralDatos.InscripcionesPersonas.inscribir(profesor);
            centralDatos.Insertar(profesor);
            MessageBox.Show("¡Se Creo correctamente!\n\n" + profesor.toString());
        }
    }
}
