﻿using System;

namespace Facturacion.Dominio.Entities
{
    public class Zona
    {
        public Guid Id { get; set; }

        public string NombreZona { get; set; }

        public Guid ClienteId { get; set; }
    }
}
