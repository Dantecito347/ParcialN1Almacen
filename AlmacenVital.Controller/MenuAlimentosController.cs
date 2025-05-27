using Almacen.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace Almacen.Controller
{
    public class MenuAlimentosController
    {
        private DataBase database = new DataBase();

        public DataTable ObtenerAlimentos()
        {
            string query = "SELECT ProductosID, Nombre, Precio, Stock FROM Productos_Alimentos";
            return database.Select(query);

        }
    }
}
