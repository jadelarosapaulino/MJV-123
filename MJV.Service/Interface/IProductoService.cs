using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MJV.Service.Interface
{
    using MJV.Logics.Models;
    using MJV.Service.ViewModel;

    public interface IProductoService
    {
        Task<IActionResult> GetAll();

        Task<IActionResult> ProductoByID(int productoID);

        void SetProducto(ProductoViewModel producto);

        Task<IActionResult> BuscarProductos(string textoBuscar);

        Task<IActionResult> EliminarProducto(int prodctoID);
    }
}