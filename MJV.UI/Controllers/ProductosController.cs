using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace MJV.UI.Controllers
{
    using System.Net;

    using MJV.Service;
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
            return await this.productoService.GetAll();
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
            if (textoBuscar != null);

            return await this.productoService.BuscarProductos(textoBuscar);
        }

        [HttpPost]
        public IActionResult SetProducto([FromRoute]ProductoViewModel producto)
        {
            productoService.SetProducto(producto);

            return Ok();
        }

        // DELETE: api/Productos/d/1
        [HttpDelete]
        [Route("api/Productos/d/")]
        public async Task<IActionResult> BorrarProducto(int id)
        {
            return await this.productoService.EliminarProducto(id);
        }
    }
}
