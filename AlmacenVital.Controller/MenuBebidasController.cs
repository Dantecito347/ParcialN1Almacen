using Almacen.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Almacen.Controller
{
    public class MenuBebidasController
    {
        private DataBase database = new DataBase();
        public DataTable ObtenerBebidas()
        { 
            string query = "SELECT ID, Nombre, Precio, Stock FROM Productos_Bebidas";
            return database.Select(query);
        }
    }
}
