using Almacen.Controller;
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

namespace Parcial_Nº1___Almacen
{
    
    public partial class MenuEnvios : UserControl
    {
        public event Action CambioaMenuPrincipal;
        public event Action CambioaMenuCarritoDesdeEnvios;
        public MenuEnvios()
        {
            InitializeComponent();
        }

        private void MenuEnvios_Load(object sender, EventArgs e)
        {
            RepartidorController repartidorController = new RepartidorController();
            DataTable tabla = repartidorController.ObtenerRepartidores();

            listViewRepartidores.View = View.Details;
            listViewRepartidores.GridLines = true;
            listViewRepartidores.FullRowSelect = true;
            listViewRepartidores.MultiSelect = false;

            listViewRepartidores.Columns.Clear();
            listViewRepartidores.Columns.Add("ID", 50, HorizontalAlignment.Left);
            listViewRepartidores.Columns.Add("Nombre", 120, HorizontalAlignment.Left);
            listViewRepartidores.Columns.Add("Apellido", 120, HorizontalAlignment.Left);
            listViewRepartidores.Columns.Add("Email", 150, HorizontalAlignment.Left);
            listViewRepartidores.Columns.Add("Celular", 100, HorizontalAlignment.Left);
            listViewRepartidores.Columns.Add("Localidad", 100, HorizontalAlignment.Left);
            listViewRepartidores.Columns.Add("Vehículo", 100, HorizontalAlignment.Left);

            listViewRepartidores.Items.Clear();
            foreach (DataRow fila in tabla.Rows)
            {
                ListViewItem item = new ListViewItem(fila["PersonaID"].ToString());
                item.SubItems.Add(fila["Nombre"].ToString());
                item.SubItems.Add(fila["Apellido"].ToString());
                item.SubItems.Add(fila["Email"].ToString());
                item.SubItems.Add(fila["Celular"].ToString());
                item.SubItems.Add(fila["Localidad"].ToString());
                item.SubItems.Add(fila["TipoDeVehiculo"].ToString());
                item.Tag = fila;
                listViewRepartidores.Items.Add(item);
            }
        }
        

        private void listViewRepartidores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewRepartidores.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewRepartidores.SelectedItems[0];


                string nombre = item.SubItems[1].Text;
                string apellido = item.SubItems[2].Text;
                string repartidorCompleto = $"{nombre} {apellido}";

                MenuCarrito.RepartidorSeleccionado = repartidorCompleto;
                MessageBox.Show($"Seleccionaste al repartidor: {repartidorCompleto}");

            }
        }

        private void BotonRetroceder_Click(object sender, EventArgs e)
        {
            CambioaMenuPrincipal?.Invoke();
        }

        private void VerCarrito_Click(object sender, EventArgs e)
        {
            CambioaMenuCarritoDesdeEnvios?.Invoke();
        }

        private void btnAgregarRepartidor_Click(object sender, EventArgs e)
        {
            string nombre = Microsoft.VisualBasic.Interaction.InputBox("Nombre:", "Agregar Repartidor");
            string apellido = Microsoft.VisualBasic.Interaction.InputBox("Apellido:", "Agregar Repartidor");
            string email = Microsoft.VisualBasic.Interaction.InputBox("Email:", "Agregar Repartidor");
            string celular = Microsoft.VisualBasic.Interaction.InputBox("Celular:", "Agregar Repartidor");
            string localidad = Microsoft.VisualBasic.Interaction.InputBox("Localidad:", "Agregar Repartidor");
            string tipoVehiculo = Microsoft.VisualBasic.Interaction.InputBox("Tipo de Vehículo:", "Agregar Repartidor");

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido))
            {
                MessageBox.Show("Nombre y Apellido son obligatorios.");
                return;
            }

            var repartidor = new Almacen.Model.Repartidor
            {
                Nombre = nombre,
                Apellido = apellido,
                Email = email,
                Celular = celular,
                Localidad = localidad,
                TipoDeVehiculo = tipoVehiculo
            };

            var controller = new RepartidorController();
            controller.AgregarRepartidor(repartidor);
            MessageBox.Show("Repartidor agregado correctamente.");
            MenuEnvios_Load(null, null);
        }

        private void btnBorrarRepartidor_Click(object sender, EventArgs e)
        {
            if (listViewRepartidores.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un repartidor para eliminar.");
                return;
            }

            ListViewItem item = listViewRepartidores.SelectedItems[0];
            int id = int.Parse(item.SubItems[0].Text);

            var controller = new RepartidorController();
            controller.EliminarRepartidor(id);
            MessageBox.Show("Repartidor eliminado correctamente.");
            MenuEnvios_Load(null, null);
        }

        private void btnModificarRepartidor_Click(object sender, EventArgs e)
        {
            if (listViewRepartidores.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un repartidor para modificar.");
                return;
            }

            ListViewItem item = listViewRepartidores.SelectedItems[0];
            int id = int.Parse(item.SubItems[0].Text);

            string nombre = Microsoft.VisualBasic.Interaction.InputBox("Nuevo Nombre:", "Modificar Repartidor", item.SubItems[1].Text);
            string apellido = Microsoft.VisualBasic.Interaction.InputBox("Nuevo Apellido:", "Modificar Repartidor", item.SubItems[2].Text);
            string email = Microsoft.VisualBasic.Interaction.InputBox("Nuevo Email:", "Modificar Repartidor", item.SubItems[3].Text);
            string celular = Microsoft.VisualBasic.Interaction.InputBox("Nuevo Celular:", "Modificar Repartidor", item.SubItems[4].Text);
            string localidad = Microsoft.VisualBasic.Interaction.InputBox("Nueva Localidad:", "Modificar Repartidor", item.SubItems[5].Text);
            string tipoVehiculo = Microsoft.VisualBasic.Interaction.InputBox("Nuevo Tipo de Vehículo:", "Modificar Repartidor", item.SubItems[6].Text);

            var repartidor = new Almacen.Model.Repartidor
            {
                ID = id,
                Nombre = nombre,
                Apellido = apellido,
                Email = email,
                Celular = celular,
                Localidad = localidad,
                TipoDeVehiculo = tipoVehiculo
            };

            var controller = new RepartidorController();
            controller.ModificarRepartidor(repartidor);
            MessageBox.Show("Repartidor modificado correctamente.");
            MenuEnvios_Load(null, null);
        }
    }
}
