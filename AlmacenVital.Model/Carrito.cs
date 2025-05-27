using System;
using System.Collections.Generic;
using System.Text;

namespace Almacen.Model
{
    public class Carrito
    {
        public int ID { get; set; }
        public int ProductoID { get; set; }
        public string NombreProducto { get; set; }
        public int Precio { get; set; }
        public int Cantidad { get; set; }
    }
}
