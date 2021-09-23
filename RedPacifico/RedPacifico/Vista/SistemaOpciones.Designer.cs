
namespace RedPacifico
{
    partial class Form_sistemaOpciones
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
            this.boton_ventas = new System.Windows.Forms.Button();
            this.boton_clientes = new System.Windows.Forms.Button();
            this.boton_productos = new System.Windows.Forms.Button();
            this.boton_configuracion = new System.Windows.Forms.Button();
            this.btnConexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boton_ventas
            // 
            this.boton_ventas.Location = new System.Drawing.Point(186, 81);
            this.boton_ventas.Name = "boton_ventas";
            this.boton_ventas.Size = new System.Drawing.Size(75, 23);
            this.boton_ventas.TabIndex = 0;
            this.boton_ventas.Text = "Ventas";
            this.boton_ventas.UseVisualStyleBackColor = true;
            this.boton_ventas.Click += new System.EventHandler(this.boton_ventas_Click);
            // 
            // boton_clientes
            // 
            this.boton_clientes.Location = new System.Drawing.Point(345, 80);
            this.boton_clientes.Name = "boton_clientes";
            this.boton_clientes.Size = new System.Drawing.Size(75, 23);
            this.boton_clientes.TabIndex = 1;
            this.boton_clientes.Text = "Clientes";
            this.boton_clientes.UseVisualStyleBackColor = true;
            this.boton_clientes.Click += new System.EventHandler(this.boton_clientes_Click);
            // 
            // boton_productos
            // 
            this.boton_productos.Location = new System.Drawing.Point(186, 169);
            this.boton_productos.Name = "boton_productos";
            this.boton_productos.Size = new System.Drawing.Size(75, 23);
            this.boton_productos.TabIndex = 2;
            this.boton_productos.Text = "Productos";
            this.boton_productos.UseVisualStyleBackColor = true;
            this.boton_productos.Click += new System.EventHandler(this.boton_productos_Click);
            // 
            // boton_configuracion
            // 
            this.boton_configuracion.Location = new System.Drawing.Point(345, 169);
            this.boton_configuracion.Name = "boton_configuracion";
            this.boton_configuracion.Size = new System.Drawing.Size(83, 23);
            this.boton_configuracion.TabIndex = 3;
            this.boton_configuracion.Text = "Configuración";
            this.boton_configuracion.UseVisualStyleBackColor = true;
            this.boton_configuracion.Click += new System.EventHandler(this.boton_configuracion_Click);
            // 
            // btnConexion
            // 
            this.btnConexion.Location = new System.Drawing.Point(304, 300);
            this.btnConexion.Name = "btnConexion";
            this.btnConexion.Size = new System.Drawing.Size(143, 42);
            this.btnConexion.TabIndex = 4;
            this.btnConexion.Text = "Probar conexion";
            this.btnConexion.UseVisualStyleBackColor = true;
            this.btnConexion.Click += new System.EventHandler(this.btnConexion_Click);
            // 
            // Form_sistemaOpciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConexion);
            this.Controls.Add(this.boton_configuracion);
            this.Controls.Add(this.boton_productos);
            this.Controls.Add(this.boton_clientes);
            this.Controls.Add(this.boton_ventas);
            this.Name = "Form_sistemaOpciones";
            this.Text = "Sistema Opciones";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button boton_ventas;
        private System.Windows.Forms.Button boton_clientes;
        private System.Windows.Forms.Button boton_productos;
        private System.Windows.Forms.Button boton_configuracion;
        private System.Windows.Forms.Button btnConexion;
    }
}