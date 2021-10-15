
namespace RedPacifico
{
    partial class Form_detalleProducto
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
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.lblidProducto = new System.Windows.Forms.Label();
            this.txtProductoExistencia = new System.Windows.Forms.TextBox();
            this.lblProductoExistencia = new System.Windows.Forms.Label();
            this.txtProductoPrecio = new System.Windows.Forms.TextBox();
            this.lblProductoPrecio = new System.Windows.Forms.Label();
            this.txtProductoModelo = new System.Windows.Forms.TextBox();
            this.lblProductoModelo = new System.Windows.Forms.Label();
            this.txtProductoDes = new System.Windows.Forms.TextBox();
            this.lblProductoDes = new System.Windows.Forms.Label();
            this.errorCampoValido = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDetalleGuardar = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorCampoValido)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProducto.Location = new System.Drawing.Point(137, 98);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(354, 29);
            this.txtIdProducto.TabIndex = 23;
            this.txtIdProducto.Visible = false;
            // 
            // lblidProducto
            // 
            this.lblidProducto.AutoSize = true;
            this.lblidProducto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblidProducto.Location = new System.Drawing.Point(133, 74);
            this.lblidProducto.Name = "lblidProducto";
            this.lblidProducto.Size = new System.Drawing.Size(73, 21);
            this.lblidProducto.TabIndex = 22;
            this.lblidProducto.Text = "Producto";
            this.lblidProducto.Visible = false;
            // 
            // txtProductoExistencia
            // 
            this.txtProductoExistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductoExistencia.Location = new System.Drawing.Point(137, 388);
            this.txtProductoExistencia.Name = "txtProductoExistencia";
            this.txtProductoExistencia.Size = new System.Drawing.Size(354, 29);
            this.txtProductoExistencia.TabIndex = 3;
            this.txtProductoExistencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductoExistencia_KeyPress);
            // 
            // lblProductoExistencia
            // 
            this.lblProductoExistencia.AutoSize = true;
            this.lblProductoExistencia.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblProductoExistencia.Location = new System.Drawing.Point(133, 364);
            this.lblProductoExistencia.Name = "lblProductoExistencia";
            this.lblProductoExistencia.Size = new System.Drawing.Size(77, 21);
            this.lblProductoExistencia.TabIndex = 18;
            this.lblProductoExistencia.Text = "Existencia";
            // 
            // txtProductoPrecio
            // 
            this.txtProductoPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductoPrecio.Location = new System.Drawing.Point(137, 313);
            this.txtProductoPrecio.Name = "txtProductoPrecio";
            this.txtProductoPrecio.Size = new System.Drawing.Size(354, 29);
            this.txtProductoPrecio.TabIndex = 2;
            this.txtProductoPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductoPrecio_KeyPress);
            // 
            // lblProductoPrecio
            // 
            this.lblProductoPrecio.AutoSize = true;
            this.lblProductoPrecio.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblProductoPrecio.Location = new System.Drawing.Point(133, 289);
            this.lblProductoPrecio.Name = "lblProductoPrecio";
            this.lblProductoPrecio.Size = new System.Drawing.Size(53, 21);
            this.lblProductoPrecio.TabIndex = 16;
            this.lblProductoPrecio.Text = "Precio";
            // 
            // txtProductoModelo
            // 
            this.txtProductoModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductoModelo.Location = new System.Drawing.Point(137, 242);
            this.txtProductoModelo.Name = "txtProductoModelo";
            this.txtProductoModelo.Size = new System.Drawing.Size(354, 29);
            this.txtProductoModelo.TabIndex = 1;
            // 
            // lblProductoModelo
            // 
            this.lblProductoModelo.AutoSize = true;
            this.lblProductoModelo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblProductoModelo.Location = new System.Drawing.Point(133, 218);
            this.lblProductoModelo.Name = "lblProductoModelo";
            this.lblProductoModelo.Size = new System.Drawing.Size(63, 21);
            this.lblProductoModelo.TabIndex = 14;
            this.lblProductoModelo.Text = "Modelo";
            // 
            // txtProductoDes
            // 
            this.txtProductoDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductoDes.Location = new System.Drawing.Point(137, 170);
            this.txtProductoDes.MaxLength = 100;
            this.txtProductoDes.Name = "txtProductoDes";
            this.txtProductoDes.Size = new System.Drawing.Size(354, 29);
            this.txtProductoDes.TabIndex = 0;
            this.txtProductoDes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductoDes_KeyPress);
            // 
            // lblProductoDes
            // 
            this.lblProductoDes.AutoSize = true;
            this.lblProductoDes.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblProductoDes.Location = new System.Drawing.Point(133, 146);
            this.lblProductoDes.Name = "lblProductoDes";
            this.lblProductoDes.Size = new System.Drawing.Size(91, 21);
            this.lblProductoDes.TabIndex = 12;
            this.lblProductoDes.Text = "Descripción";
            // 
            // errorCampoValido
            // 
            this.errorCampoValido.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1410, 100);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.lblidProducto);
            this.panel2.Controls.Add(this.lblProductoDes);
            this.panel2.Controls.Add(this.txtProductoDes);
            this.panel2.Controls.Add(this.txtIdProducto);
            this.panel2.Controls.Add(this.lblProductoModelo);
            this.panel2.Controls.Add(this.txtProductoModelo);
            this.panel2.Controls.Add(this.lblProductoPrecio);
            this.panel2.Controls.Add(this.txtProductoPrecio);
            this.panel2.Controls.Add(this.txtProductoExistencia);
            this.panel2.Controls.Add(this.lblProductoExistencia);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(575, 637);
            this.panel2.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BackgroundImage = global::RedPacifico.Properties.Resources.e1416518_e62a_4a81_9ffa_86316ac00b35;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(575, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(835, 637);
            this.panel3.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.label1.Location = new System.Drawing.Point(74, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalle Producto";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(82)))), ((int)(((byte)(183)))));
            this.panel4.Controls.Add(this.btnDetalleGuardar);
            this.panel4.Location = new System.Drawing.Point(351, 448);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(140, 43);
            this.panel4.TabIndex = 24;
            this.panel4.Click += new System.EventHandler(this.btnDetalleGuardar_Click);
            // 
            // btnDetalleGuardar
            // 
            this.btnDetalleGuardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDetalleGuardar.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnDetalleGuardar.ForeColor = System.Drawing.Color.White;
            this.btnDetalleGuardar.Location = new System.Drawing.Point(0, 0);
            this.btnDetalleGuardar.Name = "btnDetalleGuardar";
            this.btnDetalleGuardar.Size = new System.Drawing.Size(140, 43);
            this.btnDetalleGuardar.TabIndex = 0;
            this.btnDetalleGuardar.Text = "Guardar";
            this.btnDetalleGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDetalleGuardar.Click += new System.EventHandler(this.btnDetalleGuardar_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(184, 448);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(142, 43);
            this.panel5.TabIndex = 25;
            this.panel5.Click += new System.EventHandler(this.btnDetalleCancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(28, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cancelar";
            this.label3.Click += new System.EventHandler(this.btnDetalleCancelar_Click);
            // 
            // Form_detalleProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 737);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "Form_detalleProducto";
            this.Text = "Detalle Producto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_detalleProducto_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorCampoValido)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.Label lblidProducto;
        private System.Windows.Forms.TextBox txtProductoExistencia;
        private System.Windows.Forms.Label lblProductoExistencia;
        private System.Windows.Forms.TextBox txtProductoPrecio;
        private System.Windows.Forms.Label lblProductoPrecio;
        private System.Windows.Forms.TextBox txtProductoModelo;
        private System.Windows.Forms.Label lblProductoModelo;
        private System.Windows.Forms.TextBox txtProductoDes;
        private System.Windows.Forms.Label lblProductoDes;
        private System.Windows.Forms.ErrorProvider errorCampoValido;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label btnDetalleGuardar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
    }
}