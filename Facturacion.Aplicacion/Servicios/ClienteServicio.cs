using AutoMapper;
using Facturacion.Dominio;
using Facturacion.Dominio.Dto;
using Facturacion.Dominio.Entities;
using Facturacion.Infraestructura.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Facturacion.Aplicacion.Servicios
{
    public class ClienteServicio
    {
        private readonly IMapper _mapper;
        public ClienteServicio()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ClienteDto, Cliente>();
                cfg.CreateMap<ProductoDto, Producto>();
                cfg.CreateMap<ProductosPlanesDto, ProductosPlanes>();
                cfg.CreateMap<CuentaClienteDto, CuentaCliente>();

            });
            

            _mapper = new Mapper(configuration);
        }
        public bool Agregar(ClienteDto cliente, ProductoDto producto = null)
        {
            try
            {
                ClientesQuery.Addclientes(_mapper.Map<Cliente>(cliente));

                if (producto != null)
                {
                    var cuentaCliente = new CuentaCliente()
                    {
                        CuentaClienteId = new CuentaClienteDto().CuentaClienteId,
                        Debe = producto.MontoTotalCancelar,
                        ProductoId = producto.ProductoId
                    };

                    var relacionProdPlan = new ProductosPlanesDto()
                    {
                        Producto = producto,
                        Plan = producto.Planes.First(),
                        FechaInicioPlanPago = DateTime.Now,
                        Movimientos = cliente.CuentaCliente.Movimientos
                    };

                    ProductosQuery.AddProducto(_mapper.Map<Producto>(producto));
                    ProductosPlanesQuery.AddProductosPlanes(_mapper.Map<ProductosPlanes>(relacionProdPlan));
                    CuentaClienteQuery.AddCuentaCliente(_mapper.Map<CuentaCliente>(cuentaCliente));

                    
                }

                return true;
            }
            catch(Exception e)
            {
                var msg = e.Message;
                throw new Exception("No fue posible agregar cliente");
            }
        }

        public  bool Modificar(ClienteDto cliente)
        {
            try
            {
                ClientesQuery.UpdateClientes(_mapper.Map<Cliente>(cliente));
                return true;
            }
            catch
            {

                throw new Exception("No fue posible modificar al cliente");
            }
        }

        public static bool Eliminar(Guid id)
        {
            try
            {
                ClientesQuery.DeleteCliente(id);
                return true;
            }
            catch
            {

                throw new Exception("No fue posible eliminar al cliente");
            }
        }

        public static List<dynamic> Listar(string cadena)
        {
            if (!string.IsNullOrEmpty(cadena))
            {
                return ClientesQuery.GetClientes()
                    .Where(x => x.zona.NombreZona == cadena).ToList();
            }

           return ClientesQuery.GetClientes();

            
        }
    }
}
