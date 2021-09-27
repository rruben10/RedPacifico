
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
            this.components = new System.ComponentModel.Container();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.gridVenta = new System.Windows.Forms.DataGridView();
            this.ColumIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.errorCampoValido = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCampoValido)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCliente
            // 
            this.txtCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(219, 73);
            this.txtCliente.MaxLength = 100;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(403, 29);
            this.txtCliente.TabIndex = 0;
            this.txtCliente.WordWrap = false;
            this.txtCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCliente_KeyPress);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(145, 76);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(68, 24);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(127, 137);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(86, 24);
            this.lblProducto.TabIndex = 2;
            this.lblProducto.Text = "Producto";
            // 
            // txtProducto
            // 
            this.txtProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(219, 134);
            this.txtProducto.MaxLength = 100;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(403, 29);
            this.txtProducto.TabIndex = 1;
            this.txtProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProducto_KeyPress);
            // 
            // gridVenta
            // 
            this.gridVenta.AllowUserToAddRows = false;
            this.gridVenta.AllowUserToDeleteRows = false;
            this.gridVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumIdProducto,
            this.columDescripcion,
            this.columModelo,
            this.columCantidad,
            this.columPrecio,
            this.columImporte,
            this.columEliminar});
            this.gridVenta.Location = new System.Drawing.Point(12, 205);
            this.gridVenta.Name = "gridVenta";
            this.gridVenta.ReadOnly = true;
            this.gridVenta.Size = new System.Drawing.Size(1332, 272);
            this.gridVenta.TabIndex = 4;
            this.gridVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridVenta_CellContentClick);
            // 
            // ColumIdProducto
            // 
            this.ColumIdProducto.HeaderText = "Producto";
            this.ColumIdProducto.Name = "ColumIdProducto";
            this.ColumIdProducto.ReadOnly = true;
            this.ColumIdProducto.Visible = false;
            // 
            // columDescripcion
            // 
            this.columDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columDescripcion.HeaderText = "Descripcion Producto";
            this.columDescripcion.Name = "columDescripcion";
            this.columDescripcion.ReadOnly = true;
            // 
            // columModelo
            // 
            this.columModelo.HeaderText = "Modelo";
            this.columModelo.Name = "columModelo";
            this.columModelo.ReadOnly = true;
            // 
            // columCantidad
            // 
            this.columCantidad.HeaderText = "Cantidad";
            this.columCantidad.Name = "columCantidad";
            this.columCantidad.ReadOnly = true;
            // 
            // columPrecio
            // 
            this.columPrecio.HeaderText = "Precio";
            this.columPrecio.Name = "columPrecio";
            this.columPrecio.ReadOnly = true;
            // 
            // columImporte
            // 
            this.columImporte.HeaderText = "Importe";
            this.columImporte.Name = "columImporte";
            this.columImporte.ReadOnly = true;
            // 
            // columEliminar
            // 
            this.columEliminar.HeaderText = "";
            this.columEliminar.Name = "columEliminar";
            this.columEliminar.ReadOnly = true;
            this.columEliminar.Text = "Eliminar";
            this.columEliminar.UseColumnTextForButtonValue = true;
            // 
            // lblEnganche
            // 
            this.lblEnganche.AutoSize = true;
            this.lblEnganche.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnganche.Location = new System.Drawing.Point(1140, 509);
            this.lblEnganche.Name = "lblEnganche";
            this.lblEnganche.Size = new System.Drawing.Size(98, 24);
            this.lblEnganche.TabIndex = 5;
            this.lblEnganche.Text = "Enganche";
            // 
            // txtEnganche
            // 
            this.txtEnganche.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnganche.Location = new System.Drawing.Point(1244, 506);
            this.txtEnganche.Name = "txtEnganche";
            this.txtEnganche.ReadOnly = true;
            this.txtEnganche.Size = new System.Drawing.Size(100, 29);
            this.txtEnganche.TabIndex = 6;
            // 
            // lblBonificacion
            // 
            this.lblBonificacion.AutoSize = true;
            this.lblBonificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBonificacion.Location = new System.Drawing.Point(1033, 542);
            this.lblBonificacion.Name = "lblBonificacion";
            this.lblBonificacion.Size = new System.Drawing.Size(205, 24);
            this.lblBonificacion.TabIndex = 7;
            this.lblBonificacion.Text = "Bonificacion Enganche";
            // 
            // txtBonificacion
            // 
            this.txtBonificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBonificacion.Location = new System.Drawing.Point(1244, 539);
            this.txtBonificacion.Name = "txtBonificacion";
            this.txtBonificacion.ReadOnly = true;
            this.txtBonificacion.Size = new System.Drawing.Size(100, 29);
            this.txtBonificacion.TabIndex = 8;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(1187, 572);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(51, 24);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(1244, 574);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 29);
            this.txtTotal.TabIndex = 10;
            // 
            // btnCancelarVenta
            // 
            this.btnCancelarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarVenta.Location = new System.Drawing.Point(863, 646);
            this.btnCancelarVenta.Name = "btnCancelarVenta";
            this.btnCancelarVenta.Size = new System.Drawing.Size(201, 66);
            this.btnCancelarVenta.TabIndex = 5;
            this.btnCancelarVenta.Text = "Cancelar";
            this.btnCancelarVenta.UseVisualStyleBackColor = true;
            this.btnCancelarVenta.Click += new System.EventHandler(this.btnCancelarVenta_Click);
            // 
            // btnGuardarVenta
            // 
            this.btnGuardarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarVenta.Location = new System.Drawing.Point(1143, 646);
            this.btnGuardarVenta.Name = "btnGuardarVenta";
            this.btnGuardarVenta.Size = new System.Drawing.Size(201, 66);
            this.btnGuardarVenta.TabIndex = 6;
            this.btnGuardarVenta.Text = "Guardar";
            this.btnGuardarVenta.UseVisualStyleBackColor = true;
            this.btnGuardarVenta.Click += new System.EventHandler(this.btnGuardarVenta_Click);
            // 
            // btnAgregarProductoVenta
            // 
            this.btnAgregarProductoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProductoVenta.Location = new System.Drawing.Point(681, 128);
            this.btnAgregarProductoVenta.Name = "btnAgregarProductoVenta";
            this.btnAgregarProductoVenta.Size = new System.Drawing.Size(137, 42);
            this.btnAgregarProductoVenta.TabIndex = 3;
            this.btnAgregarProductoVenta.Text = "Agregar";
            this.btnAgregarProductoVenta.UseVisualStyleBackColor = true;
            this.btnAgregarProductoVenta.Click += new System.EventHandler(this.btnAgregarProductoVenta_Click);
            // 
            // errorCampoValido
            // 
            this.errorCampoValido.ContainerControl = this;
            // 
            // Form_opcionVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 758);
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
            this.KeyPreview = true;
            this.Name = "Form_opcionVentas";
            this.Text = "Opción Ventas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_opcionVentas_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCampoValido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.DataGridView gridVenta;
        private System.Windows.Forms.Label lblEnganche;
        private System.Windows.Forms.TextBox txtEnganche;
        private System.Windows.Forms.Label lblBonificacion;
        private System.Windows.Forms.TextBox txtBonificacion;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCancelarVenta;
        private System.Windows.Forms.Button btnGuardarVenta;
        private System.Windows.Forms.Button btnAgregarProductoVenta;
        private System.Windows.Forms.ErrorProvider errorCampoValido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn columDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn columModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn columPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columImporte;
        private System.Windows.Forms.DataGridViewButtonColumn columEliminar;
    }
}