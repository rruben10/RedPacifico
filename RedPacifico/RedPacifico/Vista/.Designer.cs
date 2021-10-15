
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
            this.panelEncabezado = new System.Windows.Forms.Panel();
            this.labelEncabezado = new System.Windows.Forms.Label();
            this.panelIzq = new System.Windows.Forms.Panel();
            this.panelDer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridCatalogoClientes)).BeginInit();
            this.panelEncabezado.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(82)))), ((int)(((byte)(183)))));
            this.btnNuevoCliente.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNuevoCliente.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCliente.ForeColor = System.Drawing.Color.White;
            this.btnNuevoCliente.Location = new System.Drawing.Point(831, 0);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(196, 69);
            this.btnNuevoCliente.TabIndex = 0;
            this.btnNuevoCliente.Text = "Nuevo Cliente";
            this.btnNuevoCliente.UseVisualStyleBackColor = false;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // gridCatalogoClientes
            // 
            this.gridCatalogoClientes.AllowUserToAddRows = false;
            this.gridCatalogoClientes.AllowUserToDeleteRows = false;
            this.gridCatalogoClientes.AllowUserToResizeColumns = false;
            this.gridCatalogoClientes.AllowUserToResizeRows = false;
            this.gridCatalogoClientes.BackgroundColor = System.Drawing.Color.White;
            this.gridCatalogoClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridCatalogoClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridCatalogoClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCatalogoClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCliente,
            this.nombre,
            this.columEditar});
            this.gridCatalogoClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCatalogoClientes.Location = new System.Drawing.Point(0, 0);
            this.gridCatalogoClientes.Name = "gridCatalogoClientes";
            this.gridCatalogoClientes.ReadOnly = true;
            this.gridCatalogoClientes.RowTemplate.Height = 30;
            this.gridCatalogoClientes.Size = new System.Drawing.Size(1027, 664);
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
            // panelEncabezado
            // 
            this.panelEncabezado.BackColor = System.Drawing.Color.White;
            this.panelEncabezado.Controls.Add(this.labelEncabezado);
            this.panelEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEncabezado.Location = new System.Drawing.Point(0, 0);
            this.panelEncabezado.Name = "panelEncabezado";
            this.panelEncabezado.Size = new System.Drawing.Size(1427, 100);
            this.panelEncabezado.TabIndex = 2;
            // 
            // labelEncabezado
            // 
            this.labelEncabezado.AutoSize = true;
            this.labelEncabezado.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEncabezado.Location = new System.Drawing.Point(193, 42);
            this.labelEncabezado.Name = "labelEncabezado";
            this.labelEncabezado.Size = new System.Drawing.Size(241, 40);
            this.labelEncabezado.TabIndex = 0;
            this.labelEncabezado.Text = "Catálogo Clientes";
            // 
            // panelIzq
            // 
            this.panelIzq.BackColor = System.Drawing.Color.White;
            this.panelIzq.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzq.Location = new System.Drawing.Point(0, 100);
            this.panelIzq.Name = "panelIzq";
            this.panelIzq.Size = new System.Drawing.Size(200, 733);
            this.panelIzq.TabIndex = 3;
            // 
            // panelDer
            // 
            this.panelDer.BackColor = System.Drawing.Color.White;
            this.panelDer.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDer.Location = new System.Drawing.Point(1227, 100);
            this.panelDer.Name = "panelDer";
            this.panelDer.Size = new System.Drawing.Size(200, 733);
            this.panelDer.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnNuevoCliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(200, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 69);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridCatalogoClientes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(200, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1027, 664);
            this.panel2.TabIndex = 7;
            // 
            // Form_CatalogoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 833);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDer);
            this.Controls.Add(this.panelIzq);
            this.Controls.Add(this.panelEncabezado);
            this.KeyPreview = true;
            this.Name = "Form_CatalogoClientes";
            this.Text = "Catálogo Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_CatalogoClientes_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridCatalogoClientes)).EndInit();
            this.panelEncabezado.ResumeLayout(false);
            this.panelEncabezado.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.DataGridView gridCatalogoClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewButtonColumn columEditar;
        private System.Windows.Forms.Panel panelEncabezado;
        private System.Windows.Forms.Label labelEncabezado;
        private System.Windows.Forms.Panel panelIzq;
        private System.Windows.Forms.Panel panelDer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

