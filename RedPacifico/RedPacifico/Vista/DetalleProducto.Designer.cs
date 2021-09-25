
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
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.lblidProducto = new System.Windows.Forms.Label();
            this.btnDetalleGuardar = new System.Windows.Forms.Button();
            this.btnDetalleCancelar = new System.Windows.Forms.Button();
            this.txtProductoExistencia = new System.Windows.Forms.TextBox();
            this.lblProductoExistencia = new System.Windows.Forms.Label();
            this.txtProductoPrecio = new System.Windows.Forms.TextBox();
            this.lblProductoPrecio = new System.Windows.Forms.Label();
            this.txtProductoModelo = new System.Windows.Forms.TextBox();
            this.lblProductoModelo = new System.Windows.Forms.Label();
            this.txtProductoDes = new System.Windows.Forms.TextBox();
            this.lblProductoDes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(347, 94);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(100, 20);
            this.txtIdProducto.TabIndex = 23;
            this.txtIdProducto.Visible = false;
            // 
            // lblidProducto
            // 
            this.lblidProducto.AutoSize = true;
            this.lblidProducto.Location = new System.Drawing.Point(290, 97);
            this.lblidProducto.Name = "lblidProducto";
            this.lblidProducto.Size = new System.Drawing.Size(50, 13);
            this.lblidProducto.TabIndex = 22;
            this.lblidProducto.Text = "Producto";
            this.lblidProducto.Visible = false;
            // 
            // btnDetalleGuardar
            // 
            this.btnDetalleGuardar.Location = new System.Drawing.Point(478, 333);
            this.btnDetalleGuardar.Name = "btnDetalleGuardar";
            this.btnDetalleGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnDetalleGuardar.TabIndex = 21;
            this.btnDetalleGuardar.Text = "Guardar";
            this.btnDetalleGuardar.UseVisualStyleBackColor = true;
            // 
            // btnDetalleCancelar
            // 
            this.btnDetalleCancelar.Location = new System.Drawing.Point(387, 333);
            this.btnDetalleCancelar.Name = "btnDetalleCancelar";
            this.btnDetalleCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnDetalleCancelar.TabIndex = 20;
            this.btnDetalleCancelar.Text = "Cancelar";
            this.btnDetalleCancelar.UseVisualStyleBackColor = true;
            // 
            // txtProductoExistencia
            // 
            this.txtProductoExistencia.Location = new System.Drawing.Point(347, 199);
            this.txtProductoExistencia.Name = "txtProductoExistencia";
            this.txtProductoExistencia.Size = new System.Drawing.Size(100, 20);
            this.txtProductoExistencia.TabIndex = 19;
            // 
            // lblProductoExistencia
            // 
            this.lblProductoExistencia.AutoSize = true;
            this.lblProductoExistencia.Location = new System.Drawing.Point(280, 202);
            this.lblProductoExistencia.Name = "lblProductoExistencia";
            this.lblProductoExistencia.Size = new System.Drawing.Size(55, 13);
            this.lblProductoExistencia.TabIndex = 18;
            this.lblProductoExistencia.Text = "Existencia";
            // 
            // txtProductoPrecio
            // 
            this.txtProductoPrecio.Location = new System.Drawing.Point(347, 173);
            this.txtProductoPrecio.Name = "txtProductoPrecio";
            this.txtProductoPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtProductoPrecio.TabIndex = 17;
            // 
            // lblProductoPrecio
            // 
            this.lblProductoPrecio.AutoSize = true;
            this.lblProductoPrecio.Location = new System.Drawing.Point(298, 176);
            this.lblProductoPrecio.Name = "lblProductoPrecio";
            this.lblProductoPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblProductoPrecio.TabIndex = 16;
            this.lblProductoPrecio.Text = "Precio";
            // 
            // txtProductoModelo
            // 
            this.txtProductoModelo.Location = new System.Drawing.Point(347, 147);
            this.txtProductoModelo.Name = "txtProductoModelo";
            this.txtProductoModelo.Size = new System.Drawing.Size(100, 20);
            this.txtProductoModelo.TabIndex = 15;
            // 
            // lblProductoModelo
            // 
            this.lblProductoModelo.AutoSize = true;
            this.lblProductoModelo.Location = new System.Drawing.Point(298, 150);
            this.lblProductoModelo.Name = "lblProductoModelo";
            this.lblProductoModelo.Size = new System.Drawing.Size(42, 13);
            this.lblProductoModelo.TabIndex = 14;
            this.lblProductoModelo.Text = "Modelo";
            // 
            // txtProductoDes
            // 
            this.txtProductoDes.Location = new System.Drawing.Point(347, 121);
            this.txtProductoDes.MaxLength = 100;
            this.txtProductoDes.Name = "txtProductoDes";
            this.txtProductoDes.Size = new System.Drawing.Size(100, 20);
            this.txtProductoDes.TabIndex = 13;
            // 
            // lblProductoDes
            // 
            this.lblProductoDes.AutoSize = true;
            this.lblProductoDes.Location = new System.Drawing.Point(278, 124);
            this.lblProductoDes.Name = "lblProductoDes";
            this.lblProductoDes.Size = new System.Drawing.Size(63, 13);
            this.lblProductoDes.TabIndex = 12;
            this.lblProductoDes.Text = "Descripción";
            // 
            // Form_detalleProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.lblidProducto);
            this.Controls.Add(this.btnDetalleGuardar);
            this.Controls.Add(this.btnDetalleCancelar);
            this.Controls.Add(this.txtProductoExistencia);
            this.Controls.Add(this.lblProductoExistencia);
            this.Controls.Add(this.txtProductoPrecio);
            this.Controls.Add(this.lblProductoPrecio);
            this.Controls.Add(this.txtProductoModelo);
            this.Controls.Add(this.lblProductoModelo);
            this.Controls.Add(this.txtProductoDes);
            this.Controls.Add(this.lblProductoDes);
            this.Name = "Form_detalleProducto";
            this.Text = "Detalle Producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.Label lblidProducto;
        private System.Windows.Forms.Button btnDetalleGuardar;
        private System.Windows.Forms.Button btnDetalleCancelar;
        private System.Windows.Forms.TextBox txtProductoExistencia;
        private System.Windows.Forms.Label lblProductoExistencia;
        private System.Windows.Forms.TextBox txtProductoPrecio;
        private System.Windows.Forms.Label lblProductoPrecio;
        private System.Windows.Forms.TextBox txtProductoModelo;
        private System.Windows.Forms.Label lblProductoModelo;
        private System.Windows.Forms.TextBox txtProductoDes;
        private System.Windows.Forms.Label lblProductoDes;
    }
}