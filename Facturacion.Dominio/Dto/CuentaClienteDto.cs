﻿using System;
using System.Collections.Generic;

namespace Facturacion.Dominio.Dto
{
    public class CuentaClienteDto
    {
        public Guid Id { get; set; }

        public decimal Debe { get; set; }

        public decimal Haber { get; set; }

        public ClienteDto Cliente { get; set; }

        public ICollection<MovimientoDto> Movimientos { get; set; }
    }
}