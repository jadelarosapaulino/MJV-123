using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MJV.Logics.Interfaces;
using MJV.Logics.Models;

namespace MJV.Logics.Repositorios
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly MJVContext _context;

        public ProductoRepository(MJVContext context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<Producto>> TodosLosProductosAsyncTask()
        {
            try
            {
                return await this._context.Producto.FromSql("Proc_Producto_Consulta null").ToListAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }

        public async Task<Producto> SetProductoAsyncTask(Producto producto)
        {
            _context.Producto.FromSql("Proc_Producto_Inserta {0}", producto);
            _context.SaveChangesAsync();

            return null;
        }

        public async Task<Producto> ProductoAsyncTask(int productoID)
        {
            return await this._context.Producto.AsNoTracking().FromSql("Proc_Producto_Consulta {0}", productoID)
                       .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Producto>> BuscarProductosAsyncTask(string textoBuscar)
        {
            return await _context.Producto.AsNoTracking().FromSql("Proc_Producto_Consulta {0}", textoBuscar).ToListAsync();
        }

        public async Task<Producto> EliminarProductoAsyncTask(int productoID)
        {
            Producto producto = await ProductoAsyncTask(productoID);

            if (producto != null)
            {
                _context.Producto.Remove(producto);
                await _context.SaveChangesAsync();
            }

            return producto;
        }
    }
}
