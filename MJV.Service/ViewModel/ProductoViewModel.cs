using System;
using System.Collections.Generic;
using System.Text;

namespace MJV.Service.ViewModel
{
    public class ProductoViewModel
    {
        public int productoID { get; set; }
        public string productoNombre { get; set; }
        public decimal precio_compra { get; set; }
        public decimal precio_venta { get; set; }
        public string marca_nombre { get; set; }
        public string categoria_nombre { get; set; }
        public string estado { get; set; }
        public char activo { get; set; }
        public DateTime ultima_actualizacion { get; set; }
    }
}
