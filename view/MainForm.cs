using Actividad.src;
using Actividad.view;

namespace Actividad
{
    public partial class Form1 : Form
    {
        CentralDatos centralDatos;
        public Form1()
        {
            InitializeComponent();

            centralDatos = new CentralDatos(new InscripcionesPersonas(), new CursosInscritos(), new CursosProfesores());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear una nueva pesta�a
            TabPage nuevaPesta�a = new TabPage();
            nuevaPesta�a.Text = "Pesta�a " + (tabControl1.TabCount + 1);

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
            formulario.BorderStyle = BorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            nuevaPesta�a.Controls.Add(formulario);
            formulario.Show();
            tabControl1.TabPages.Add(nuevaPesta�a);
            tabControl1.SelectedTab = nuevaPesta�a;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Mostrar un MessageBox con tres opciones: Guardar, No guardar y Cancelar
            DialogResult result = MessageBox.Show(
                "�Desea guardar los cambios antes de salir?", // Mensaje
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
    }
}
