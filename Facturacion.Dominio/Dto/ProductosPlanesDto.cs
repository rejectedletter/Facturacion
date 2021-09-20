using System;
using System.Collections.Generic;

namespace Facturacion.Dominio.Dto
{
    public class ProductosPlanesDto
    {
        public Guid ProductosPlanesId { get; set; } = Guid.NewGuid();

        public ProductoDto Producto { get; set; }
       

        public PlanDto Plan { get; set; }

        public DateTime FechaInicioPlanPago { get; set; }

        public decimal Alicuota => Producto.MontoTotalCancelar / Plan.CantidadCuotas;

        public DateTime FechaCancelacion => FechaInicioPlanPago.AddDays(Plan.CantidadCuotas * 7);

        public ICollection<MovimientoDto> Movimientos { get; set; }

        public bool Atrasado => Movimientos.Count < Plan.CantidadCuotas ? true : false;

        //falta el atraso
        public bool Cancelado { get; set; } = false;


    }
}
