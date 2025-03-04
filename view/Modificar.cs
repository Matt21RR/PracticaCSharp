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
    public partial class Modificar : UserControl
    {
        CentralDatos centralDatos;
        TabControl tabControl;
        public Modificar(CentralDatos centralDatos, TabControl tabControl)
        {
            InitializeComponent();
            this.centralDatos = centralDatos;
            this.tabControl = tabControl;

            elementoCombo.DataSource = centralDatos.Facultades;
            elementoCombo.DisplayMember = "nombre";
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            string tipoFormulario = tipoCombo.SelectedItem.ToString();
            try
            {
                centralDatos.Eliminar(elementoCombo.SelectedItem);
                switch (tipoFormulario)
                {
                    case "Estudiante":
                        centralDatos.Estudiantes.Remove((Estudiante)elementoCombo.SelectedItem);
                        break;
                    case "Persona":
                        centralDatos.Personas.Remove((Persona)elementoCombo.SelectedItem);
                        break;
                    case "Programa":
                        centralDatos.Programas.Remove((Programa)elementoCombo.SelectedItem);
                        break;
                    case "Facultad":
                        centralDatos.Facultades.Remove((Facultad)elementoCombo.SelectedItem);
                        break;
                    case "Profesor":
                        centralDatos.Profesores.Remove((Profesor)elementoCombo.SelectedItem);
                        break;
                    case "Curso":
                        centralDatos.Cursos.Remove((Curso)elementoCombo.SelectedItem);
                        break;
                    case "Inscripcion":
                        centralDatos.CursosInscritos.eliminar((Inscripcion)elementoCombo.SelectedItem);
                        break;
                    case "Curso con profesor":
                        centralDatos.CursosProfesores.eliminar((CursoProfesor)elementoCombo.SelectedItem);
                        break;
                    default:
                        MessageBox.Show("Selecciona un tipo válido.");
                        return;
                }

            }
            catch (Exception error) { 
                MessageBox.Show(error.ToString()); return;
            }
            
            MessageBox.Show("Elemento eliminado correctamente.");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoFormulario = tipoCombo.SelectedItem.ToString();

            switch (tipoFormulario)
            {
                case "Estudiante":
                    elementoCombo.DataSource = centralDatos.Estudiantes;
                    elementoCombo.DisplayMember = "NombreCompleto";
                    break;
                case "Persona":
                    elementoCombo.DataSource = centralDatos.Personas;
                    elementoCombo.DisplayMember = "NombreCompleto";
                    break;
                case "Programa":
                    elementoCombo.DataSource = centralDatos.Programas;
                    elementoCombo.DisplayMember = "nombre";
                    break;
                case "Facultad":
                    elementoCombo.DataSource = centralDatos.Facultades;
                    elementoCombo.DisplayMember = "nombre";
                    break;
                case "Profesor":
                    elementoCombo.DataSource = centralDatos.Profesores;
                    elementoCombo.DisplayMember = "NombreCompleto";
                    break;
                case "Curso":
                    elementoCombo.DataSource = centralDatos.Cursos;
                    elementoCombo.DisplayMember = "nombre";
                    break;
                case "Inscripcion":
                    elementoCombo.DataSource = centralDatos.InscripcionesPersonas.listado;
                    elementoCombo.DisplayMember = "ID";
                    break;
                case "Curso con profesor":
                    elementoCombo.DataSource = centralDatos.CursosInscritos.listado;
                    elementoCombo.DisplayMember = "ID";
                    break;
                default:
                    MessageBox.Show("Selecciona un tipo válido.");
                    return;
            }
        }

        private void guardarElementos_Click(object sender, EventArgs e)
        {
            string tipoFormulario = tipoCombo.SelectedItem.ToString();

            UserControl formulario = null;
            switch (tipoFormulario)
            {
                case "Estudiante":
                    formulario = new EstudianteForm(centralDatos, (Estudiante)elementoCombo.SelectedItem);
                    break;
                case "Persona":
                    formulario = new PersonaForm(centralDatos, (Persona)elementoCombo.SelectedItem);
                    break;
                case "Programa":
                    formulario = new ProgramaForm(centralDatos, (Programa)elementoCombo.SelectedItem);
                    break;
                case "Facultad":
                    formulario = new FacultadForm(centralDatos, (Facultad)elementoCombo.SelectedItem);
                    break;
                case "Profesor":
                    formulario = new ProfesorForm(centralDatos, (Profesor)elementoCombo.SelectedItem);
                    break;
                case "Curso":
                    formulario = new CursoForm(centralDatos, (Curso)elementoCombo.SelectedItem);
                    break;
                case "Inscripcion":
                    formulario = new InscripcionForm(centralDatos, (Inscripcion)elementoCombo.SelectedItem);
                    break;
                case "Curso con profesor":
                    formulario = new CursoProfesorForm(centralDatos, (CursoProfesor)elementoCombo.SelectedItem);
                    break;
                default:
                    MessageBox.Show("Selecciona un tipo válido.");
                    return;
            }
            TabPage nuevaPestania = new TabPage();
            nuevaPestania.Text = "Pestaña " + (tabControl.TabCount + 1);

            formulario.Dock = DockStyle.Fill;
            nuevaPestania.Controls.Add(formulario);
            formulario.Show();
            tabControl.TabPages.Add(nuevaPestania);
            tabControl.SelectedTab = nuevaPestania;
        }
    }
}
