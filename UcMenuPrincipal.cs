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
    public partial class UcMenuPrincipal : UserControl
    {
        public event Action CambioaMenuEnvios;
        public event Action CambioaMenuProductos;
        public event Action CambioaMenuCarrito;
        public UcMenuPrincipal()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void UcMenuPrincipal_Load(object sender, EventArgs e)
        {

        }


        private void MenuProductos_Click(object sender, EventArgs e)
        {
            CambioaMenuProductos?.Invoke();
        }

        private void MenuEnvios_Click(object sender, EventArgs e)
        {
            CambioaMenuEnvios?.Invoke();
        }

        private void MenuCarrito_Click(object sender, EventArgs e)
        {
            CambioaMenuCarrito?.Invoke();
        }
    }
}
