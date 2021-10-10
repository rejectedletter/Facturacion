﻿using Facturacion.Aplicacion.Servicios;
using Facturacion.Infraestructura.Diagram;
using Facturacion.Presentacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Facturacion
{
    public partial class ABMProducto : ABMBase
    {
        public Producto Producto = new Producto();

        private readonly PlanServicio _planServicio = new PlanServicio();

        private  List<Plan> Planes => _planServicio.ListarPlanes();
        public ABMProducto(TipoOperacion tipoOperacion, Guid? id)
        {
            _tipoOperacion = tipoOperacion;
           

            InitializeComponent();

            btnAceptar.BringToFront();

            CargarTitulo(_tipoOperacion);
            
            
            

        }

        private void CargarComboPlanes()
        {
            if (Planes.Count < 1 || Planes == null)
            {
                MessageBox.Show("Cargar Planes", "Sin Planes Cargados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }

            cmbPlanes.DataSource = Planes.Select(x=>x.NombrePlan).ToList();
        }



        //private void CargarInformacionProducto(Guid id)
        //{
        //    var objetoCargar = Aplicacion.ProductoServicio..BuscarPorId(id);

        //    txtDescripcion.Text = objetoCargar.Descripcion;
        //    txtPrecio.Text = objetoCargar.PrecioUnitario.ToString();
        //}

        protected override void CargarTitulo(TipoOperacion tp)
        {
            //if (_tipoOperacion == TipoOperacion.Modificacion)
            //{
            //    CargarInformacionProducto(clienteId);
            //    lblTitulo.Text = "Modificar Producto";

            //}

            if (_tipoOperacion == TipoOperacion.Alta)
            {

                lblTitulo.Text = "Nuevo Producto";
            }
        }

        private void ABM_Load(object sender, EventArgs e)
        {
            CargarComboPlanes();
        }

        

        protected override void RealizarOperacion()
        {
            if (_tipoOperacion == TipoOperacion.Alta)
            {


                //Producto.Descripcion = txtDescripcion.Text;
                    Producto.MontoTotalCancelar = decimal.Parse(txtPrecio.Text);
                    Producto.RelacionProductosPlane.Plane= Planes.First(x => x.NombrePlan == cmbPlanes.SelectedItem.ToString());

                //var prod = new ProductosPlanesDto()
                //{
                //    Producto = Producto,
                //    Plan = Producto.Planes.First(),
                //    FechaInicioPlanPago = DateTime.Now,

                //};

                var msg = MessageBox.Show("Se agregó correctamente", caption: "Producto Agregado");
                this.Close();
            }
        }

        

        
    }
}
