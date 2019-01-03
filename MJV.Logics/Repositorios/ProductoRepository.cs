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

        public async Task<IEnumerable<Producto>> GetAll()
        {
            try
            {
                return await _context.Producto.AsNoTracking().FromSql("Proc_Producto_Consulta null").ToListAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<Producto> SetProducto(Producto producto)
        {
            var prod = await ProductoByID(producto.productoID.GetValueOrDefault());
            try
            {
                _context.Producto.AsNoTracking().FromSql("Proc_Producto_Inserta {0}", producto);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw e;
            }

            return prod;
        }

        public async Task<Producto> ProductoByID(int productoID)
        {
            return await this._context.Producto.AsNoTracking().FromSql("Proc_Producto_Consulta {0}", productoID)
                       .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Producto>> BuscarProductos(string textoBuscar)
        {
            return await _context.Producto.AsNoTracking().FromSql("Proc_Producto_Consulta {0}", textoBuscar).ToListAsync();
        }

        public async Task<Producto> EliminarProducto(int productoID)
        {
            Producto producto = await ProductoByID(productoID);

            if (producto != null)
            {
                _context.Producto.Remove(producto);
                await _context.SaveChangesAsync();
            }

            return producto;
        }
    }
}
