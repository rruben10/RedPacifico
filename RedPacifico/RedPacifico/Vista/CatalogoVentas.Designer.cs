
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
            this.ColumCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumEnganche = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumBonificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridCatalogoVentas)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridCatalogoVentas
            // 
            this.gridCatalogoVentas.AllowUserToAddRows = false;
            this.gridCatalogoVentas.AllowUserToDeleteRows = false;
            this.gridCatalogoVentas.BackgroundColor = System.Drawing.Color.White;
            this.gridCatalogoVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridCatalogoVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridCatalogoVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCatalogoVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumCliente,
            this.ColumProducto,
            this.ColumEnganche,
            this.ColumBonificacion,
            this.ColumTotal});
            this.gridCatalogoVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCatalogoVentas.Location = new System.Drawing.Point(0, 0);
            this.gridCatalogoVentas.Name = "gridCatalogoVentas";
            this.gridCatalogoVentas.ReadOnly = true;
            this.gridCatalogoVentas.Size = new System.Drawing.Size(521, 668);
            this.gridCatalogoVentas.TabIndex = 0;
            // 
            // btnNuevaVenta
            // 
            this.btnNuevaVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(82)))), ((int)(((byte)(183)))));
            this.btnNuevaVenta.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNuevaVenta.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.btnNuevaVenta.ForeColor = System.Drawing.Color.White;
            this.btnNuevaVenta.Location = new System.Drawing.Point(325, 0);
            this.btnNuevaVenta.Name = "btnNuevaVenta";
            this.btnNuevaVenta.Size = new System.Drawing.Size(196, 68);
            this.btnNuevaVenta.TabIndex = 1;
            this.btnNuevaVenta.Text = "Nueva Venta";
            this.btnNuevaVenta.UseVisualStyleBackColor = false;
            this.btnNuevaVenta.Click += new System.EventHandler(this.btnNuevaVenta_Click);
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
            this.ColumTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumTotal.HeaderText = "Total";
            this.ColumTotal.Name = "ColumTotal";
            this.ColumTotal.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1424, 100);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 736);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(939, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(485, 736);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.btnNuevaVenta);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(418, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(521, 68);
            this.panel4.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.gridCatalogoVentas);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(418, 168);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(521, 668);
            this.panel5.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.label1.Location = new System.Drawing.Point(193, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Catálogo Ventas";
            // 
            // Form_CatalogoVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 836);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "Form_CatalogoVentas";
            this.Text = "Catalogo Ventas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_CatalogoVentas_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridCatalogoVentas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCatalogoVentas;
        private System.Windows.Forms.Button btnNuevaVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumEnganche;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumBonificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}