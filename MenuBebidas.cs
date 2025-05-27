using Almacen.Controller;
using Almacen.Model;
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

namespace Parcial_Nº1___Almacen
{
    public partial class UcMenuBebidas : UserControl
    {
        private DataRow bebidaSeleccionado;
        public event Action CambioaMenuPrincipalDesdeBebidas;
        public event Action CambioaMenuCarritoDesdeBebidas;
        public UcMenuBebidas()
        {
            InitializeComponent();
        }

        private void MenuBebidas_Load(object sender, EventArgs e)
        {
            MenuBebidasController bebidasController = new MenuBebidasController();
            DataTable tabla = bebidasController.ObtenerBebidas();

            listviewBebidas.View = View.Details;
            listviewBebidas.GridLines = true;
            listviewBebidas.FullRowSelect = true;
            listviewBebidas.MultiSelect = false;

            listviewBebidas.Columns.Clear();
            listviewBebidas.Columns.Add("ID", 50, HorizontalAlignment.Left);
            listviewBebidas.Columns.Add("Nombre", 150, HorizontalAlignment.Left);
            listviewBebidas.Columns.Add("Precio", 100, HorizontalAlignment.Left);
            listviewBebidas.Columns.Add("Stock", 80, HorizontalAlignment.Left);

            listviewBebidas.Items.Clear();
            foreach (DataRow fila in tabla.Rows)
            {
                ListViewItem item = new ListViewItem(fila["ID"].ToString());
                item.SubItems.Add(fila["Nombre"].ToString());
                item.SubItems.Add(fila["Precio"].ToString());
                item.SubItems.Add(fila["Stock"].ToString());
                listviewBebidas.Items.Add(item);

                item.Tag = fila;
            }


        }

        private void listviewBebidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listviewBebidas.SelectedItems.Count > 0)
            {
                ListViewItem item = listviewBebidas.SelectedItems[0];

                int bebidaID = int.Parse(item.SubItems[0].Text);
                string nombre = item.SubItems[1].Text;
                int precio = (int)decimal.Parse(item.SubItems[2].Text);
                int cantidad = 1; 

                Carrito itemCarrito = new Carrito
                {
                    ProductoID = bebidaID,
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
            CambioaMenuCarritoDesdeBebidas?.Invoke();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CambioaMenuPrincipalDesdeBebidas?.Invoke();
        }
    }
}
