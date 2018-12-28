using System.Threading.Tasks;
using MJV.Logic.Models;
using System.Collections.Generic;


namespace MJV.Logic.Interfaces
{     
    public interface IProductoRepository
    {
        Task<IEnumerable<Producto>> TodosLosProductosAsyncTask();

        Task<Producto> ProductoAsyncTask(int productoID);

        Task<IEnumerable<Producto>> BuscarProductosAsyncTask(string textoBuscar);

        Task<Producto> EliminarProductoAsyncTask(int prodctoID);
    }
}
