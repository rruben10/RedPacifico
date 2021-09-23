
namespace RedPacifico
{
    partial class Form_opcionVentas
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
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.gridVenta = new System.Windows.Forms.DataGridView();
            this.columDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblEnganche = new System.Windows.Forms.Label();
            this.txtEnganche = new System.Windows.Forms.TextBox();
            this.lblBonificacion = new System.Windows.Forms.Label();
            this.txtBonificacion = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCancelarVenta = new System.Windows.Forms.Button();
            this.btnGuardarVenta = new System.Windows.Forms.Button();
            this.btnAgregarProductoVenta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCliente
            // 
            this.txtCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCliente.Location = new System.Drawing.Point(99, 59);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(267, 20);
            this.txtCliente.TabIndex = 0;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(54, 59);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(43, 130);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(50, 13);
            this.lblProducto.TabIndex = 2;
            this.lblProducto.Text = "Producto";
            // 
            // txtProducto
            // 
            this.txtProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtProducto.Location = new System.Drawing.Point(99, 127);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(267, 20);
            this.txtProducto.TabIndex = 3;
            // 
            // gridVenta
            // 
            this.gridVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columDescripcion,
            this.columModelo,
            this.columCantidad,
            this.columPrecio,
            this.columImporte,
            this.columEliminar});
            this.gridVenta.Location = new System.Drawing.Point(46, 210);
            this.gridVenta.Name = "gridVenta";
            this.gridVenta.Size = new System.Drawing.Size(647, 154);
            this.gridVenta.TabIndex = 4;
            // 
            // columDescripcion
            // 
            this.columDescripcion.HeaderText = "Descripcion Producto";
            this.columDescripcion.Name = "columDescripcion";
            // 
            // columModelo
            // 
            this.columModelo.HeaderText = "Modelo";
            this.columModelo.Name = "columModelo";
            // 
            // columCantidad
            // 
            this.columCantidad.HeaderText = "Cantidad";
            this.columCantidad.Name = "columCantidad";
            // 
            // columPrecio
            // 
            this.columPrecio.HeaderText = "Precio";
            this.columPrecio.Name = "columPrecio";
            // 
            // columImporte
            // 
            this.columImporte.HeaderText = "Importe";
            this.columImporte.Name = "columImporte";
            // 
            // columEliminar
            // 
            this.columEliminar.HeaderText = "Eliminar";
            this.columEliminar.Name = "columEliminar";
            this.columEliminar.Text = "Eliminar";
            // 
            // lblEnganche
            // 
            this.lblEnganche.AutoSize = true;
            this.lblEnganche.Location = new System.Drawing.Point(577, 452);
            this.lblEnganche.Name = "lblEnganche";
            this.lblEnganche.Size = new System.Drawing.Size(56, 13);
            this.lblEnganche.TabIndex = 5;
            this.lblEnganche.Text = "Enganche";
            // 
            // txtEnganche
            // 
            this.txtEnganche.Location = new System.Drawing.Point(640, 444);
            this.txtEnganche.Name = "txtEnganche";
            this.txtEnganche.Size = new System.Drawing.Size(100, 20);
            this.txtEnganche.TabIndex = 6;
            // 
            // lblBonificacion
            // 
            this.lblBonificacion.AutoSize = true;
            this.lblBonificacion.Location = new System.Drawing.Point(516, 485);
            this.lblBonificacion.Name = "lblBonificacion";
            this.lblBonificacion.Size = new System.Drawing.Size(117, 13);
            this.lblBonificacion.TabIndex = 7;
            this.lblBonificacion.Text = "Bonificacion Enganche";
            // 
            // txtBonificacion
            // 
            this.txtBonificacion.Location = new System.Drawing.Point(640, 477);
            this.txtBonificacion.Name = "txtBonificacion";
            this.txtBonificacion.Size = new System.Drawing.Size(100, 20);
            this.txtBonificacion.TabIndex = 8;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(602, 515);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(640, 512);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 10;
            // 
            // btnCancelarVenta
            // 
            this.btnCancelarVenta.Location = new System.Drawing.Point(544, 575);
            this.btnCancelarVenta.Name = "btnCancelarVenta";
            this.btnCancelarVenta.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarVenta.TabIndex = 11;
            this.btnCancelarVenta.Text = "Cancelar";
            this.btnCancelarVenta.UseVisualStyleBackColor = true;
            // 
            // btnGuardarVenta
            // 
            this.btnGuardarVenta.Location = new System.Drawing.Point(640, 574);
            this.btnGuardarVenta.Name = "btnGuardarVenta";
            this.btnGuardarVenta.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarVenta.TabIndex = 12;
            this.btnGuardarVenta.Text = "Guardar";
            this.btnGuardarVenta.UseVisualStyleBackColor = true;
            // 
            // btnAgregarProductoVenta
            // 
            this.btnAgregarProductoVenta.Location = new System.Drawing.Point(408, 130);
            this.btnAgregarProductoVenta.Name = "btnAgregarProductoVenta";
            this.btnAgregarProductoVenta.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarProductoVenta.TabIndex = 13;
            this.btnAgregarProductoVenta.Text = "Agregar";
            this.btnAgregarProductoVenta.UseVisualStyleBackColor = true;
            // 
            // Form_opcionVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 630);
            this.Controls.Add(this.btnAgregarProductoVenta);
            this.Controls.Add(this.btnGuardarVenta);
            this.Controls.Add(this.btnCancelarVenta);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtBonificacion);
            this.Controls.Add(this.lblBonificacion);
            this.Controls.Add(this.txtEnganche);
            this.Controls.Add(this.lblEnganche);
            this.Controls.Add(this.gridVenta);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtCliente);
            this.Name = "Form_opcionVentas";
            this.Text = "Opción Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.gridVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.DataGridView gridVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn columDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn columModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn columPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columImporte;
        private System.Windows.Forms.DataGridViewButtonColumn columEliminar;
        private System.Windows.Forms.Label lblEnganche;
        private System.Windows.Forms.TextBox txtEnganche;
        private System.Windows.Forms.Label lblBonificacion;
        private System.Windows.Forms.TextBox txtBonificacion;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCancelarVenta;
        private System.Windows.Forms.Button btnGuardarVenta;
        private System.Windows.Forms.Button btnAgregarProductoVenta;
    }
}