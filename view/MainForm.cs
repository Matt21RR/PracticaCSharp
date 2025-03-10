using Actividad.src;
using Actividad.view;

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

        private void button1_Click(object sender, EventArgs e)
        {

            // Obtener el tipo de formulario seleccionado en el ComboBox
            string tipoFormulario = nuevaClaseCombo.SelectedItem.ToString();

            // Instanciar el formulario correspondiente
            UserControl formulario = null;
            switch (tipoFormulario)
            {
                case "Estudiante":
                    formulario = new EstudianteForm(centralDatos);
                    break;
                case "Persona":
                    formulario = new PersonaForm(centralDatos);
                    break;
                case "Programa":
                    formulario = new ProgramaForm(centralDatos);
                    break;
                case "Facultad":
                    formulario = new FacultadForm(centralDatos);
                    break;
                case "Profesor":
                    formulario = new ProfesorForm(centralDatos);
                    break;
                case "Curso":
                    formulario = new CursoForm(centralDatos);
                    break;
                case "Inscripcion":
                    formulario = new InscripcionForm(centralDatos);
                    break;
                case "Curso con profesor":
                    formulario = new CursoProfesorForm(centralDatos);
                    break;
                default:
                    MessageBox.Show("Selecciona un tipo v�lido.");
                    return;
            }

            // Configurar el formulario para que se muestre dentro de la pesta�a
            gestorPestanas.AgregarPestana( formulario, "Pestaña " + (gestorPestanas.NumeroPestanas + 1));
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
            TabPage nuevaPestania = new TabPage();
            nuevaPestania.Text = "Pesta�a " + (tabControl1.TabCount + 1);

            Modificar modificar = new Modificar(centralDatos, tabControl1);
            modificar.Dock = DockStyle.Fill;
            nuevaPestania.Controls.Add(modificar);
            modificar.Show();
            tabControl1.TabPages.Add(nuevaPestania);
            tabControl1.SelectedTab = nuevaPestania;
        }
    }
}
