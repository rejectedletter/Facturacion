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
                CuentaClienteId = new CuentaClienteDto().CuentaClienteId,
                ProductoId = producto.ProductoId,
                Debe = producto.MontoTotalCancelar
            };

            var nuevoCliente = new Cliente()
            {
                ClienteId = cliente.ClienteId,
                NroCliente = cliente.NroCliente,
                Apellido = cliente.Apellido,
                Nombre = cliente.Nombre,
                Direccion = cliente.Direccion,
                CuentaClienteId = nuevaCuentaCliente.CuentaClienteId,
                ZonaId = cliente.Zona.ZonaId,
                ProductoId = producto.ProductoId
            };

            var productoAsociado = new Producto()
            {
                ProductoId = producto.ProductoId,
                MontoTotalCancelar = producto.MontoTotalCancelar
            };
        }

        public static void Modificar(Cliente cliente)
        {

        }

        public static void Eliminar(Guid id)
        {

        }

        public static DataTable Listar(string cadena)
        {
            if (string.IsNullOrEmpty(cadena))
            {
              return ClientesQuery.GetClientes().Rows.Cast<DataRow>()
                    .Where(x=>x.Field<DataRow>("NombreZona").ToString() == cadena).CopyToDataTable();
            }

            return ClientesQuery.GetClientes();
        }
    }
}
