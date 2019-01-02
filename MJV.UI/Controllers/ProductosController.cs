using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MJV.UI.Controllers
{
    using MJV.Service.Interface;
    using MJV.Service.ViewModel;

    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly IProductoService productoService;

        public ProductosController(IProductoService _productoService)
        {
            productoService = _productoService;
        }

        // GET: api/Productos
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return await this.productoService.TodosLosProductosAsyncTask();
        }

        //// GET: api/Productos/5
        //[HttpGet("{id}", Name = "Get")]
        //public async Task<IActionResult> Get(int id)
        //{
        //    return await this.productoService.ProductoAsyncTask(id);
        //}

        // GET: api/Productos/textoBuscar
        [HttpGet("{textoBuscar}", Name = "Get")]
        public async Task<IActionResult> BuscarProductos(string textoBuscar)
        {
            if (textoBuscar != null) ;

            return await this.productoService.BuscarProductosAsyncTaskAsync(textoBuscar);
        }

        [HttpPost]
        public async Task<IActionResult> SetProducto(ProductoViewModel producto)
        {
            return await this.productoService.SetProductoAsyncTask(producto);
        }

        // DELETE: api/Productos/d/1
        [HttpDelete]
        public async Task<IActionResult> BorrarProducto(int id)
        {
            return await this.productoService.EliminarProductoAsyncTask(id);
        }
    }
}
