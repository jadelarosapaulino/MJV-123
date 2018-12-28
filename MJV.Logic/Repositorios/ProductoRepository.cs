using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using MJV.Logic.Contexts;
using MJV.Logic.Interfaces;
using MJV.Logic.Models;

namespace MJV.Logic.Repositorios
{

    public class ProductoRepository : IProductoRepository
    {
        private readonly MainContext _context;

        public ProductoRepository(MainContext context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<Producto>> TodosLosProductosAsyncTask()
        {
            return await this._context.Productos.AsNoTracking().ToListAsync();
        }

        public async Task<Producto> ProductoAsyncTask(int productoID)
        {
            return await this._context.Productos.AsNoTracking().Where(p => p.productoID == productoID)
                       .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Producto>> BuscarProductosAsyncTask(string textoBuscar)
        {
            return await _context.Productos.AsNoTracking().FromSql("[dbo].Proc_Producto_Consulta @textoBuscar = {0}", textoBuscar).ToListAsync();
        }

        public async Task<Producto> EliminarProductoAsyncTask(int productoID)
        {
            Producto producto = await ProductoAsyncTask(productoID);

            if (producto != null)
            {
                _context.Productos.Remove(producto);
                await _context.SaveChangesAsync();
            }

            return producto;
        }
    }
}
