using Facturacion.Dominio;
using Facturacion.Dominio.Dto;
using Facturacion.Dominio.Entities;
using Facturacion.Infraestructura;
using Facturacion.Infraestructura.Dapper;
using System;
using System.Collections.Generic;
using System.Data;
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

        public static void Listar(string cadena)
        {
            //var clientes = new object();
            //var dt = new DataTable();

            //if (string.IsNullOrEmpty(cadena))
            //{

            //    clientes = ClientesQuery.GetClientes();

            //}
            //else
            //{
            //    clientes = ClientesQuery.GetClientesByZone(cadena);
            //}

            //dt.Load(clientes);
            //return dt;
        }
    }
}
