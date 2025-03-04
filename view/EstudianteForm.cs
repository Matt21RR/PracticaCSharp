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
    public partial class EstudianteForm : UserControl, ModificarElemento
    {
        CentralDatos centralDatos;
        Estudiante estudianteEditar;
        public EstudianteForm(CentralDatos centralDatos, Estudiante estudianteEditar = null)
        {
            this.centralDatos = centralDatos;
            InitializeComponent();

            programaCombo.DataSource = centralDatos.Programas;
            programaCombo.DisplayMember = "nombre";

            this.estudianteEditar = estudianteEditar;
            if (estudianteEditar != null )
            {
                nombreInput.Text = estudianteEditar.nombres;
                apellidoInput.Text = estudianteEditar.apellidos;
                correoElectronicoInput.Text = estudianteEditar.email;
                programaCombo.SelectedItem = estudianteEditar.programa;
                promedioInput.Value = Convert.ToDecimal(estudianteEditar.promedio);
                activoCheckBox.Checked = estudianteEditar.activo;
            }
        }

        private void guardarEstudiante_Click(object sender, EventArgs e)
        {
            crearOEditar();
        }

        public void crearOEditar()
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

            if (estudianteEditar != null)
            {
                estudianteEditar.nombres = nombre;
                estudianteEditar.apellidos = apellido;
                estudianteEditar.email = correo;
                estudianteEditar.programa = programa;
                estudianteEditar.promedio = promedio;
                estudianteEditar.activo = activo;
                centralDatos.Actualizar(estudianteEditar);
                MessageBox.Show("¡Se edito correctamente!\n\n" + estudianteEditar.toString());
                return;
            }
            Persona persona = new Persona(CRUD.idSiguiente(Tablas.Persona), nombre, apellido, correo);
            Estudiante estudiante = new Estudiante(persona,CRUD.idSiguiente(Tablas.Estudiante), programa, activo, promedio);

            centralDatos.Personas.Add(estudiante);
            centralDatos.Estudiantes.Add(estudiante);
            centralDatos.InscripcionesPersonas.inscribir(estudiante);

            centralDatos.Insertar(persona);
            centralDatos.Insertar(estudiante);
            MessageBox.Show("¡Se Creo correctamente!\n\n" + estudiante.toString());
        }
    }
}
