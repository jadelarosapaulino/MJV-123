using System;
using System.Collections.Generic;
using System.Text;

namespace MJV.Service
{
    public abstract class EntityBase
    {
        public int ProductoID { get; set; }
        public string productoNombre { get; set; }
        public decimal precio_compra { get; set; }
        public decimal precio_venta { get; set; }
        public int marcaID { get; set; }
        public int categoriaID { get; set; }
        public int estadoID { get; set; }
        public string marca_nombre { get; set; }
        public string categoria_nombre { get; set; }
        public string estado { get; set; }
        public char activo { get; set; }
        public DateTime fecha_ingreso { get; set; }
        public DateTime ultima_actualizacion { get; set; }
    }
}
