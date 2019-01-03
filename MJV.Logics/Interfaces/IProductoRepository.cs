using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MJV.Logics.Models;

namespace MJV.Logics.Interfaces
{
    public interface IProductoRepository
    {
        Task<IEnumerable<Producto>> GetAll();

        Task<Producto> ProductoByID(int productoID);

        Task<IEnumerable<Producto>> BuscarProductos(string textoBuscar);

        Task<Producto> SetProducto(Producto producto);

        Task<Producto> EliminarProducto(int prodctoID);
    }
}
