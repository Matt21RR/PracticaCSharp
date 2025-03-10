using Actividad.src;
using Actividad.view;
using System.Xml.Linq;

namespace Actividad
{
    public partial class Form1 : Form
    {
        CentralDatos centralDatos;
        GestorPestanas gestorPestanas;
        public Form1()
        {   InscripcionesPersonas inscripcionesPersonas = new InscripcionesPersonas();
            CursosInscritos cursosInscritos = new CursosInscritos();
            CursosProfesores cursosProfesores = new CursosProfesores();

            IPersistenciaDatos cargadorDatosBaseDeDatos = new CargadorDatosBaseDeDatos(inscripcionesPersonas, cursosInscritos, cursosProfesores); 
            centralDatos = new CentralDatos(inscripcionesPersonas, cursosInscritos, cursosProfesores, cargadorDatosBaseDeDatos);
            
            InitializeComponent();
            gestorPestanas = new GestorPestanas(tabControl1);
        }


        // Agregar nueva pestaña
        private void button1_Click(object sender, EventArgs e) 
        {

            // Obtener el tipo de formulario seleccionado en el ComboBox
            string tipoFormulario = nuevaClaseCombo.SelectedItem.ToString();
            
            try // Este try por alguna razon no funciona
            { 
                UserControl formulario = FabricaFormularios.CrearFormulario(tipoFormulario, centralDatos);
                gestorPestanas.AgregarPestana(formulario, "Pestaña " + (gestorPestanas.NumeroPestanas + 1));
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Mostrar un MessageBox con tres opciones: Guardar, No guardar y Cancelar
            DialogResult result = MessageBox.Show(
                "¿Desea guardar los cambios antes de salir?", // Mensaje
                "Confirmar cierre",                          // T�tulo
                MessageBoxButtons.YesNoCancel,               // Botones: S�, No, Cancelar
                MessageBoxIcon.Question                     // Icono de pregunta
            );

            // Manejar la respuesta del usuario
            switch (result)
            {
                case DialogResult.Yes:
                    // Guardar los cambios
                    centralDatos.InscripcionesPersonas.actualizarInformacionGuardada();
                    centralDatos.CursosProfesores.actualizarInformacionGuardada();
                    centralDatos.CursosInscritos.actualizarInformacionGuardada();
                    MessageBox.Show("Los cambios han sido guardados.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case DialogResult.No:
                    // No guardar los cambios
                    MessageBox.Show("Los cambios no han sido guardados.", "No guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                case DialogResult.Cancel:
                    // Cancelar el cierre del formulario
                    e.Cancel = true; // Evita que el formulario se cierre
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModificarForm modificar = new ModificarForm(centralDatos, gestorPestanas);
            gestorPestanas.AgregarPestana(modificar, "Modificar");
        }
    }
}
