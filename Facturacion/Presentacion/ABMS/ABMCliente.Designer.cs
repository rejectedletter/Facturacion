
namespace Facturacion
{
    partial class ABMCliente
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblCodigocliente = new System.Windows.Forms.Label();
            this.lblCodigoClienteTit = new System.Windows.Forms.Label();
            this.pnlcliente = new System.Windows.Forms.Panel();
            this.btnCargarProducto = new System.Windows.Forms.Button();
            this.txtLocParticular = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBarrioParticular = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dTPFechaNac = new System.Windows.Forms.DateTimePicker();
            this.txtRubro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLocComercial = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBarrioComercial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDirComercial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDirParticular = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlcliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(139, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(226, 20);
            this.txtNombre.TabIndex = 8;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(70, 75);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(139, 101);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(226, 20);
            this.txtApellido.TabIndex = 13;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Apellido";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(139, 159);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(226, 20);
            this.txtDni.TabIndex = 15;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdireccion_KeyPress);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(88, 159);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(26, 13);
            this.lblDireccion.TabIndex = 14;
            this.lblDireccion.Text = "DNI";
            // 
            // lblCodigocliente
            // 
            this.lblCodigocliente.AutoSize = true;
            this.lblCodigocliente.Location = new System.Drawing.Point(445, 22);
            this.lblCodigocliente.Name = "lblCodigocliente";
            this.lblCodigocliente.Size = new System.Drawing.Size(35, 13);
            this.lblCodigocliente.TabIndex = 16;
            this.lblCodigocliente.Text = "label2";
            // 
            // lblCodigoClienteTit
            // 
            this.lblCodigoClienteTit.AutoSize = true;
            this.lblCodigoClienteTit.Location = new System.Drawing.Point(340, 22);
            this.lblCodigoClienteTit.Name = "lblCodigoClienteTit";
            this.lblCodigoClienteTit.Size = new System.Drawing.Size(65, 13);
            this.lblCodigoClienteTit.TabIndex = 17;
            this.lblCodigoClienteTit.Text = "Cliente Nro.:";
            // 
            // pnlcliente
            // 
            this.pnlcliente.Controls.Add(this.btnCargarProducto);
            this.pnlcliente.Controls.Add(this.txtLocParticular);
            this.pnlcliente.Controls.Add(this.label11);
            this.pnlcliente.Controls.Add(this.txtBarrioParticular);
            this.pnlcliente.Controls.Add(this.label12);
            this.pnlcliente.Controls.Add(this.label9);
            this.pnlcliente.Controls.Add(this.dTPFechaNac);
            this.pnlcliente.Controls.Add(this.txtRubro);
            this.pnlcliente.Controls.Add(this.label8);
            this.pnlcliente.Controls.Add(this.txtLocComercial);
            this.pnlcliente.Controls.Add(this.label7);
            this.pnlcliente.Controls.Add(this.txtBarrioComercial);
            this.pnlcliente.Controls.Add(this.label6);
            this.pnlcliente.Controls.Add(this.txtDirComercial);
            this.pnlcliente.Controls.Add(this.label5);
            this.pnlcliente.Controls.Add(this.txttelefono);
            this.pnlcliente.Controls.Add(this.label4);
            this.pnlcliente.Controls.Add(this.txtCelular);
            this.pnlcliente.Controls.Add(this.label3);
            this.pnlcliente.Controls.Add(this.txtDirParticular);
            this.pnlcliente.Controls.Add(this.label2);
            this.pnlcliente.Controls.Add(this.lblCodigocliente);
            this.pnlcliente.Controls.Add(this.lblCodigoClienteTit);
            this.pnlcliente.Controls.Add(this.txtNombre);
            this.pnlcliente.Controls.Add(this.txtDni);
            this.pnlcliente.Controls.Add(this.lblNombre);
            this.pnlcliente.Controls.Add(this.lblDireccion);
            this.pnlcliente.Controls.Add(this.label1);
            this.pnlcliente.Controls.Add(this.txtApellido);
            this.pnlcliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlcliente.Location = new System.Drawing.Point(0, 0);
            this.pnlcliente.Name = "pnlcliente";
            this.pnlcliente.Size = new System.Drawing.Size(829, 571);
            this.pnlcliente.TabIndex = 22;
            // 
            // btnCargarProducto
            // 
            this.btnCargarProducto.Location = new System.Drawing.Point(491, 211);
            this.btnCargarProducto.Name = "btnCargarProducto";
            this.btnCargarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnCargarProducto.TabIndex = 38;
            this.btnCargarProducto.Text = "Producto";
            this.btnCargarProducto.UseVisualStyleBackColor = true;
            this.btnCargarProducto.Click += new System.EventHandler(this.btnCargarProducto_Click_1);
            // 
            // txtLocParticular
            // 
            this.txtLocParticular.Location = new System.Drawing.Point(139, 237);
            this.txtLocParticular.Name = "txtLocParticular";
            this.txtLocParticular.Size = new System.Drawing.Size(226, 20);
            this.txtLocParticular.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(61, 237);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Localidad";
            // 
            // txtBarrioParticular
            // 
            this.txtBarrioParticular.Location = new System.Drawing.Point(139, 211);
            this.txtBarrioParticular.Name = "txtBarrioParticular";
            this.txtBarrioParticular.Size = new System.Drawing.Size(226, 20);
            this.txtBarrioParticular.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(80, 211);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Barrio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Fecha de Nacimiento";
            // 
            // dTPFechaNac
            // 
            this.dTPFechaNac.Location = new System.Drawing.Point(139, 127);
            this.dTPFechaNac.Name = "dTPFechaNac";
            this.dTPFechaNac.Size = new System.Drawing.Size(226, 20);
            this.dTPFechaNac.TabIndex = 32;
            // 
            // txtRubro
            // 
            this.txtRubro.Location = new System.Drawing.Point(550, 179);
            this.txtRubro.Name = "txtRubro";
            this.txtRubro.Size = new System.Drawing.Size(226, 20);
            this.txtRubro.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(486, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Rubro";
            // 
            // txtLocComercial
            // 
            this.txtLocComercial.Location = new System.Drawing.Point(550, 153);
            this.txtLocComercial.Name = "txtLocComercial";
            this.txtLocComercial.Size = new System.Drawing.Size(226, 20);
            this.txtLocComercial.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(469, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Localidad";
            // 
            // txtBarrioComercial
            // 
            this.txtBarrioComercial.Location = new System.Drawing.Point(550, 127);
            this.txtBarrioComercial.Name = "txtBarrioComercial";
            this.txtBarrioComercial.Size = new System.Drawing.Size(226, 20);
            this.txtBarrioComercial.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(488, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Barrio";
            // 
            // txtDirComercial
            // 
            this.txtDirComercial.Location = new System.Drawing.Point(550, 101);
            this.txtDirComercial.Name = "txtDirComercial";
            this.txtDirComercial.Size = new System.Drawing.Size(226, 20);
            this.txtDirComercial.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(424, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Domicilio Comercial";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(550, 75);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(226, 20);
            this.txttelefono.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(473, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Telefono";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(139, 263);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(226, 20);
            this.txtCelular.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nro. Celular";
            // 
            // txtDirParticular
            // 
            this.txtDirParticular.Location = new System.Drawing.Point(139, 185);
            this.txtDirParticular.Name = "txtDirParticular";
            this.txtDirParticular.Size = new System.Drawing.Size(226, 20);
            this.txtDirParticular.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Domicilio Particular";
            // 
            // ABMCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 571);
            this.Controls.Add(this.pnlcliente);
            this.Name = "ABMCliente";
            this.Load += new System.EventHandler(this.ABMCliente_Load);
            this.Controls.SetChildIndex(this.pnlcliente, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlcliente.ResumeLayout(false);
            this.pnlcliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblCodigocliente;
        private System.Windows.Forms.Label lblCodigoClienteTit;
        private System.Windows.Forms.Panel pnlcliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dTPFechaNac;
        private System.Windows.Forms.TextBox txtRubro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLocComercial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBarrioComercial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDirComercial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDirParticular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLocParticular;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBarrioParticular;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCargarProducto;
    }
}