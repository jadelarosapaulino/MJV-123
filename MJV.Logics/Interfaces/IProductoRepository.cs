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
        Task<IEnumerable<Producto>> TodosLosProductosAsyncTask();

        Task<Producto> ProductoAsyncTask(int productoID);

        Task<IEnumerable<Producto>> BuscarProductosAsyncTask(string textoBuscar);

        Task<Producto> SetProductoAsyncTask(Producto producto);

        Task<Producto> EliminarProductoAsyncTask(int prodctoID);
    }
}
