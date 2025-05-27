using Almacen.Controller;
using Almacen.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Parcial_Nº1___Almacen.MenuPrincipal;
using Parcial_Nº1___Almacen;


namespace Parcial_Nº1___Almacen
{
    public partial class MenuCarrito : UserControl
    {
        public static string RepartidorSeleccionado { get; set; }
        public event Action CambioaMenuProductosDesdeCarrito;
        public event Action CambioaMenuPrincipalDesdeCarrito;

        public MenuCarrito()
        {
            InitializeComponent();
            CargarProductosCarrito();
            CargarRepartidor();
        }

        public void RefrescarVista() 
        {             
            CargarProductosCarrito();
            CargarRepartidor();
        }
        private void CargarProductosCarrito()
        {
            listBox1.Items.Clear();
            CarritoController carritoController = new CarritoController();
            var productos = carritoController.MostrarCarrito();
            foreach (var producto in productos)
            {
                listBox1.Items.Add($"{producto.NombreProducto} - Precio: {producto.Precio} - Cantidad: {producto.Cantidad}");
            }
        }

        private void CargarRepartidor()
        {
            if (!string.IsNullOrEmpty(RepartidorSeleccionado))
            {
                lblRepartidor.Text = $"Repartidor: {RepartidorSeleccionado}";
            }
            else
            {
                lblRepartidor.Text = "Repartidor: (ninguno seleccionado)";
            }
        }
        private void MenuCarrito_Load(object sender, EventArgs e)
        {
            CargarProductosCarrito();
            CargarRepartidor();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            CambioaMenuProductosDesdeCarrito?.Invoke();
        }

        private void Modificar_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex >= 0)
            {
                string itemTexto = listBox1.SelectedItem.ToString();

                string nombreProducto = itemTexto.Split('-')[0].Trim();

                string input = Microsoft.VisualBasic.Interaction.InputBox(
                    "Ingrese la nueva cantidad:", "Modificar cantidad", "1");
                if (!int.TryParse(input, out int nuevaCantidad) || nuevaCantidad < 1)
                {
                    MessageBox.Show("Cantidad inválida.");
                    return;
                }

                CarritoController carritoController = new CarritoController();
                var productos = carritoController.MostrarCarrito();
                var producto = productos.FirstOrDefault(p => p.NombreProducto == nombreProducto);

                if (producto != null)
                {
                    producto.Cantidad = nuevaCantidad;
                    carritoController.ModificarCarrito(producto);
                    MessageBox.Show($"Cantidad modificada para: {nombreProducto}");
                    CargarProductosCarrito();
                }
                else
                {
                    MessageBox.Show("No se encontró el producto en el carrito.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto para modificar.");
            }
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                string itemTexto = listBox1.SelectedItem.ToString();

                string nombreProducto = itemTexto.Split('-')[0].Trim();

                CarritoController carritoController = new CarritoController();
                var productos = carritoController.MostrarCarrito();
                var producto = productos.FirstOrDefault(p => p.NombreProducto == nombreProducto);

                if (producto != null)
                {
                    carritoController.EliminarCarrito(producto.ProductoID);
                    MessageBox.Show($"Producto eliminado: {nombreProducto}");
                    CargarProductosCarrito();
                }
                else
                {
                    MessageBox.Show("No se encontró el producto en el carrito.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto para borrar.");
            }
        }

        private void FinalizarCompra_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
        "¿Estás seguro de finalizar la compra?",
        "Confirmar compra",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                CarritoController carritoController = new CarritoController();
                carritoController.VaciarCarrito();

                RepartidorSeleccionado = null;
                CargarRepartidor();
                CargarProductosCarrito();

                MessageBox.Show("¡Gracias por la compra, que tengas un buen día!", "Compra finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Retroceder_Click(object sender, EventArgs e)
        {
            CambioaMenuPrincipalDesdeCarrito?.Invoke();
        }

        
    }
}
