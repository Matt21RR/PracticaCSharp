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


        // Actualiza el comboBox de elementos dependiendo del tipo seleccionado
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
                    elementoCombo.DataSource = centralDatos.CursosInscritos.listado;
                    elementoCombo.DisplayMember = "ID";
                    break;
                case "Curso con profesor":
                    elementoCombo.DataSource = centralDatos.CursosProfesores.listado;
                    elementoCombo.DisplayMember = "ID";
                    break;
                default:
                    MessageBox.Show("Selecciona un tipo válido.");
                    return;
            }
        }


        // Evento correspondiente del boton editar elemento
        private void guardarElementos_Click(object sender, EventArgs e) 
        {
            string tipoFormulario = tipoCombo.SelectedItem.ToString();


            string tipo = tipoCombo.SelectedItem.ToString();
            object elemento = elementoCombo.SelectedItem;

            UserControl formulario = FabricaFormularios.CrearFormulario(tipo, centralDatos, elemento);
            gestorPestanas.AgregarPestana(formulario, "Pestaña " + (gestorPestanas.NumeroPestanas + 1));

        }
    }
}
