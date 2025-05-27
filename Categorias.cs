using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_Nº1___Almacen
{
    public partial class UcPRODUCTOS : UserControl
    {
        public event Action CambioaMenuPrincipalDesdeProductos;
        public event Action CambioaMenuPrincipalDeUna;
        public event Action CambioamenuAlimentos;
        public event Action CambioamenuBebidas;
        public event Action CambioamenuLacteos;
        public UcPRODUCTOS()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void MenuAlimentos_Click(object sender, EventArgs e)
        {
            CambioamenuAlimentos?.Invoke();
        }

        private void MenuBebidas_Click(object sender, EventArgs e)
        {
            CambioamenuBebidas?.Invoke();
        }

        private void BotonRetroceder_Click(object sender, EventArgs e)
        {
            CambioaMenuPrincipalDesdeProductos?.Invoke();
        }

        private void MenuLacteos_Click(object sender, EventArgs e)
        {
            CambioamenuLacteos?.Invoke();
        }
    }
}
