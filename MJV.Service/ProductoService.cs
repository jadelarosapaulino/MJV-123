namespace MJV.Service
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using MJV.Logic.Interfaces;
    using MJV.Logic.Models;
    using MJV.Service.Interface;
    using MJV.Service.ViewModel;

    public class ProductoService : IProductoService
    {
        private readonly IProductoRepository _productoRepository;

        public ProductoService(IProductoRepository productsRepository)
        {
            _productoRepository = productsRepository;
        }

        // Traer todos los productos
        public async Task<IActionResult> TodosLosProductosAsyncTask()
        {
            try
            {
                IEnumerable<Producto> productos = await _productoRepository.TodosLosProductosAsyncTask();

                if (productos != null)
                {
                    return new OkObjectResult(productos.Select(p => new ProductoViewModel()
                    {
                        productoID = p.productoID,
                        productoNombre = p.productoNombre,
                        precio_compra = p.precio_compra,
                        precio_venta = p.precio_venta,
                        marca_nombre = p.marca_nombre,
                        categoria_nombre = p.categoria_nombre,
                        estado = p.estado,
                        activo = p.activo,
                        ultima_actualizacion = p.ultima_actualizacion
                    }));
                }
                else
                {
                    return new NotFoundResult();
                }
            }
            catch
            {
                return new ConflictResult();
            }
        }

        // Buscar un producto especifico
        public async Task<IActionResult> ProductoAsyncTask(int productoID)
        {
            try
            {
                Producto productos = await _productoRepository.ProductoAsyncTask(productoID);

                if (productos != null)
                {
                    return new OkObjectResult(new ProductoViewModel()
                    {
                        productoID = productos.productoID,
                        productoNombre = productos.productoNombre,
                        precio_compra = productos.precio_compra,
                        precio_venta = productos.precio_venta,
                        marca_nombre = productos.marca_nombre,
                        categoria_nombre = productos.categoria_nombre,
                        estado = productos.estado,
                        activo = productos.activo,
                        ultima_actualizacion = productos.ultima_actualizacion
                    });
                }
                else
                {
                    return new NotFoundResult();
                }
            }
            catch
            {
                return new ConflictResult();
            }
        }

        // Buscar por criterio de busqueda
        public async Task<IActionResult> BuscarProductosAsyncTaskAsync(string textoBuscar)
        {
            try
            {
                IEnumerable<Producto> productos = await _productoRepository.BuscarProductosAsyncTask(textoBuscar);

                if (productos != null)
                {
                    //if (productos.Count() == 1)
                    //{

                    //}

                    return new OkObjectResult(
                        productos.Select(
                            p => new ProductoViewModel()
                            {
                                productoID = p.productoID,
                                productoNombre = p.productoNombre,
                                precio_compra = p.precio_compra,
                                precio_venta = p.precio_venta,
                                marca_nombre = p.marca_nombre,
                                categoria_nombre = p.categoria_nombre,
                                estado = p.estado,
                                activo = p.activo,
                                ultima_actualizacion = p.ultima_actualizacion
                            }));
                }
                else
                {
                    return new NotFoundResult();
                }
            }
            catch
            {
                return new ConflictResult();
            }
        }

        // Eliminar Producto por productoID
        public async Task<IActionResult> EliminarProductoAsyncTask(int productoID)
        {
            try
            {
                Producto productos = await _productoRepository.EliminarProductoAsyncTask(productoID);

                if (productos != null)
                {
                    return new OkObjectResult(new ProductoViewModel()
                    {
                        productoID = productos.productoID,
                        productoNombre = productos.productoNombre,
                        precio_compra = productos.precio_compra,
                        precio_venta = productos.precio_venta,
                        marca_nombre = productos.marca_nombre,
                        categoria_nombre = productos.categoria_nombre,
                        estado = productos.estado,
                        activo = productos.activo,
                        ultima_actualizacion = productos.ultima_actualizacion
                    });
                }
                else
                {
                    return new NotFoundResult();
                }
            }
            catch
            {
                return new ConflictResult();
            }
        }
    }
}
