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
    public partial class ProgramaForm : UserControl, ModificarElemento
    {
        CentralDatos centralDatos;
        private Programa programaEditar;
        public ProgramaForm(CentralDatos centralDatos, Programa programaEditar = null)
        {
            InitializeComponent();
            this.centralDatos = centralDatos;

            facultadCombo.DataSource = centralDatos.Facultades;
            facultadCombo.DisplayMember = "nombre";

            this.programaEditar = programaEditar;
            if (programaEditar != null) // Inicializar los campos si se va a editar
            {
                nombreInput.Text = programaEditar.nombre;
                duracionInput.Value = Convert.ToDecimal(programaEditar.duracion);
                registroDate.Value = programaEditar.registro;
                facultadCombo.SelectedItem = programaEditar.facultad;
            }
        }

        private void crearPrograma_Click(object sender, EventArgs e)
        {
            crearOEditar();
        }

        public void crearOEditar()
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

            if (programaEditar != null)
            {
                programaEditar.facultad = facultad;
                programaEditar.nombre = nombre;
                programaEditar.duracion = duracion;
                programaEditar.registro = registro;
                centralDatos.Actualizar(programaEditar);
                MessageBox.Show("¡Se edito correctamente!\n\n" + programaEditar.toString());
                return;
            }

            Programa programa = new Programa(CRUD.idSiguiente(Tablas.Programa), nombre, duracion, registro, facultad);
            centralDatos.Programas.Add(programa);
            centralDatos.Insertar(programa);
            MessageBox.Show("¡Se Creo correctamente!\n\n" + programa.toString());
        }
    }
}
