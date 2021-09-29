
namespace Facturacion.Presentacion
{
    partial class PresentacionBase
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
            this.pnlImg = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.pnlImg.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlImg
            // 
            this.pnlImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(84)))), ((int)(((byte)(110)))));
            this.pnlImg.Controls.Add(this.panelButtons);
            this.pnlImg.Controls.Add(this.pnlColor);
            this.pnlImg.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlImg.Location = new System.Drawing.Point(0, 0);
            this.pnlImg.Name = "pnlImg";
            this.pnlImg.Size = new System.Drawing.Size(1107, 33);
            this.pnlImg.TabIndex = 1;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImage = global::Facturacion.Properties.Resources._084_multiply;
            this.btnCerrar.Location = new System.Drawing.Point(98, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(32, 24);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnMinimizar.BackgroundImage = global::Facturacion.Properties.Resources._083_substract;
            this.btnMinimizar.Location = new System.Drawing.Point(3, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(32, 24);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.Text = "X";
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Location = new System.Drawing.Point(51, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(32, 24);
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.Text = "X";
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // pnlColor
            // 
            this.pnlColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(78)))));
            this.pnlColor.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlColor.Location = new System.Drawing.Point(0, 0);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(274, 33);
            this.pnlColor.TabIndex = 3;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnCerrar);
            this.panelButtons.Controls.Add(this.btnMaximizar);
            this.panelButtons.Controls.Add(this.btnMinimizar);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButtons.Location = new System.Drawing.Point(974, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(133, 33);
            this.panelButtons.TabIndex = 4;
            // 
            // PresentacionBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 605);
            this.ControlBox = false;
            this.Controls.Add(this.pnlImg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PresentacionBase";
            this.Load += new System.EventHandler(this.PresentacionBase_Load);
            this.pnlImg.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnCerrar;
        protected System.Windows.Forms.Panel pnlColor;
        protected System.Windows.Forms.Panel pnlImg;
        private System.Windows.Forms.Panel panelButtons;
    }
}