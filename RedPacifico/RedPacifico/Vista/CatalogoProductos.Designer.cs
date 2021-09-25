
namespace RedPacifico
{
    partial class Form_catalogoProductos
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
            this.gridCatalogoProductos = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridCatalogoProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCatalogoProductos
            // 
            this.gridCatalogoProductos.AllowUserToAddRows = false;
            this.gridCatalogoProductos.AllowUserToDeleteRows = false;
            this.gridCatalogoProductos.AllowUserToResizeColumns = false;
            this.gridCatalogoProductos.AllowUserToResizeRows = false;
            this.gridCatalogoProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridCatalogoProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCatalogoProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.descripcion,
            this.columEditar});
            this.gridCatalogoProductos.Location = new System.Drawing.Point(12, 123);
            this.gridCatalogoProductos.Name = "gridCatalogoProductos";
            this.gridCatalogoProductos.ReadOnly = true;
            this.gridCatalogoProductos.Size = new System.Drawing.Size(776, 286);
            this.gridCatalogoProductos.TabIndex = 3;
            this.gridCatalogoProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCatalogoProductos_CellContentClick);
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "Producto";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // columEditar
            // 
            this.columEditar.HeaderText = "";
            this.columEditar.Name = "columEditar";
            this.columEditar.ReadOnly = true;
            this.columEditar.Text = "Editar";
            this.columEditar.UseColumnTextForButtonValue = true;
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.Location = new System.Drawing.Point(603, 41);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(127, 37);
            this.btnNuevoProducto.TabIndex = 2;
            this.btnNuevoProducto.Text = "Nuevo Producto";
            this.btnNuevoProducto.UseVisualStyleBackColor = true;
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // Form_catalogoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridCatalogoProductos);
            this.Controls.Add(this.btnNuevoProducto);
            this.Name = "Form_catalogoProductos";
            this.Text = "Catálogo Productos";
            ((System.ComponentModel.ISupportInitialize)(this.gridCatalogoProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCatalogoProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewButtonColumn columEditar;
        private System.Windows.Forms.Button btnNuevoProducto;
    }
}