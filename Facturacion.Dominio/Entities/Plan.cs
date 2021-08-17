﻿using System;

namespace Facturacion.Dominio.Entities
{
    public class Plan
    {
        public Guid Id { get; set; }

        public int CaantidadCuotas { get; set; }

        public decimal Porcentaje { get; set; }

        public bool Cancelado { get; set; }
    }
}
