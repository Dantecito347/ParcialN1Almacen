using System;
using System.Collections.Generic;
using System.Text;

namespace Almacen.Model
{
    public class Producto
    {
        public int ProductosID { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public int Stock { get; set; }
    }
}
