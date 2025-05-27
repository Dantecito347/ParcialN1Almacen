using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Almacen.Model;
using Almacen.Controller;

namespace Parcial_Nº1___Almacen
{
    public partial class MenuPrincipal : Form
    {
        private UcMenuPrincipal ucmenuPrincipal;
        private MenuEnvios ucmenuEnvios;
        private MenuCarrito ucmenuCarrito;
        private UcPRODUCTOS ucCategorias;
        private UcMenuAlimentos ucmenuAlimentos;
        private UcMenuBebidas ucmenuBebidas;
        private MenuLacteos ucmenuLacteos;
        public static Carrito MiCarrito = new Carrito();
        public MenuPrincipal()
        {
            InitializeComponent();
            InicializarUserControls();
            MostrarUserControl(ucmenuPrincipal);
            this.Dock = DockStyle.Fill;
        }

        private void InicializarUserControls()
        {
            ucmenuPrincipal = new UcMenuPrincipal();
            ucmenuEnvios = new MenuEnvios();
            ucCategorias = new UcPRODUCTOS();
            ucmenuCarrito = new MenuCarrito();
            ucmenuAlimentos = new UcMenuAlimentos();
            ucmenuBebidas = new UcMenuBebidas();
            ucmenuLacteos = new MenuLacteos();


            ucmenuPrincipal.CambioaMenuEnvios += () =>
            {
                ucmenuCarrito.RefrescarVista();
                MostrarUserControl(ucmenuEnvios);
            };

            ucmenuEnvios.CambioaMenuPrincipal += () =>
            {
                ucmenuCarrito.RefrescarVista();
                MostrarUserControl(ucmenuPrincipal);
            };

            ucCategorias.CambioaMenuPrincipalDesdeProductos += () =>
            {
                ucmenuCarrito.RefrescarVista();
                MostrarUserControl(ucmenuPrincipal);
            };

            ucCategorias.CambioaMenuPrincipalDeUna += () =>
            {
                ucmenuCarrito.RefrescarVista();
                MostrarUserControl(ucmenuPrincipal);
            };

            ucCategorias.CambioamenuAlimentos += () =>
            {
                ucmenuCarrito.RefrescarVista();
                MostrarUserControl(ucmenuAlimentos);
            };

            ucmenuAlimentos.CambioaMenuPrincipalDesdeAlimentos += () =>
            {
                ucmenuCarrito.RefrescarVista();
                MostrarUserControl(ucCategorias);
            };

            ucCategorias.CambioamenuBebidas += () =>
            {
                ucmenuCarrito.RefrescarVista();
                MostrarUserControl(ucmenuBebidas);
            };

            ucmenuBebidas.CambioaMenuPrincipalDesdeBebidas += () =>
            {
                ucmenuCarrito.RefrescarVista();
                MostrarUserControl(ucCategorias);
            };

            ucCategorias.CambioamenuLacteos += () =>
            {
                ucmenuCarrito.RefrescarVista();
                MostrarUserControl(ucmenuLacteos);
            };

            ucmenuLacteos.CambioaMenuPrincipalDesdeLacteos += () =>
            {
                ucmenuCarrito.RefrescarVista();
                MostrarUserControl(ucCategorias);
            };

            ucmenuPrincipal.CambioaMenuProductos += () =>
            {
                ucmenuCarrito.RefrescarVista();
                MostrarUserControl(ucCategorias);
            };

            ucmenuPrincipal.CambioaMenuCarrito += () =>
            {
                ucmenuCarrito.RefrescarVista();
                MostrarUserControl(ucmenuCarrito);
            };

            ucmenuAlimentos.CambioaMenuCarritoDesdeAlimentos += () =>
            {
                ucmenuCarrito.RefrescarVista();
                MostrarUserControl(ucmenuCarrito);
            };

            ucmenuCarrito.CambioaMenuProductosDesdeCarrito += () =>
            {
                ucmenuCarrito.RefrescarVista();
                MostrarUserControl(ucCategorias);
            };

            ucmenuCarrito.CambioaMenuPrincipalDesdeCarrito += () =>
            {
                MostrarUserControl(ucmenuPrincipal);
            };

            ucmenuLacteos.CambioaMenuCarritoDesdeLacteos += () =>
            {
                ucmenuCarrito.RefrescarVista();
                MostrarUserControl(ucmenuCarrito);
            };

            ucmenuBebidas.CambioaMenuCarritoDesdeBebidas += () =>
            {
                ucmenuCarrito.RefrescarVista();
                MostrarUserControl(ucmenuCarrito);
            };

            ucmenuEnvios.CambioaMenuCarritoDesdeEnvios += () =>
            {
                ucmenuCarrito.RefrescarVista();
                MostrarUserControl(ucmenuCarrito);
            };
        }

        public void MostrarUserControl(UserControl uc)
        {
            PanelContenedor.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            PanelContenedor.Controls.Add(uc);
        }

        
    }
}
