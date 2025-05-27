using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Almacen.Model;


namespace Almacen.Controller
{
    public class CarritoController
    {
        private DataBase database = new DataBase();
        
        public List<Carrito> MostrarCarrito()
        {
            string query = "SELECT ProductoID, NombreProducto, Precio, Cantidad FROM Carrito";
            DataTable tabla = database.Select(query);

            List<Carrito> lista = new List<Carrito>();
            foreach (DataRow row in tabla.Rows)
            {
                lista.Add(new Carrito
                {
                    ProductoID = (int)row["ProductoID"],
                    NombreProducto = row["NombreProducto"].ToString(),
                    Precio = (int)(decimal)row["Precio"],
                    Cantidad = (int)row["Cantidad"]
                });
            }
            return lista;
        }
        public void AgregarCarrito(Carrito carrito)
        {
            string selectQuery = "SELECT Cantidad FROM Carrito WHERE ProductoID = @ProductoID";
            SqlParameter[] selectParams = {
        new SqlParameter("@ProductoID", carrito.ProductoID)
    };
            DataTable result = database.Select(selectQuery, new Dictionary<string, object> { { "@ProductoID", carrito.ProductoID } });

            if (result.Rows.Count > 0)
            {
                int cantidadActual = Convert.ToInt32(result.Rows[0]["Cantidad"]);
                int nuevaCantidad = cantidadActual + carrito.Cantidad;

                string updateQuery = "UPDATE Carrito SET Cantidad = @Cantidad WHERE ProductoID = @ProductoID";
                SqlParameter[] updateParams = {
            new SqlParameter("@Cantidad", nuevaCantidad),
            new SqlParameter("@ProductoID", carrito.ProductoID)
        };
                database.ExecuteNonQuery(updateQuery, updateParams);
            }
            else
            {
                string insertQuery = @"INSERT INTO Carrito (ProductoID, NombreProducto, Precio, Cantidad)
                               VALUES (@ProductoID, @NombreProducto, @Precio, @Cantidad)";
                SqlParameter[] insertParams = {
            new SqlParameter("@ProductoID", carrito.ProductoID),
            new SqlParameter("@NombreProducto", carrito.NombreProducto),
            new SqlParameter("@Precio", carrito.Precio),
            new SqlParameter("@Cantidad", carrito.Cantidad)
        };
                database.ExecuteNonQuery(insertQuery, insertParams);
            }
        }
        public int ModificarCarrito(Carrito carrito)
        {
            string query = @"UPDATE Carrito SET Cantidad = @Cantidad WHERE ProductoID = @ProductoID";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@Cantidad", carrito.Cantidad),
        new SqlParameter("@ProductoID", carrito.ProductoID)
            };
            return database.ExecuteNonQuery(query, parameters);
        }
        public int EliminarCarrito(int id)
        {
            string query = "DELETE FROM Carrito WHERE ProductoID = @ProductoID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ProductoID", id)
            };
            return database.ExecuteNonQuery(query, parameters);
        }

        public void VaciarCarrito()
        {
            string query = "DELETE FROM Carrito";
            database.ExecuteNonQuery(query, null);
        }
    }
}
