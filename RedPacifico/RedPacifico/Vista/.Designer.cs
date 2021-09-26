
namespace RedPacifico
{
    partial class Form_CatalogoClientes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.gridCatalogoClientes = new System.Windows.Forms.DataGridView();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridCatalogoClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Location = new System.Drawing.Point(603, 70);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(127, 37);
            this.btnNuevoCliente.TabIndex = 0;
            this.btnNuevoCliente.Text = "Nuevo Cliente";
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // gridCatalogoClientes
            // 
            this.gridCatalogoClientes.AllowUserToAddRows = false;
            this.gridCatalogoClientes.AllowUserToDeleteRows = false;
            this.gridCatalogoClientes.AllowUserToResizeColumns = false;
            this.gridCatalogoClientes.AllowUserToResizeRows = false;
            this.gridCatalogoClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridCatalogoClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCatalogoClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCliente,
            this.nombre,
            this.columEditar});
            this.gridCatalogoClientes.Location = new System.Drawing.Point(12, 152);
            this.gridCatalogoClientes.Name = "gridCatalogoClientes";
            this.gridCatalogoClientes.ReadOnly = true;
            this.gridCatalogoClientes.Size = new System.Drawing.Size(776, 286);
            this.gridCatalogoClientes.TabIndex = 1;
            this.gridCatalogoClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCatalogoClientes_CellContentClick);
            // 
            // idCliente
            // 
            this.idCliente.HeaderText = "Cliente";
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // columEditar
            // 
            this.columEditar.HeaderText = "";
            this.columEditar.Name = "columEditar";
            this.columEditar.ReadOnly = true;
            this.columEditar.Text = "Editar";
            this.columEditar.UseColumnTextForButtonValue = true;
            // 
            // Form_CatalogoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridCatalogoClientes);
            this.Controls.Add(this.btnNuevoCliente);
            this.Name = "Form_CatalogoClientes";
            this.Text = "Catálogo Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.gridCatalogoClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.DataGridView gridCatalogoClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewButtonColumn columEditar;
    }
}

