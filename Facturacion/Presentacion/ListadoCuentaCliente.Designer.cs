
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
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentaCliente)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlImg
            // 
            this.pnlImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(84)))), ((int)(((byte)(110)))));
            this.pnlImg.Size = new System.Drawing.Size(814, 33);
            // 
            // dgvCuentaCliente
            // 
            this.dgvCuentaCliente.AllowUserToAddRows = false;
            this.dgvCuentaCliente.AllowUserToDeleteRows = false;
            this.dgvCuentaCliente.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCuentaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuentaCliente.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCuentaCliente.Location = new System.Drawing.Point(0, 142);
            this.dgvCuentaCliente.Name = "dgvCuentaCliente";
            this.dgvCuentaCliente.ReadOnly = true;
            this.dgvCuentaCliente.Size = new System.Drawing.Size(814, 436);
            this.dgvCuentaCliente.TabIndex = 2;
            this.dgvCuentaCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCuentaCliente_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 100);
            this.panel1.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(84)))), ((int)(((byte)(110)))));
            this.lblTitulo.Location = new System.Drawing.Point(289, 39);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(221, 33);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Cuenta Cliente";
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 33);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(814, 109);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // ListadoCuentaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 578);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dgvCuentaCliente);
            this.MaximumSize = new System.Drawing.Size(820, 584);
            this.MinimumSize = new System.Drawing.Size(820, 584);
            this.Name = "ListadoCuentaCliente";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.ListadoCuentaCliente_Load);
            this.Controls.SetChildIndex(this.dgvCuentaCliente, 0);
            this.Controls.SetChildIndex(this.pnlImg, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.pnlImg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentaCliente)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCuentaCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}