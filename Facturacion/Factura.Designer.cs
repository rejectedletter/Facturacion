
namespace Facturacion
{
    partial class Factura
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
            this.lblCNro = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblNroCliente = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dTPFechaPago = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCNro
            // 
            this.lblCNro.AutoSize = true;
            this.lblCNro.Location = new System.Drawing.Point(282, 72);
            this.lblCNro.Name = "lblCNro";
            this.lblCNro.Size = new System.Drawing.Size(62, 13);
            this.lblCNro.TabIndex = 0;
            this.lblCNro.Text = "Cliente Nro.";
            this.lblCNro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(299, 158);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(133, 20);
            this.txtMonto.TabIndex = 1;
            // 
            // lblNroCliente
            // 
            this.lblNroCliente.AutoSize = true;
            this.lblNroCliente.Location = new System.Drawing.Point(370, 72);
            this.lblNroCliente.Name = "lblNroCliente";
            this.lblNroCliente.Size = new System.Drawing.Size(35, 13);
            this.lblNroCliente.TabIndex = 2;
            this.lblNroCliente.Text = "label2";
            this.lblNroCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblNroCliente.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(248, 20);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(99, 33);
            this.lblNombreCliente.TabIndex = 4;
            this.lblNombreCliente.Text = "label3";
            this.lblNombreCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(251, 161);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(40, 13);
            this.lblMonto.TabIndex = 6;
            this.lblMonto.Text = "Monto ";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(302, 336);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dTPFechaPago
            // 
            this.dTPFechaPago.Location = new System.Drawing.Point(299, 196);
            this.dTPFechaPago.Name = "dTPFechaPago";
            this.dTPFechaPago.Size = new System.Drawing.Size(233, 20);
            this.dTPFechaPago.TabIndex = 8;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(251, 196);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "Fecha";
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 450);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dTPFechaPago);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.lblNroCliente);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblCNro);
            this.MaximumSize = new System.Drawing.Size(786, 489);
            this.MinimumSize = new System.Drawing.Size(786, 489);
            this.Name = "Factura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.Factura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCNro;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblNroCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DateTimePicker dTPFechaPago;
        private System.Windows.Forms.Label lblFecha;
    }
}