﻿using Facturacion.Dominio.Dto;
using Facturacion.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Aplicacion.Mappers
{
    public static class CustomMapperCliente
    {
        public static Cliente ClienteDtoToCliente(ClienteDto cliente)
        {
            return new Cliente()
            {
                Id = cliente.Id,
                NroCliente = cliente.NroCliente,
                CodigoCliente = cliente.CodigoCliente,
                Apellido = cliente.Apellido,
                Nombre = cliente.Nombre,
                Direccion = cliente.Direccion,
                CuentaClienteId = cliente.CuentaCliente.Id,
                ZonaId = cliente.Zona.Id,
                ProductoId = cliente.Productos.First().Id
            };
        }
    }
}