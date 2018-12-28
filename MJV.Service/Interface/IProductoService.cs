using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MJV.Service.Interface
{                              
    public interface IProductoService
    {
        Task<IActionResult> TodosLosProductosAsyncTask();

        Task<IActionResult> ProductoAsyncTask(int productoID);

        Task<IActionResult> BuscarProductosAsyncTaskAsync(string textoBuscar);

        Task<IActionResult> EliminarProductoAsyncTask(int prodctoID);
    }
}
