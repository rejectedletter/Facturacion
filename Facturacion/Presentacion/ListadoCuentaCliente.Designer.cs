
namespace Facturacion
{
    partial class ListadoCuentaCliente
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
            this.dgvCuentaCliente = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlImg = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentaCliente)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlImg.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCuentaCliente
            // 
            this.dgvCuentaCliente.AllowUserToAddRows = false;
            this.dgvCuentaCliente.AllowUserToDeleteRows = false;
            this.dgvCuentaCliente.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCuentaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuentaCliente.Location = new System.Drawing.Point(0, 106);
            this.dgvCuentaCliente.Name = "dgvCuentaCliente";
            this.dgvCuentaCliente.ReadOnly = true;
            this.dgvCuentaCliente.Size = new System.Drawing.Size(800, 409);
            this.dgvCuentaCliente.TabIndex = 2;
            this.dgvCuentaCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCuentaCliente_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlImg);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 100);
            this.panel1.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitulo.Location = new System.Drawing.Point(283, 48);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(221, 33);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Cuenta Cliente";
            // 
            // pnlImg
            // 
            this.pnlImg.BackColor = System.Drawing.Color.SandyBrown;
            this.pnlImg.Controls.Add(this.btnMinimizar);
            this.pnlImg.Controls.Add(this.btnMaximizar);
            this.pnlImg.Controls.Add(this.btnCerrar);
            this.pnlImg.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlImg.Location = new System.Drawing.Point(0, 0);
            this.pnlImg.Name = "pnlImg";
            this.pnlImg.Size = new System.Drawing.Size(804, 33);
            this.pnlImg.TabIndex = 2;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Location = new System.Drawing.Point(684, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(32, 24);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.Text = "X";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Location = new System.Drawing.Point(722, 3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(32, 24);
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.Text = "X";
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(760, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(32, 24);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // ListadoCuentaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 545);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvCuentaCliente);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(820, 584);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(820, 584);
            this.Name = "ListadoCuentaCliente";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.ListadoCuentaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentaCliente)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlImg.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCuentaCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlImg;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnCerrar;
    }
}