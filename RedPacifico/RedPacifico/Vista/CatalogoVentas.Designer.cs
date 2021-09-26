
namespace RedPacifico.Vista
{
    partial class Form_CatalogoVentas
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
            this.gridCatalogoVentas = new System.Windows.Forms.DataGridView();
            this.btnNuevaVenta = new System.Windows.Forms.Button();
            this.ColumVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumDescProduc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridCatalogoVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCatalogoVentas
            // 
            this.gridCatalogoVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCatalogoVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumVenta,
            this.ColumCliente,
            this.ColumProducto,
            this.ColumDescProduc,
            this.ColumModelo,
            this.ColumCantidad,
            this.ColumPrecio,
            this.ColumImporte});
            this.gridCatalogoVentas.Location = new System.Drawing.Point(12, 141);
            this.gridCatalogoVentas.Name = "gridCatalogoVentas";
            this.gridCatalogoVentas.Size = new System.Drawing.Size(776, 297);
            this.gridCatalogoVentas.TabIndex = 0;
            // 
            // btnNuevaVenta
            // 
            this.btnNuevaVenta.Location = new System.Drawing.Point(597, 66);
            this.btnNuevaVenta.Name = "btnNuevaVenta";
            this.btnNuevaVenta.Size = new System.Drawing.Size(121, 40);
            this.btnNuevaVenta.TabIndex = 1;
            this.btnNuevaVenta.Text = "Nueva Venta";
            this.btnNuevaVenta.UseVisualStyleBackColor = true;
            this.btnNuevaVenta.Click += new System.EventHandler(this.btnNuevaVenta_Click);
            // 
            // ColumVenta
            // 
            this.ColumVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumVenta.HeaderText = "Venta";
            this.ColumVenta.Name = "ColumVenta";
            this.ColumVenta.ReadOnly = true;
            this.ColumVenta.Width = 60;
            // 
            // ColumCliente
            // 
            this.ColumCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumCliente.HeaderText = "Cliente";
            this.ColumCliente.Name = "ColumCliente";
            this.ColumCliente.ReadOnly = true;
            this.ColumCliente.Width = 64;
            // 
            // ColumProducto
            // 
            this.ColumProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumProducto.HeaderText = "Producto";
            this.ColumProducto.Name = "ColumProducto";
            this.ColumProducto.ReadOnly = true;
            this.ColumProducto.Width = 75;
            // 
            // ColumDescProduc
            // 
            this.ColumDescProduc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumDescProduc.HeaderText = "Descripcion Producto";
            this.ColumDescProduc.Name = "ColumDescProduc";
            this.ColumDescProduc.ReadOnly = true;
            // 
            // ColumModelo
            // 
            this.ColumModelo.HeaderText = "Modelo";
            this.ColumModelo.Name = "ColumModelo";
            this.ColumModelo.ReadOnly = true;
            // 
            // ColumCantidad
            // 
            this.ColumCantidad.HeaderText = "Cantidad";
            this.ColumCantidad.Name = "ColumCantidad";
            this.ColumCantidad.ReadOnly = true;
            // 
            // ColumPrecio
            // 
            this.ColumPrecio.HeaderText = "Precio";
            this.ColumPrecio.Name = "ColumPrecio";
            this.ColumPrecio.ReadOnly = true;
            // 
            // ColumImporte
            // 
            this.ColumImporte.HeaderText = "Importe";
            this.ColumImporte.Name = "ColumImporte";
            this.ColumImporte.ReadOnly = true;
            // 
            // Form_CatalogoVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNuevaVenta);
            this.Controls.Add(this.gridCatalogoVentas);
            this.Name = "Form_CatalogoVentas";
            this.Text = "Catalogo Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.gridCatalogoVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCatalogoVentas;
        private System.Windows.Forms.Button btnNuevaVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumDescProduc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumImporte;
    }
}