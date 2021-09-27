
namespace Facturacion.Reportes
{
    partial class FacturaComprobante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rvrFacturacion = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvrFacturacion
            // 
            this.rvrFacturacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvrFacturacion.LocalReport.ReportEmbeddedResource = "Facturacion.Reportes.JoelReporte.rdlc";
            this.rvrFacturacion.Location = new System.Drawing.Point(0, 0);
            this.rvrFacturacion.Name = "rvrFacturacion";
            this.rvrFacturacion.ServerReport.BearerToken = null;
            this.rvrFacturacion.Size = new System.Drawing.Size(1049, 536);
            this.rvrFacturacion.TabIndex = 0;
            // 
            // FacturaComprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 536);
            this.Controls.Add(this.rvrFacturacion);
            this.Name = "FacturaComprobante";
            this.Text = "FacturaComprobante";
            this.Load += new System.EventHandler(this.FacturaComprobante_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvrFacturacion;
    }
}