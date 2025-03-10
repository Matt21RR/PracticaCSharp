using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.src
{
    public class GestorPestanas
    {
        private TabControl _tabControl;

        public GestorPestanas(TabControl tabControl)
        {
            _tabControl = tabControl;
        }

        public int NumeroPestanas => _tabControl.TabCount;

        public void AgregarPestana(UserControl formulario, string titulo)
        {
            TabPage nuevaPestania = new TabPage();
            nuevaPestania.Text = titulo;
            formulario.BorderStyle = BorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            nuevaPestania.Controls.Add(formulario);
            _tabControl.TabPages.Add(nuevaPestania);
            _tabControl.SelectedTab = nuevaPestania;
        }
    }
}
