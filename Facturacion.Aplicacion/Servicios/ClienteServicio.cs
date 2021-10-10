using AutoMapper;

using Facturacion.Dominio.Dto;

using Facturacion.Infraestructura;
using Facturacion.Infraestructura.Dapper;
using Facturacion.Infraestructura.Diagram;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Facturacion.Aplicacion.Servicios
{
    public class ClienteServicio
    {
       // private readonly IMapper _mapper;
        public ClienteServicio()
        {
            //var configuration = new MapperConfiguration(cfg =>
            //{
            //    cfg.CreateMap<Cliente, ClienteDto>();

            //    cfg.CreateMap<ClienteDto, Cliente>()
            //    .ForMember(x=> x.ProductoId, o => {
            //        o.MapFrom(s => s.Productos.First().ProductoId);
            //    })
            //    .ForMember(x => x.CuentaClienteId, o => {
            //        o.MapFrom(s => s.CuentaCliente.CuentaClienteId);
            //    })
            //    .ForMember(x => x.ZonaId, o => {
            //        o.MapFrom(s => s.Zona.ZonaId);
            //    });
            //    cfg.CreateMap<ProductoDto, Producto>();
            //    cfg.CreateMap<ProductosPlanesDto, ProductosPlanes>()
            //    .ForMember(x => x.PlanId, o => {
            //        o.MapFrom(s => s.Plan.PlanId);
            //    });
            //    cfg.CreateMap<CuentaClienteDto, CuentaCliente>();

            //});


            //_mapper = new Mapper(configuration);

            
        }
        public bool Agregar(ClienteDto cliente, Producto producto = null)
        {
            Cliente clienteAgregar = new Cliente()
            {
                ClienteId = cliente.ClienteId,
                Apellido = cliente.Apellido,
                DNI = cliente.Dni,
                FechaNacimiento = cliente.FechaNacimiento,
                DomicilioParticular = cliente.DomicilioParticular,
                DomicilioComercial = cliente.DomicilioComercial,
                NroCelular = cliente.NroCelular,
                TelefonoFijo = cliente.TelefonoFijo,
                Rubro = cliente.Rubro,
                ZonaId = cliente.Zona.ZonaId,
                
            };

            CuentaCliente nuevaCuentacliente = new CuentaCliente()
            {
                Cliente = clienteAgregar,
                ClienteId = clienteAgregar.ClienteId,
                Debe = producto.MontoTotalCancelar
            };



            using (var db = new Facturacion_Gimnasio_JuanEntities())
            {

                using (var trx = db.Database.BeginTransaction())
                {


                    try
                    {
                        db.Clientes.Add(clienteAgregar);
                        db.CuentaClientes.Add(nuevaCuentacliente);
                        db.Productos.Add(producto);

                        db.SaveChanges();

                        trx.Commit();

                        return true;
                    }
                    catch (Exception)
                    {
                        trx.Rollback();
                        throw new Exception("No se pudo agregar el cliente");
                    }
                }
                

            }
            
        }

        public  bool Modificar(ClienteDto cliente)
        {
            try
            {
                using (var db = new Facturacion_Gimnasio_JuanEntities())
                {
                    var clienteModificar = db.Clientes.SingleOrDefault(c => c.ClienteId == cliente.ClienteId);
                    clienteModificar.Apellido = cliente.Apellido;
                    clienteModificar.DNI = cliente.Dni;
                    clienteModificar.FechaNacimiento = cliente.FechaNacimiento;
                    clienteModificar.DomicilioParticular = cliente.DomicilioParticular;
                    clienteModificar.DomicilioComercial = cliente.DomicilioComercial;
                    clienteModificar.NroCelular = cliente.NroCelular;
                    clienteModificar.TelefonoFijo = cliente.TelefonoFijo;
                    clienteModificar.Rubro = cliente.Rubro;
                    clienteModificar.ZonaId = cliente.Zona.ZonaId;
                    
                }
                return true;
            }
            catch
            {

                throw new Exception("No fue posible modificar al cliente");
            }
        }

        

        public List<ClienteDto> Listar(string cadena)
        {
            //if (!string.IsNullOrEmpty(cadena))
            //{
            //    return ClientesQuery.GetClientes()
            //        .Where(x => x.Zona.NombreZona == cadena).ToList();
            //}

            try
            {
                using (var db = new Facturacion_Gimnasio_JuanEntities())
                {
                    var query = from cli in db.Clientes
                                join z in db.Zonas on cli.ZonaId equals z.ZonaId
                                join cc in db.CuentaClientes on cli.CuentaClientes.FirstOrDefault().CuentaClienteId equals cc.CuentaClienteId
                                join prod in db.Productos on cc.RelacionProductosPlanes.FirstOrDefault().Productos.FirstOrDefault().ProductoId equals prod.ProductoId
                                join pp in db.RelacionProductosPlanes on prod.RelacionProductosPlane.ProductosPlanesId equals pp.ProductosPlanesId
                                select new ClienteDto
                                {
                                    ClienteId = cli.ClienteId,
                                    NroCliente = cli.NroCliente,
                                    Apellido = cli.Apellido,
                                    Nombre = cli.Nombre,
                                    Dni=cli.DNI,
                                    FechaNacimiento = cli.FechaNacimiento,
                                    NroCelular = cli.NroCelular,
                                    TelefonoFijo = cli.TelefonoFijo,
                                    Rubro = cli.Rubro,
                                    CuentasCliente = cli.CuentaClientes,
                                    Zona = z,
                                    
                                };
                    return query.Where(x=>x.Zona.NombreZona==cadena).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Cliente GetCliente(Guid id)
        {
            using (var db = new Facturacion_Gimnasio_JuanEntities())
            {
                return db.Clientes.SingleOrDefault(c => c.ClienteId == id);
            }
        }
    }
}
