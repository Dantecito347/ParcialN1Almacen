using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Parcial_Nº1___Almacen.MenuPrincipal;
using Almacen.Model;
using Almacen.Controller;

namespace Parcial_Nº1___Almacen
{
    public partial class MenuLacteos : UserControl
    {
        private DataRow lacteoSeleccionado;
        public event Action CambioaMenuPrincipalDesdeLacteos;
        public event Action CambioaMenuCarritoDesdeLacteos;
        public MenuLacteos()
        {
            InitializeComponent();
        }

        private void MenuLacteos_Load(object sender, EventArgs e)
        {
            MenuLacteosController lacteosController = new MenuLacteosController();
            DataTable tabla = lacteosController.ObtenerLacteos();

            listviewLacteos.View = View.Details;
            listviewLacteos.GridLines = true;
            listviewLacteos.FullRowSelect = true;
            listviewLacteos.MultiSelect = false;
                
            listviewLacteos.Columns.Clear();
            listviewLacteos.Columns.Add("ID", 50, HorizontalAlignment.Left);
            listviewLacteos.Columns.Add("Nombre", 150, HorizontalAlignment.Left);
            listviewLacteos.Columns.Add("Precio", 100, HorizontalAlignment.Left);
            listviewLacteos.Columns.Add("Stock", 80, HorizontalAlignment.Left);

            listviewLacteos.Items.Clear();
            foreach (DataRow fila in tabla.Rows)
            {
                ListViewItem item = new ListViewItem(fila["ID"].ToString());
                item.SubItems.Add(fila["Nombre"].ToString());
                item.SubItems.Add(fila["Precio"].ToString());
                item.SubItems.Add(fila["Stock"].ToString());
                listviewLacteos.Items.Add(item);

                item.Tag = fila;
            }
        }

        private void listviewLacteos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listviewLacteos.SelectedItems.Count > 0)
            {
                ListViewItem item = listviewLacteos.SelectedItems[0];

                int lacteoID = int.Parse(item.SubItems[0].Text);
                string nombre = item.SubItems[1].Text;
                int precio = (int)decimal.Parse(item.SubItems[2].Text);
                int cantidad = 1;

                Carrito itemCarrito = new Carrito
                {
                    ProductoID = lacteoID,
                    NombreProducto = nombre,
                    Precio = precio,
                    Cantidad = cantidad
                };

                CarritoController carritoController = new CarritoController();
                carritoController.AgregarCarrito(itemCarrito);

                MessageBox.Show($"Seleccionaste: {nombre}");
            }
        }
        private void VerCarrito_Click(object sender, EventArgs e)
        {
            CambioaMenuCarritoDesdeLacteos?.Invoke();
        }

        private void BotonRetroceder_Click(object sender, EventArgs e)
        {
            CambioaMenuPrincipalDesdeLacteos?.Invoke();
        }
    }
}
