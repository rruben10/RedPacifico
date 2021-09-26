
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblConfig = new System.Windows.Forms.Label();
            this.txtIdConfig = new System.Windows.Forms.TextBox();
            this.errorCampoValido = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorCampoValido)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTasaFinanciamiento
            // 
            this.lblTasaFinanciamiento.AutoSize = true;
            this.lblTasaFinanciamiento.Location = new System.Drawing.Point(110, 144);
            this.lblTasaFinanciamiento.Name = "lblTasaFinanciamiento";
            this.lblTasaFinanciamiento.Size = new System.Drawing.Size(105, 13);
            this.lblTasaFinanciamiento.TabIndex = 0;
            this.lblTasaFinanciamiento.Text = "Tasa Financiamiento";
            // 
            // txtTasaFinanciamiento
            // 
            this.txtTasaFinanciamiento.Location = new System.Drawing.Point(221, 141);
            this.txtTasaFinanciamiento.MaxLength = 9;
            this.txtTasaFinanciamiento.Name = "txtTasaFinanciamiento";
            this.txtTasaFinanciamiento.Size = new System.Drawing.Size(100, 20);
            this.txtTasaFinanciamiento.TabIndex = 1;
            this.txtTasaFinanciamiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTasaFinanciamiento_KeyPress);
            // 
            // txtPorcentajeEnganche
            // 
            this.txtPorcentajeEnganche.Location = new System.Drawing.Point(221, 167);
            this.txtPorcentajeEnganche.MaxLength = 9;
            this.txtPorcentajeEnganche.Name = "txtPorcentajeEnganche";
            this.txtPorcentajeEnganche.Size = new System.Drawing.Size(100, 20);
            this.txtPorcentajeEnganche.TabIndex = 3;
            this.txtPorcentajeEnganche.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcentajeEnganche_KeyPress);
            // 
            // lblPorcentajeEnganche
            // 
            this.lblPorcentajeEnganche.AutoSize = true;
            this.lblPorcentajeEnganche.Location = new System.Drawing.Point(148, 170);
            this.lblPorcentajeEnganche.Name = "lblPorcentajeEnganche";
            this.lblPorcentajeEnganche.Size = new System.Drawing.Size(67, 13);
            this.lblPorcentajeEnganche.TabIndex = 2;
            this.lblPorcentajeEnganche.Text = "% Enganche";
            // 
            // txtPlazo
            // 
            this.txtPlazo.Location = new System.Drawing.Point(221, 195);
            this.txtPlazo.MaxLength = 3;
            this.txtPlazo.Name = "txtPlazo";
            this.txtPlazo.Size = new System.Drawing.Size(100, 20);
            this.txtPlazo.TabIndex = 5;
            this.txtPlazo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlazo_KeyPress);
            // 
            // lblPlazo
            // 
            this.lblPlazo.AutoSize = true;
            this.lblPlazo.Location = new System.Drawing.Point(180, 198);
            this.lblPlazo.Name = "lblPlazo";
            this.lblPlazo.Size = new System.Drawing.Size(33, 13);
            this.lblPlazo.TabIndex = 4;
            this.lblPlazo.Text = "Plazo";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(385, 332);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(515, 332);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblConfig
            // 
            this.lblConfig.AutoSize = true;
            this.lblConfig.Location = new System.Drawing.Point(141, 105);
            this.lblConfig.Name = "lblConfig";
            this.lblConfig.Size = new System.Drawing.Size(72, 13);
            this.lblConfig.TabIndex = 8;
            this.lblConfig.Text = "Configuracion";
            this.lblConfig.Visible = false;
            // 
            // txtIdConfig
            // 
            this.txtIdConfig.Location = new System.Drawing.Point(221, 102);
            this.txtIdConfig.Name = "txtIdConfig";
            this.txtIdConfig.Size = new System.Drawing.Size(100, 20);
            this.txtIdConfig.TabIndex = 9;
            this.txtIdConfig.Visible = false;
            // 
            // errorCampoValido
            // 
            this.errorCampoValido.ContainerControl = this;
            // 
            // Form_catalogoConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIdConfig);
            this.Controls.Add(this.lblConfig);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtPlazo);
            this.Controls.Add(this.lblPlazo);
            this.Controls.Add(this.txtPorcentajeEnganche);
            this.Controls.Add(this.lblPorcentajeEnganche);
            this.Controls.Add(this.txtTasaFinanciamiento);
            this.Controls.Add(this.lblTasaFinanciamiento);
            this.Name = "Form_catalogoConfiguracion";
            this.Text = "Catálogo Configuración";
            ((System.ComponentModel.ISupportInitialize)(this.errorCampoValido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTasaFinanciamiento;
        private System.Windows.Forms.TextBox txtTasaFinanciamiento;
        private System.Windows.Forms.TextBox txtPorcentajeEnganche;
        private System.Windows.Forms.Label lblPorcentajeEnganche;
        private System.Windows.Forms.TextBox txtPlazo;
        private System.Windows.Forms.Label lblPlazo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblConfig;
        private System.Windows.Forms.TextBox txtIdConfig;
        private System.Windows.Forms.ErrorProvider errorCampoValido;
    }
}