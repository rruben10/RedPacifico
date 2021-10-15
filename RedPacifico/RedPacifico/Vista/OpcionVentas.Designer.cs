
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
            this.errorCampoValido = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblBonificacion = new System.Windows.Forms.Label();
            this.lblEnganche = new System.Windows.Forms.Label();
            this.txtEnganche = new System.Windows.Forms.TextBox();
            this.txtBonificacion = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCampoValido)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCliente
            // 
            this.txtCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(77, 57);
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
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCliente.Location = new System.Drawing.Point(73, 33);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(58, 21);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblProducto.Location = new System.Drawing.Point(73, 111);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(73, 21);
            this.lblProducto.TabIndex = 2;
            this.lblProducto.Text = "Producto";
            // 
            // txtProducto
            // 
            this.txtProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(77, 144);
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
            this.gridVenta.BackgroundColor = System.Drawing.Color.White;
            this.gridVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumIdProducto,
            this.columDescripcion,
            this.columModelo,
            this.columCantidad,
            this.columPrecio,
            this.columImporte,
            this.columEliminar});
            this.gridVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridVenta.Location = new System.Drawing.Point(0, 0);
            this.gridVenta.Name = "gridVenta";
            this.gridVenta.ReadOnly = true;
            this.gridVenta.Size = new System.Drawing.Size(844, 675);
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
            this.panel1.Size = new System.Drawing.Size(1423, 83);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtProducto);
            this.panel2.Controls.Add(this.txtCliente);
            this.panel2.Controls.Add(this.lblCliente);
            this.panel2.Controls.Add(this.lblProducto);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1423, 675);
            this.panel2.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.gridVenta);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(579, 83);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(844, 675);
            this.panel4.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.label1.Location = new System.Drawing.Point(113, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Venta";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BackgroundImage = global::RedPacifico.Properties.Resources.e1416518_e62a_4a81_9ffa_86316ac00b35;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(21, 266);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(582, 419);
            this.panel3.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.lblBonificacion);
            this.panel5.Controls.Add(this.lblEnganche);
            this.panel5.Controls.Add(this.txtEnganche);
            this.panel5.Controls.Add(this.txtBonificacion);
            this.panel5.Controls.Add(this.lblTotal);
            this.panel5.Controls.Add(this.txtTotal);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 461);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(844, 214);
            this.panel5.TabIndex = 16;
            // 
            // lblBonificacion
            // 
            this.lblBonificacion.AutoSize = true;
            this.lblBonificacion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblBonificacion.Location = new System.Drawing.Point(521, 56);
            this.lblBonificacion.Name = "lblBonificacion";
            this.lblBonificacion.Size = new System.Drawing.Size(165, 21);
            this.lblBonificacion.TabIndex = 7;
            this.lblBonificacion.Text = "Bonificacion Enganche";
            // 
            // lblEnganche
            // 
            this.lblEnganche.AutoSize = true;
            this.lblEnganche.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblEnganche.Location = new System.Drawing.Point(609, 21);
            this.lblEnganche.Name = "lblEnganche";
            this.lblEnganche.Size = new System.Drawing.Size(77, 21);
            this.lblEnganche.TabIndex = 5;
            this.lblEnganche.Text = "Enganche";
            // 
            // txtEnganche
            // 
            this.txtEnganche.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnganche.Location = new System.Drawing.Point(713, 18);
            this.txtEnganche.Name = "txtEnganche";
            this.txtEnganche.ReadOnly = true;
            this.txtEnganche.Size = new System.Drawing.Size(100, 29);
            this.txtEnganche.TabIndex = 6;
            // 
            // txtBonificacion
            // 
            this.txtBonificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBonificacion.Location = new System.Drawing.Point(713, 51);
            this.txtBonificacion.Name = "txtBonificacion";
            this.txtBonificacion.ReadOnly = true;
            this.txtBonificacion.Size = new System.Drawing.Size(100, 29);
            this.txtBonificacion.TabIndex = 8;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTotal.Location = new System.Drawing.Point(644, 91);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(42, 21);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(713, 86);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 29);
            this.txtTotal.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(82)))), ((int)(((byte)(183)))));
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(655, 137);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(158, 51);
            this.panel6.TabIndex = 11;
            this.panel6.Click += new System.EventHandler(this.btnGuardarVenta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Guardar";
            this.label2.Click += new System.EventHandler(this.btnGuardarVenta_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label3);
            this.panel7.Location = new System.Drawing.Point(448, 137);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(158, 51);
            this.panel7.TabIndex = 12;
            this.panel7.Click += new System.EventHandler(this.btnCancelarVenta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(36, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cancelar";
            this.label3.Click += new System.EventHandler(this.btnCancelarVenta_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(82)))), ((int)(((byte)(183)))));
            this.panel8.Controls.Add(this.label4);
            this.panel8.Location = new System.Drawing.Point(322, 191);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(158, 51);
            this.panel8.TabIndex = 12;
            this.panel8.Click += new System.EventHandler(this.btnAgregarProductoVenta_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Agregar";
            this.label4.Click += new System.EventHandler(this.btnAgregarProductoVenta_Click);
            // 
            // Form_opcionVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 758);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "Form_opcionVentas";
            this.Text = "Opción Ventas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_opcionVentas_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCampoValido)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.DataGridView gridVenta;
        private System.Windows.Forms.ErrorProvider errorCampoValido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn columDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn columModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn columPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columImporte;
        private System.Windows.Forms.DataGridViewButtonColumn columEliminar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBonificacion;
        private System.Windows.Forms.Label lblEnganche;
        private System.Windows.Forms.TextBox txtEnganche;
        private System.Windows.Forms.TextBox txtBonificacion;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label4;
    }
}