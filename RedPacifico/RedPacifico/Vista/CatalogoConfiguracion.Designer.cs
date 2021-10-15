
namespace RedPacifico
{
    partial class Form_catalogoConfiguracion
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
            this.lblTasaFinanciamiento = new System.Windows.Forms.Label();
            this.txtTasaFinanciamiento = new System.Windows.Forms.TextBox();
            this.txtPorcentajeEnganche = new System.Windows.Forms.TextBox();
            this.lblPorcentajeEnganche = new System.Windows.Forms.Label();
            this.txtPlazo = new System.Windows.Forms.TextBox();
            this.lblPlazo = new System.Windows.Forms.Label();
            this.lblConfig = new System.Windows.Forms.Label();
            this.txtIdConfig = new System.Windows.Forms.TextBox();
            this.errorCampoValido = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelEncabezado = new System.Windows.Forms.Panel();
            this.labelEncabezado = new System.Windows.Forms.Label();
            this.panelIzq = new System.Windows.Forms.Panel();
            this.panelDer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorCampoValido)).BeginInit();
            this.panelEncabezado.SuspendLayout();
            this.panelIzq.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTasaFinanciamiento
            // 
            this.lblTasaFinanciamiento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTasaFinanciamiento.Location = new System.Drawing.Point(172, 129);
            this.lblTasaFinanciamiento.Name = "lblTasaFinanciamiento";
            this.lblTasaFinanciamiento.Size = new System.Drawing.Size(190, 28);
            this.lblTasaFinanciamiento.TabIndex = 0;
            this.lblTasaFinanciamiento.Text = "Tasa Financiamiento";
            // 
            // txtTasaFinanciamiento
            // 
            this.txtTasaFinanciamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTasaFinanciamiento.Location = new System.Drawing.Point(178, 160);
            this.txtTasaFinanciamiento.MaxLength = 9;
            this.txtTasaFinanciamiento.Name = "txtTasaFinanciamiento";
            this.txtTasaFinanciamiento.Size = new System.Drawing.Size(350, 29);
            this.txtTasaFinanciamiento.TabIndex = 1;
            this.txtTasaFinanciamiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTasaFinanciamiento_KeyPress);
            // 
            // txtPorcentajeEnganche
            // 
            this.txtPorcentajeEnganche.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcentajeEnganche.Location = new System.Drawing.Point(176, 238);
            this.txtPorcentajeEnganche.MaxLength = 9;
            this.txtPorcentajeEnganche.Name = "txtPorcentajeEnganche";
            this.txtPorcentajeEnganche.Size = new System.Drawing.Size(351, 29);
            this.txtPorcentajeEnganche.TabIndex = 3;
            this.txtPorcentajeEnganche.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcentajeEnganche_KeyPress);
            // 
            // lblPorcentajeEnganche
            // 
            this.lblPorcentajeEnganche.AutoSize = true;
            this.lblPorcentajeEnganche.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentajeEnganche.Location = new System.Drawing.Point(172, 214);
            this.lblPorcentajeEnganche.Name = "lblPorcentajeEnganche";
            this.lblPorcentajeEnganche.Size = new System.Drawing.Size(94, 21);
            this.lblPorcentajeEnganche.TabIndex = 2;
            this.lblPorcentajeEnganche.Text = "% Enganche";
            // 
            // txtPlazo
            // 
            this.txtPlazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlazo.Location = new System.Drawing.Point(178, 309);
            this.txtPlazo.MaxLength = 3;
            this.txtPlazo.Name = "txtPlazo";
            this.txtPlazo.Size = new System.Drawing.Size(350, 29);
            this.txtPlazo.TabIndex = 5;
            this.txtPlazo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlazo_KeyPress);
            // 
            // lblPlazo
            // 
            this.lblPlazo.AutoSize = true;
            this.lblPlazo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlazo.Location = new System.Drawing.Point(176, 285);
            this.lblPlazo.Name = "lblPlazo";
            this.lblPlazo.Size = new System.Drawing.Size(47, 21);
            this.lblPlazo.TabIndex = 4;
            this.lblPlazo.Text = "Plazo";
            // 
            // lblConfig
            // 
            this.lblConfig.AutoSize = true;
            this.lblConfig.Location = new System.Drawing.Point(465, 9);
            this.lblConfig.Name = "lblConfig";
            this.lblConfig.Size = new System.Drawing.Size(72, 13);
            this.lblConfig.TabIndex = 8;
            this.lblConfig.Text = "Configuracion";
            this.lblConfig.Visible = false;
            // 
            // txtIdConfig
            // 
            this.txtIdConfig.Location = new System.Drawing.Point(545, 6);
            this.txtIdConfig.Name = "txtIdConfig";
            this.txtIdConfig.Size = new System.Drawing.Size(159, 20);
            this.txtIdConfig.TabIndex = 9;
            this.txtIdConfig.Visible = false;
            // 
            // errorCampoValido
            // 
            this.errorCampoValido.ContainerControl = this;
            // 
            // panelEncabezado
            // 
            this.panelEncabezado.BackColor = System.Drawing.Color.White;
            this.panelEncabezado.Controls.Add(this.labelEncabezado);
            this.panelEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEncabezado.Location = new System.Drawing.Point(0, 0);
            this.panelEncabezado.Name = "panelEncabezado";
            this.panelEncabezado.Size = new System.Drawing.Size(1424, 100);
            this.panelEncabezado.TabIndex = 10;
            // 
            // labelEncabezado
            // 
            this.labelEncabezado.AutoSize = true;
            this.labelEncabezado.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEncabezado.Location = new System.Drawing.Point(92, 60);
            this.labelEncabezado.Name = "labelEncabezado";
            this.labelEncabezado.Size = new System.Drawing.Size(319, 40);
            this.labelEncabezado.TabIndex = 0;
            this.labelEncabezado.Text = "Catálogo Configuración";
            // 
            // panelIzq
            // 
            this.panelIzq.BackColor = System.Drawing.Color.White;
            this.panelIzq.Controls.Add(this.panel2);
            this.panelIzq.Controls.Add(this.panel1);
            this.panelIzq.Controls.Add(this.lblTasaFinanciamiento);
            this.panelIzq.Controls.Add(this.txtTasaFinanciamiento);
            this.panelIzq.Controls.Add(this.lblPorcentajeEnganche);
            this.panelIzq.Controls.Add(this.txtIdConfig);
            this.panelIzq.Controls.Add(this.lblConfig);
            this.panelIzq.Controls.Add(this.txtPorcentajeEnganche);
            this.panelIzq.Controls.Add(this.lblPlazo);
            this.panelIzq.Controls.Add(this.txtPlazo);
            this.panelIzq.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzq.Location = new System.Drawing.Point(0, 100);
            this.panelIzq.Name = "panelIzq";
            this.panelIzq.Size = new System.Drawing.Size(712, 656);
            this.panelIzq.TabIndex = 11;
            // 
            // panelDer
            // 
            this.panelDer.BackColor = System.Drawing.Color.White;
            this.panelDer.BackgroundImage = global::RedPacifico.Properties.Resources.e1416518_e62a_4a81_9ffa_86316ac00b35;
            this.panelDer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelDer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDer.Location = new System.Drawing.Point(712, 100);
            this.panelDer.Name = "panelDer";
            this.panelDer.Size = new System.Drawing.Size(712, 656);
            this.panelDer.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(82)))), ((int)(((byte)(183)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(419, 379);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(111, 40);
            this.panel1.TabIndex = 10;
            this.panel1.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Guardar";
            this.label1.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(272, 379);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(111, 40);
            this.panel2.TabIndex = 11;
            this.panel2.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cancelar";
            this.label2.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Form_catalogoConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 756);
            this.Controls.Add(this.panelDer);
            this.Controls.Add(this.panelIzq);
            this.Controls.Add(this.panelEncabezado);
            this.KeyPreview = true;
            this.Name = "Form_catalogoConfiguracion";
            this.Text = "Catálogo Configuración";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_catalogoConfiguracion_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorCampoValido)).EndInit();
            this.panelEncabezado.ResumeLayout(false);
            this.panelEncabezado.PerformLayout();
            this.panelIzq.ResumeLayout(false);
            this.panelIzq.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTasaFinanciamiento;
        private System.Windows.Forms.TextBox txtTasaFinanciamiento;
        private System.Windows.Forms.TextBox txtPorcentajeEnganche;
        private System.Windows.Forms.Label lblPorcentajeEnganche;
        private System.Windows.Forms.TextBox txtPlazo;
        private System.Windows.Forms.Label lblPlazo;
        private System.Windows.Forms.Label lblConfig;
        private System.Windows.Forms.TextBox txtIdConfig;
        private System.Windows.Forms.ErrorProvider errorCampoValido;
        private System.Windows.Forms.Panel panelDer;
        private System.Windows.Forms.Panel panelIzq;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelEncabezado;
        private System.Windows.Forms.Label labelEncabezado;
    }
}