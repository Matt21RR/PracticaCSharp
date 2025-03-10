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
    public partial class ModificarForm : UserControl
    {
        CentralDatos centralDatos;
        GestorPestanas gestorPestanas;
        public ModificarForm(CentralDatos centralDatos, GestorPestanas gestorPestanas)
        {
            InitializeComponent();
            this.centralDatos = centralDatos;
            this.gestorPestanas = gestorPestanas;

            elementoCombo.DataSource = centralDatos.Facultades;
            elementoCombo.DisplayMember = "nombre";
        }


        // Evento correspondiente del boton eliminar elemento
        private void eliminarButton_Click(object sender, EventArgs e)
        {
            string tipo = tipoCombo.SelectedItem.ToString();
            object elemento = elementoCombo.SelectedItem;

            try
            {
                centralDatos.EliminarElemento(elemento, tipo);
                MessageBox.Show("Elemento eliminado correctamente.");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }


        // Actualiza el comboBox de elementos dependiendo del tipo seleccionado
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = tipoCombo.SelectedItem.ToString();
            elementoCombo.DataSource = centralDatos.ObtenerLista(tipo);
            elementoCombo.DisplayMember = centralDatos.ObtenerDisplayMember(tipo);
        }

        private void guardarElementos_Click(object sender, EventArgs e)
        {
            string tipo = tipoCombo.SelectedItem.ToString();
            object elemento = elementoCombo.SelectedItem;

            UserControl formulario = FabricaFormularios.CrearFormulario(tipo, centralDatos, elemento);
            gestorPestanas.AgregarPestana(formulario, "Pestaña " + (gestorPestanas.NumeroPestanas + 1));
        }
    }
}
