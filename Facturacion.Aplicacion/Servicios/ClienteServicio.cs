using Facturacion.Dominio;
using Facturacion.Dominio.Dto;
using Facturacion.Dominio.Entities;
using Facturacion.Infraestructura;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Facturacion.Aplicacion.Servicios
{
    public class ClienteServicio
    {
        
        public ClienteServicio()
        {
            
        }
        public static void Agregar(ClienteDto cliente, ProductoDto producto)
        {
            var nuevaCuentaCliente = new CuentaCliente()
            {
                Id = new CuentaClienteDto().Id,
                ProductoId = producto.Id,
                Debe = producto.MontoTotalCancelar
            };

            var nuevoCliente = new Cliente()
            {
                Id = cliente.Id,
                NroCliente = cliente.NroCliente,
                CodigoCliente = cliente.CodigoCliente,
                Apellido = cliente.Apellido,
                Nombre = cliente.Nombre,
                Direccion = cliente.Direccion,
                CuentaClienteId = nuevaCuentaCliente.Id,
                ZonaId = cliente.Zona.Id,
                ProductoId = producto.Id
            };

            var productoAsociado = new Producto()
            {
                Id = producto.Id,
                MontoTotalCancelar = producto.MontoTotalCancelar,
                ProductosPlanesId = producto.Plan.First().Id
            };
        }

        public static void Modificar(Cliente cliente)
        {

        }

        public static void Eliminar(Guid id)
        {

        }

        public static List<ClienteDto> Listar(string cadena)
        {


            return new List<ClienteDto>()
            {
                new Dominio.Dto.ClienteDto()
                {
                    CodigoCliente = "7930/1",
                    ApellidoYNombre = "Medina, Andrés Fabian",
                    Apellido="Medina",
                    Nombre="Andrés Fabián",
                    Direccion = "Juan B Justo 3024 - B° El Colmenar - San Miguel de Tucumán",
                    Productos = new List<ProductoDto>()
                        {
                            new ProductoDto()
                            {
                                MontoTotalCancelar=26770.00M
                            }
                        },
                    CuentaCliente = new CuentaClienteDto()
                    {
                    Debe = 15610.00M,
                    Haber = 11160.00M,
                    Movimientos = new List<MovimientoDto>()
                            {
                                new MovimientoDto()
                                {
                                    FechaMovimiento = new DateTime(2021, 04, 29)
                                }
                            }
                    }
            }
        };
            
        }
    }
}
