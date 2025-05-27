using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static Parcial_Nº1___Almacen.MenuPrincipal;
using Almacen.Model;
using Almacen.Controller;

namespace Parcial_Nº1___Almacen
{ 
    public partial class UcMenuAlimentos : UserControl
    {
        private DataRow alimentoSeleccionado;
        public event Action CambioaMenuPrincipalDesdeAlimentos;
        public event Action CambioaMenuCarritoDesdeAlimentos;
        public UcMenuAlimentos()
        {
            InitializeComponent();
          
        }

        private void UcMenuAlimentos_Load(object sender, EventArgs e)
        {
            MenuAlimentosController alimentosController = new MenuAlimentosController();
            DataTable tabla = alimentosController.ObtenerAlimentos();

            listviewAlimentos.View = View.Details;
            listviewAlimentos.GridLines = true;
            listviewAlimentos.FullRowSelect = true;
            listviewAlimentos.MultiSelect = false;

            listviewAlimentos.Columns.Clear();
            listviewAlimentos.Columns.Add("ID", 50, HorizontalAlignment.Left);
            listviewAlimentos.Columns.Add("Nombre", 150, HorizontalAlignment.Left);
            listviewAlimentos.Columns.Add("Precio", 100, HorizontalAlignment.Left);
            listviewAlimentos.Columns.Add("Stock", 80, HorizontalAlignment.Left);

            listviewAlimentos.Items.Clear();
            foreach (DataRow fila in tabla.Rows)
            {
                ListViewItem item = new ListViewItem(fila["ProductosID"].ToString());
                item.SubItems.Add(fila["Nombre"].ToString());
                item.SubItems.Add(fila["Precio"].ToString());
                item.SubItems.Add(fila["Stock"].ToString());
                listviewAlimentos.Items.Add(item);

                item.Tag = fila;
            }

        }

        private void listviewAlimentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listviewAlimentos.SelectedItems.Count > 0)
            {
                ListViewItem item = listviewAlimentos.SelectedItems[0];

                int productoID = int.Parse(item.SubItems[0].Text);
                string nombre = item.SubItems[1].Text;
                int precio = (int)decimal.Parse(item.SubItems[2].Text);
                int stock = 1;

                Carrito itemCarrito = new Carrito
                {
                    ProductoID = productoID,
                    NombreProducto = nombre,
                    Precio = precio,
                    Cantidad = stock
                };

                CarritoController carritoController = new CarritoController();
                carritoController.AgregarCarrito(itemCarrito);

                MessageBox.Show($"Seleccionaste: {nombre}");
            }

        }

        private void VerCarrito_Click(object sender, EventArgs e)
        {
            CambioaMenuCarritoDesdeAlimentos?.Invoke();
        }

        private void BotonRetroceder_Click(object sender, EventArgs e)
        {
            CambioaMenuPrincipalDesdeAlimentos?.Invoke();
        }
    }

}