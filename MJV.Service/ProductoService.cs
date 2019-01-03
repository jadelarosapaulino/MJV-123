using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MJV.Logics.Interfaces;
using MJV.Logics.Models;
using MJV.Logics.Repositorios;
using MJV.Service.Interface;
using MJV.Service.ViewModel;

namespace MJV.Service
{
    public class ProductoService : IProductoService
    {
        private readonly IProductoRepository _productoRepository;

        public ProductoService(IProductoRepository productsRepository)
        {
            _productoRepository = productsRepository;
        }
  
        // Traer todos los productos
        public async Task<IActionResult> GetAll()
        {
            try
            {
                IEnumerable<Producto> productos = await _productoRepository.GetAll();

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

        // Crear nuevo producto
        public void SetProducto(ProductoViewModel prod)
        {
            try
            {
                var producto = (new Producto()
                {
                    productoID = prod.productoID,
                    productoNombre = prod.productoNombre,
                    precio_compra = prod.precio_compra,
                    precio_venta = prod.precio_venta,
                    marcaID = prod.marcaID,
                    categoriaID = prod.categoriaID,
                    estadoID = prod.estadoID
                });


                _productoRepository.SetProducto(producto);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        // Buscar un producto especifico
        public async Task<IActionResult> ProductoByID(int productoID)
        {
            try
            {
                Producto productos = await _productoRepository.ProductoByID(productoID);

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
        public async Task<IActionResult> BuscarProductos(string textoBuscar)
        {
            try
            {
                IEnumerable<Producto> productos = await _productoRepository.BuscarProductos(textoBuscar);

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
        public async Task<IActionResult> EliminarProducto(int productoID)
        {
            try
            {
                Producto productos = await _productoRepository.EliminarProducto(productoID);

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
