using Facturacion.Aplicacion.Servicios;
using System;
using System.Windows.Forms;

namespace Facturacion.Presentacion.ABMS
{
    public partial class ABMZona : ABMBase
    {
        private readonly ZonaServicio _zonaServicio = new ZonaServicio();
        private readonly Guid? _id;
        public ABMZona(TipoOperacion tipoOperacion, Guid? id = null)
        {
            _tipoOperacion = tipoOperacion;
            _id = id;

            InitializeComponent();
            CargarTitulo(tipoOperacion);
        }

        private void ABMZona_Load(object sender, EventArgs e)
        {

        }

        protected override void CargarTitulo(TipoOperacion tp)
        {
            if (tp == TipoOperacion.Alta)
            {
                lblTitulo.Text = "Nueva Zona";
            }
            else
            {
                lblTitulo.Text = "Modificar Zona";
            }
        }

        protected override void RealizarOperacion()
        {
            if (_tipoOperacion == TipoOperacion.Alta)
            {
                var result = _zonaServicio.AgregarZona(new Dominio.Dto.ZonaDto() { NombreZona = txtNombreZona.Text });

                if (result)
                {
                    MessageBox.Show("Se agregó zona correctamente", "Nueva Zona", MessageBoxButtons.OK);
                    this.Close();
                }
            }
            else
            {
                var modificacion = _zonaServicio.ModificarZona(new Dominio.Dto.ZonaDto() {ZonaId= (Guid)_id, NombreZona= txtNombreZona.Text });
                if (modificacion)
                {
                    MessageBox.Show("Se modificó la zona correctamente");
                    this.Close();
                }
            }
            
            
        }
    }
}
