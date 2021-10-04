using AutoMapper;
using Facturacion.Dominio;
using Facturacion.Dominio.Dto;
using Facturacion.Dominio.Entities;
using Facturacion.Infraestructura;
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
                cfg.CreateMap<Cliente, ClienteDto>();

                cfg.CreateMap<ClienteDto, Cliente>()
                .ForMember(x=> x.ProductoId, o => {
                    o.MapFrom(s => s.Productos.First().ProductoId);
                })
                .ForMember(x => x.CuentaClienteId, o => {
                    o.MapFrom(s => s.CuentaCliente.CuentaClienteId);
                })
                .ForMember(x => x.ZonaId, o => {
                    o.MapFrom(s => s.Zona.ZonaId);
                });
                cfg.CreateMap<ProductoDto, Producto>();
                cfg.CreateMap<ProductosPlanesDto, ProductosPlanes>()
                .ForMember(x => x.PlanId, o => {
                    o.MapFrom(s => s.Plan.PlanId);
                });
                cfg.CreateMap<CuentaClienteDto, CuentaCliente>();

            });
            

            _mapper = new Mapper(configuration);
        }
        public bool Agregar(ClienteDto cliente, ProductoDto producto = null)
        {
            try
            {
                if (producto != null)
                {
                    

                    var cuentaClienteDto = new CuentaClienteDto()
                    {
                        Debe = producto.MontoTotalCancelar,
                        Producto = producto,
                        Movimientos = new List<MovimientoDto>()
                    };

                    var relacionProdPlan = new ProductosPlanesDto()
                    {
                        Producto = producto,
                        Plan = producto.Planes.First(),
                        FechaInicioPlanPago = DateTime.Now,
                        Movimientos = cuentaClienteDto.Movimientos
                    };

                    cliente.CuentaCliente = cuentaClienteDto; 
                    cliente.Productos = new List<ProductoDto>(){ producto};
                    cliente.ProductosPlanes = new List<ProductosPlanesDto>()
                    { relacionProdPlan };

                    try
                    {
                        ClientesQuery.ExecuteTransactCliente(_mapper.Map<Cliente>(cliente),
                            _mapper.Map<Producto>(producto),
                            _mapper.Map<ProductosPlanes>(relacionProdPlan),
                            _mapper.Map<CuentaCliente>(cuentaClienteDto)
                            );
                        //ClientesQuery.Addclientes(_mapper.Map<Cliente>(cliente));
                        //ProductosQuery.AddProducto(_mapper.Map<Producto>(producto));
                        //ProductosPlanesQuery.AddProductosPlanes(_mapper.Map<ProductosPlanes>(relacionProdPlan));
                        //CuentaClienteQuery.AddCuentaCliente(_mapper.Map<CuentaCliente>(cuentaClienteDto));

                    }
                    catch (Exception e)
                    {

                        
                        throw e;
                    }
                    
                    //GC.SuppressFinalize(conn);
                    

                    return true;
                }

               // ClientesQuery.Addclientes(_mapper.Map<Cliente>(cliente));

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

        public List<ClientesResult> Listar(string cadena)
        {
            //if (!string.IsNullOrEmpty(cadena))
            //{
            //    return ClientesQuery.GetClientes()
            //        .Where(x => x.Zona.NombreZona == cadena).ToList();
            //}

            return ClientesQuery.GetClientes();
        }

        public ClienteDto GetCliente(Guid id)
        {
            return _mapper.Map<ClienteDto> (ClientesQuery.GetClientesById(id));
        }
    }
}
