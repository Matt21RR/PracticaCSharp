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
    public partial class CursoProfesorForm: UserControl
    {
        CentralDatos centralDatos;
        public CursoProfesorForm(CentralDatos centralDatos)
        {
            InitializeComponent();
            this.centralDatos = centralDatos;

            cursoCombo.DataSource = centralDatos.Cursos;
            cursoCombo.DisplayMember = "nombre";

            profesorCombo.DataSource = centralDatos.Profesores;
            profesorCombo.DisplayMember = "nombre";
        }
    }
}
