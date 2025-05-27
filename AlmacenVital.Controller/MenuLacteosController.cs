using Almacen.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Almacen.Controller
{
   
    public class MenuLacteosController
    {
        private DataBase database = new DataBase();
        public DataTable ObtenerLacteos()
        { 
            string query = "SELECT ID, Nombre, Precio, Stock FROM Productos_Lacteos";
            return database.Select(query);
        }
    }
}
