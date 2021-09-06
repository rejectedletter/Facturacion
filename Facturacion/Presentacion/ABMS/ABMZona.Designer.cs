
namespace Facturacion.Presentacion.ABMS
{
    partial class ABMZona
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
            this.lblNobreZona = new System.Windows.Forms.Label();
            this.txtNombreZona = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNobreZona
            // 
            this.lblNobreZona.AutoSize = true;
            this.lblNobreZona.Location = new System.Drawing.Point(310, 225);
            this.lblNobreZona.Name = "lblNobreZona";
            this.lblNobreZona.Size = new System.Drawing.Size(85, 13);
            this.lblNobreZona.TabIndex = 20;
            this.lblNobreZona.Text = "Nombre de zona";
            // 
            // txtNombreZona
            // 
            this.txtNombreZona.Location = new System.Drawing.Point(401, 222);
            this.txtNombreZona.Name = "txtNombreZona";
            this.txtNombreZona.Size = new System.Drawing.Size(100, 20);
            this.txtNombreZona.TabIndex = 21;
            // 
            // ABMZona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNombreZona);
            this.Controls.Add(this.lblNobreZona);
            this.Name = "ABMZona";
            this.Load += new System.EventHandler(this.ABMZona_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.lblNobreZona, 0);
            this.Controls.SetChildIndex(this.txtNombreZona, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNobreZona;
        private System.Windows.Forms.TextBox txtNombreZona;
    }
}