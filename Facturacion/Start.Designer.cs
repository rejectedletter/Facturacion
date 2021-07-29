
namespace Facturacion
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.pnlImg = new System.Windows.Forms.Panel();
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.btnListarDePRoductos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlImg
            // 
            this.pnlImg.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlImg.Location = new System.Drawing.Point(0, 0);
            this.pnlImg.Name = "pnlImg";
            this.pnlImg.Size = new System.Drawing.Size(612, 100);
            this.pnlImg.TabIndex = 0;
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.FlatAppearance.BorderSize = 0;
            this.btnNuevoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoProducto.Image")));
            this.btnNuevoProducto.Location = new System.Drawing.Point(368, 176);
            this.btnNuevoProducto.Margin = new System.Windows.Forms.Padding(0);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(156, 94);
            this.btnNuevoProducto.TabIndex = 1;
            this.btnNuevoProducto.Text = "Agregar Producto";
            this.btnNuevoProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNuevoProducto.UseVisualStyleBackColor = true;
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // btnListarDePRoductos
            // 
            this.btnListarDePRoductos.FlatAppearance.BorderSize = 0;
            this.btnListarDePRoductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarDePRoductos.Image = ((System.Drawing.Image)(resources.GetObject("btnListarDePRoductos.Image")));
            this.btnListarDePRoductos.Location = new System.Drawing.Point(65, 173);
            this.btnListarDePRoductos.Margin = new System.Windows.Forms.Padding(0);
            this.btnListarDePRoductos.Name = "btnListarDePRoductos";
            this.btnListarDePRoductos.Size = new System.Drawing.Size(118, 97);
            this.btnListarDePRoductos.TabIndex = 2;
            this.btnListarDePRoductos.Text = "Lista de Productos";
            this.btnListarDePRoductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnListarDePRoductos.UseVisualStyleBackColor = true;
            this.btnListarDePRoductos.Click += new System.EventHandler(this.btnListarDePRoductos_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(612, 370);
            this.Controls.Add(this.btnListarDePRoductos);
            this.Controls.Add(this.btnNuevoProducto);
            this.Controls.Add(this.pnlImg);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.Name = "Start";
            this.Text = "Productos";
            this.TransparencyKey = System.Drawing.Color.Yellow;
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel pnlImg;
        private System.Windows.Forms.Button btnNuevoProducto;
        private System.Windows.Forms.Button btnListarDePRoductos;
    }
}

