
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
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnCuentaCliente = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnPlanes = new System.Windows.Forms.Button();
            this.btnZonas = new System.Windows.Forms.Button();
            this.pnlImg.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlImg
            // 
            this.pnlImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(84)))), ((int)(((byte)(110)))));
            this.pnlImg.Size = new System.Drawing.Size(838, 33);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 468);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel2.Controls.Add(this.btnClientes);
            this.panel2.Controls.Add(this.btnPlanes);
            this.panel2.Controls.Add(this.btnZonas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 468);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(274, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(564, 468);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.dgvDatos);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(564, 468);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnCuentaCliente);
            this.panel5.Controls.Add(this.btnEliminar);
            this.panel5.Controls.Add(this.btnModificar);
            this.panel5.Controls.Add(this.btnNuevo);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(564, 38);
            this.panel5.TabIndex = 0;
            // 
            // btnCuentaCliente
            // 
            this.btnCuentaCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCuentaCliente.Image = global::Facturacion.Properties.Resources._241_folder__1_;
            this.btnCuentaCliente.Location = new System.Drawing.Point(339, 1);
            this.btnCuentaCliente.Name = "btnCuentaCliente";
            this.btnCuentaCliente.Size = new System.Drawing.Size(50, 34);
            this.btnCuentaCliente.TabIndex = 3;
            this.btnCuentaCliente.UseVisualStyleBackColor = true;
            this.btnCuentaCliente.Visible = false;
            this.btnCuentaCliente.Click += new System.EventHandler(this.btnCuentaCliente_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEliminar.Image = global::Facturacion.Properties.Resources._276_trash__1_;
            this.btnEliminar.Location = new System.Drawing.Point(273, 1);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(50, 34);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnModificar.Image = global::Facturacion.Properties.Resources._218_edit__3_;
            this.btnModificar.Location = new System.Drawing.Point(202, 1);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(50, 34);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNuevo.Image = global::Facturacion.Properties.Resources._056_plus__1_;
            this.btnNuevo.Location = new System.Drawing.Point(133, 1);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(50, 34);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.White;
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDatos.Location = new System.Drawing.Point(0, 40);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.Size = new System.Drawing.Size(564, 428);
            this.dgvDatos.TabIndex = 1;
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClientes.Location = new System.Drawing.Point(5, 84);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(0);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(266, 50);
            this.btnClientes.TabIndex = 5;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnPlanes
            // 
            this.btnPlanes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnPlanes.FlatAppearance.BorderSize = 0;
            this.btnPlanes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPlanes.Location = new System.Drawing.Point(5, 134);
            this.btnPlanes.Margin = new System.Windows.Forms.Padding(0);
            this.btnPlanes.Name = "btnPlanes";
            this.btnPlanes.Size = new System.Drawing.Size(266, 50);
            this.btnPlanes.TabIndex = 7;
            this.btnPlanes.Text = "Planes";
            this.btnPlanes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlanes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlanes.UseVisualStyleBackColor = false;
            this.btnPlanes.Click += new System.EventHandler(this.btnPlanes_Click);
            // 
            // btnZonas
            // 
            this.btnZonas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnZonas.FlatAppearance.BorderSize = 0;
            this.btnZonas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZonas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnZonas.Location = new System.Drawing.Point(5, 184);
            this.btnZonas.Margin = new System.Windows.Forms.Padding(0);
            this.btnZonas.Name = "btnZonas";
            this.btnZonas.Size = new System.Drawing.Size(266, 50);
            this.btnZonas.TabIndex = 6;
            this.btnZonas.Text = "Zonas";
            this.btnZonas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZonas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnZonas.UseVisualStyleBackColor = false;
            this.btnZonas.Click += new System.EventHandler(this.btnZonas_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(838, 501);
            this.Controls.Add(this.panel1);
            this.Name = "Start";
            this.ShowIcon = false;
            this.TransparencyKey = System.Drawing.Color.Yellow;
            this.Load += new System.EventHandler(this.Start_Load);
            this.Controls.SetChildIndex(this.pnlImg, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.pnlImg.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnCuentaCliente;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnPlanes;
        private System.Windows.Forms.Button btnZonas;
    }
}

