﻿using System;

namespace Facturacion.Dominio.Entities
{
    public class ProductosPlanes
    {
        public Guid ProductosPlanesId { get; set; }

        public Guid ProductoId { get; set; }

        public Guid PlanId { get; set; }

        public DateTime FechaInicioPlanPago { get; set; }

        public decimal Alicuota { get; set; }

        public bool Cancelado { get; set; }
    }
}
