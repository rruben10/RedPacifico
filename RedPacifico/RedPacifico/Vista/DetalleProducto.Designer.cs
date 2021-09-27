
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
            this.errorCampoValido = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorCampoValido)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProducto.Location = new System.Drawing.Point(642, 289);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(194, 29);
            this.txtIdProducto.TabIndex = 23;
            this.txtIdProducto.Visible = false;
            // 
            // lblidProducto
            // 
            this.lblidProducto.AutoSize = true;
            this.lblidProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidProducto.Location = new System.Drawing.Point(540, 292);
            this.lblidProducto.Name = "lblidProducto";
            this.lblidProducto.Size = new System.Drawing.Size(86, 24);
            this.lblidProducto.TabIndex = 22;
            this.lblidProducto.Text = "Producto";
            this.lblidProducto.Visible = false;
            // 
            // btnDetalleGuardar
            // 
            this.btnDetalleGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalleGuardar.Location = new System.Drawing.Point(696, 515);
            this.btnDetalleGuardar.Name = "btnDetalleGuardar";
            this.btnDetalleGuardar.Size = new System.Drawing.Size(140, 53);
            this.btnDetalleGuardar.TabIndex = 21;
            this.btnDetalleGuardar.Text = "Guardar";
            this.btnDetalleGuardar.UseVisualStyleBackColor = true;
            this.btnDetalleGuardar.Click += new System.EventHandler(this.btnDetalleGuardar_Click);
            // 
            // btnDetalleCancelar
            // 
            this.btnDetalleCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalleCancelar.Location = new System.Drawing.Point(486, 515);
            this.btnDetalleCancelar.Name = "btnDetalleCancelar";
            this.btnDetalleCancelar.Size = new System.Drawing.Size(140, 53);
            this.btnDetalleCancelar.TabIndex = 20;
            this.btnDetalleCancelar.Text = "Cancelar";
            this.btnDetalleCancelar.UseVisualStyleBackColor = true;
            // 
            // txtProductoExistencia
            // 
            this.txtProductoExistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductoExistencia.Location = new System.Drawing.Point(642, 429);
            this.txtProductoExistencia.Name = "txtProductoExistencia";
            this.txtProductoExistencia.Size = new System.Drawing.Size(194, 29);
            this.txtProductoExistencia.TabIndex = 3;
            this.txtProductoExistencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductoExistencia_KeyPress);
            // 
            // lblProductoExistencia
            // 
            this.lblProductoExistencia.AutoSize = true;
            this.lblProductoExistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoExistencia.Location = new System.Drawing.Point(530, 432);
            this.lblProductoExistencia.Name = "lblProductoExistencia";
            this.lblProductoExistencia.Size = new System.Drawing.Size(96, 24);
            this.lblProductoExistencia.TabIndex = 18;
            this.lblProductoExistencia.Text = "Existencia";
            // 
            // txtProductoPrecio
            // 
            this.txtProductoPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductoPrecio.Location = new System.Drawing.Point(642, 394);
            this.txtProductoPrecio.Name = "txtProductoPrecio";
            this.txtProductoPrecio.Size = new System.Drawing.Size(194, 29);
            this.txtProductoPrecio.TabIndex = 2;
            this.txtProductoPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductoPrecio_KeyPress);
            // 
            // lblProductoPrecio
            // 
            this.lblProductoPrecio.AutoSize = true;
            this.lblProductoPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoPrecio.Location = new System.Drawing.Point(562, 397);
            this.lblProductoPrecio.Name = "lblProductoPrecio";
            this.lblProductoPrecio.Size = new System.Drawing.Size(64, 24);
            this.lblProductoPrecio.TabIndex = 16;
            this.lblProductoPrecio.Text = "Precio";
            // 
            // txtProductoModelo
            // 
            this.txtProductoModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductoModelo.Location = new System.Drawing.Point(642, 359);
            this.txtProductoModelo.Name = "txtProductoModelo";
            this.txtProductoModelo.Size = new System.Drawing.Size(194, 29);
            this.txtProductoModelo.TabIndex = 1;
            // 
            // lblProductoModelo
            // 
            this.lblProductoModelo.AutoSize = true;
            this.lblProductoModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoModelo.Location = new System.Drawing.Point(552, 362);
            this.lblProductoModelo.Name = "lblProductoModelo";
            this.lblProductoModelo.Size = new System.Drawing.Size(74, 24);
            this.lblProductoModelo.TabIndex = 14;
            this.lblProductoModelo.Text = "Modelo";
            // 
            // txtProductoDes
            // 
            this.txtProductoDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductoDes.Location = new System.Drawing.Point(642, 324);
            this.txtProductoDes.MaxLength = 100;
            this.txtProductoDes.Name = "txtProductoDes";
            this.txtProductoDes.Size = new System.Drawing.Size(194, 29);
            this.txtProductoDes.TabIndex = 0;
            this.txtProductoDes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductoDes_KeyPress);
            // 
            // lblProductoDes
            // 
            this.lblProductoDes.AutoSize = true;
            this.lblProductoDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoDes.Location = new System.Drawing.Point(516, 327);
            this.lblProductoDes.Name = "lblProductoDes";
            this.lblProductoDes.Size = new System.Drawing.Size(110, 24);
            this.lblProductoDes.TabIndex = 12;
            this.lblProductoDes.Text = "Descripción";
            // 
            // errorCampoValido
            // 
            this.errorCampoValido.ContainerControl = this;
            // 
            // Form_detalleProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 737);
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
            this.KeyPreview = true;
            this.Name = "Form_detalleProducto";
            this.Text = "Detalle Producto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_detalleProducto_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorCampoValido)).EndInit();
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
        private System.Windows.Forms.ErrorProvider errorCampoValido;
    }
}