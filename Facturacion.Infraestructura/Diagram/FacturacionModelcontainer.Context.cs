﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Facturacion.Infraestructura.Diagram
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Facturacion_Gimnasio_JuanEntities : DbContext
    {
        public Facturacion_Gimnasio_JuanEntities()
            : base("name=Facturacion_Gimnasio_JuanEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<CuentaCliente> CuentaClientes { get; set; }
        public virtual DbSet<Factura> Facturas { get; set; }
        public virtual DbSet<Movimiento> Movimientos { get; set; }
        public virtual DbSet<Plan> Plans { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<RelacionProductosPlane> RelacionProductosPlanes { get; set; }
        public virtual DbSet<Zona> Zonas { get; set; }
    }
}
