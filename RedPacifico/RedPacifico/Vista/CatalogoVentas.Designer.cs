
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
            this.ColumEnganche = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumBonificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridCatalogoVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCatalogoVentas
            // 
            this.gridCatalogoVentas.AllowUserToAddRows = false;
            this.gridCatalogoVentas.AllowUserToDeleteRows = false;
            this.gridCatalogoVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCatalogoVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumVenta,
            this.ColumCliente,
            this.ColumProducto,
            this.ColumDescProduc,
            this.ColumModelo,
            this.ColumEnganche,
            this.ColumBonificacion,
            this.ColumTotal});
            this.gridCatalogoVentas.Location = new System.Drawing.Point(136, 448);
            this.gridCatalogoVentas.Name = "gridCatalogoVentas";
            this.gridCatalogoVentas.ReadOnly = true;
            this.gridCatalogoVentas.Size = new System.Drawing.Size(1157, 308);
            this.gridCatalogoVentas.TabIndex = 0;
            // 
            // btnNuevaVenta
            // 
            this.btnNuevaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaVenta.Location = new System.Drawing.Point(1125, 357);
            this.btnNuevaVenta.Name = "btnNuevaVenta";
            this.btnNuevaVenta.Size = new System.Drawing.Size(168, 63);
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
            // ColumEnganche
            // 
            this.ColumEnganche.HeaderText = "Enganche";
            this.ColumEnganche.Name = "ColumEnganche";
            this.ColumEnganche.ReadOnly = true;
            // 
            // ColumBonificacion
            // 
            this.ColumBonificacion.HeaderText = "Bonificacion";
            this.ColumBonificacion.Name = "ColumBonificacion";
            this.ColumBonificacion.ReadOnly = true;
            // 
            // ColumTotal
            // 
            this.ColumTotal.HeaderText = "Total";
            this.ColumTotal.Name = "ColumTotal";
            this.ColumTotal.ReadOnly = true;
            // 
            // Form_CatalogoVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 836);
            this.Controls.Add(this.btnNuevaVenta);
            this.Controls.Add(this.gridCatalogoVentas);
            this.KeyPreview = true;
            this.Name = "Form_CatalogoVentas";
            this.Text = "Catalogo Ventas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_CatalogoVentas_KeyDown);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumEnganche;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumBonificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumTotal;
    }
}