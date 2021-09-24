
namespace RedPacifico
{
    partial class Form_detalleCliente
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
            this.lblDetalleNombre = new System.Windows.Forms.Label();
            this.txtDetalleNombre = new System.Windows.Forms.TextBox();
            this.txtDetallePaterno = new System.Windows.Forms.TextBox();
            this.lblDetallePaterno = new System.Windows.Forms.Label();
            this.txtDetalleMaterno = new System.Windows.Forms.TextBox();
            this.lblDetalleMaterno = new System.Windows.Forms.Label();
            this.txtDetalleRFC = new System.Windows.Forms.TextBox();
            this.lblRFC = new System.Windows.Forms.Label();
            this.btnDetalleCancelar = new System.Windows.Forms.Button();
            this.btnDetalleGuardar = new System.Windows.Forms.Button();
            this.errorCampoValido = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorCampoValido)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDetalleNombre
            // 
            this.lblDetalleNombre.AutoSize = true;
            this.lblDetalleNombre.Location = new System.Drawing.Point(184, 101);
            this.lblDetalleNombre.Name = "lblDetalleNombre";
            this.lblDetalleNombre.Size = new System.Drawing.Size(44, 13);
            this.lblDetalleNombre.TabIndex = 0;
            this.lblDetalleNombre.Text = "Nombre";
            // 
            // txtDetalleNombre
            // 
            this.txtDetalleNombre.Location = new System.Drawing.Point(241, 98);
            this.txtDetalleNombre.MaxLength = 100;
            this.txtDetalleNombre.Name = "txtDetalleNombre";
            this.txtDetalleNombre.Size = new System.Drawing.Size(100, 20);
            this.txtDetalleNombre.TabIndex = 1;
            // 
            // txtDetallePaterno
            // 
            this.txtDetallePaterno.Location = new System.Drawing.Point(241, 124);
            this.txtDetallePaterno.Name = "txtDetallePaterno";
            this.txtDetallePaterno.Size = new System.Drawing.Size(100, 20);
            this.txtDetallePaterno.TabIndex = 3;
            // 
            // lblDetallePaterno
            // 
            this.lblDetallePaterno.AutoSize = true;
            this.lblDetallePaterno.Location = new System.Drawing.Point(144, 127);
            this.lblDetallePaterno.Name = "lblDetallePaterno";
            this.lblDetallePaterno.Size = new System.Drawing.Size(84, 13);
            this.lblDetallePaterno.TabIndex = 2;
            this.lblDetallePaterno.Text = "Apellido Paterno";
            // 
            // txtDetalleMaterno
            // 
            this.txtDetalleMaterno.Location = new System.Drawing.Point(241, 150);
            this.txtDetalleMaterno.Name = "txtDetalleMaterno";
            this.txtDetalleMaterno.Size = new System.Drawing.Size(100, 20);
            this.txtDetalleMaterno.TabIndex = 5;
            // 
            // lblDetalleMaterno
            // 
            this.lblDetalleMaterno.AutoSize = true;
            this.lblDetalleMaterno.Location = new System.Drawing.Point(142, 153);
            this.lblDetalleMaterno.Name = "lblDetalleMaterno";
            this.lblDetalleMaterno.Size = new System.Drawing.Size(86, 13);
            this.lblDetalleMaterno.TabIndex = 4;
            this.lblDetalleMaterno.Text = "Apellido Materno";
            // 
            // txtDetalleRFC
            // 
            this.txtDetalleRFC.Location = new System.Drawing.Point(241, 176);
            this.txtDetalleRFC.Name = "txtDetalleRFC";
            this.txtDetalleRFC.Size = new System.Drawing.Size(100, 20);
            this.txtDetalleRFC.TabIndex = 7;
            // 
            // lblRFC
            // 
            this.lblRFC.AutoSize = true;
            this.lblRFC.Location = new System.Drawing.Point(200, 179);
            this.lblRFC.Name = "lblRFC";
            this.lblRFC.Size = new System.Drawing.Size(28, 13);
            this.lblRFC.TabIndex = 6;
            this.lblRFC.Text = "RFC";
            // 
            // btnDetalleCancelar
            // 
            this.btnDetalleCancelar.Location = new System.Drawing.Point(281, 310);
            this.btnDetalleCancelar.Name = "btnDetalleCancelar";
            this.btnDetalleCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnDetalleCancelar.TabIndex = 8;
            this.btnDetalleCancelar.Text = "Cancelar";
            this.btnDetalleCancelar.UseVisualStyleBackColor = true;
            this.btnDetalleCancelar.Click += new System.EventHandler(this.btnDetalleCancelar_Click);
            // 
            // btnDetalleGuardar
            // 
            this.btnDetalleGuardar.Location = new System.Drawing.Point(372, 310);
            this.btnDetalleGuardar.Name = "btnDetalleGuardar";
            this.btnDetalleGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnDetalleGuardar.TabIndex = 9;
            this.btnDetalleGuardar.Text = "Guardar";
            this.btnDetalleGuardar.UseVisualStyleBackColor = true;
            this.btnDetalleGuardar.Click += new System.EventHandler(this.btnDetalleGuardar_Click);
            // 
            // errorCampoValido
            // 
            this.errorCampoValido.ContainerControl = this;
            // 
            // Form_detalleCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDetalleGuardar);
            this.Controls.Add(this.btnDetalleCancelar);
            this.Controls.Add(this.txtDetalleRFC);
            this.Controls.Add(this.lblRFC);
            this.Controls.Add(this.txtDetalleMaterno);
            this.Controls.Add(this.lblDetalleMaterno);
            this.Controls.Add(this.txtDetallePaterno);
            this.Controls.Add(this.lblDetallePaterno);
            this.Controls.Add(this.txtDetalleNombre);
            this.Controls.Add(this.lblDetalleNombre);
            this.Name = "Form_detalleCliente";
            this.Text = "Datos Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.errorCampoValido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDetalleNombre;
        private System.Windows.Forms.TextBox txtDetalleNombre;
        private System.Windows.Forms.TextBox txtDetallePaterno;
        private System.Windows.Forms.Label lblDetallePaterno;
        private System.Windows.Forms.TextBox txtDetalleMaterno;
        private System.Windows.Forms.Label lblDetalleMaterno;
        private System.Windows.Forms.TextBox txtDetalleRFC;
        private System.Windows.Forms.Label lblRFC;
        private System.Windows.Forms.Button btnDetalleCancelar;
        private System.Windows.Forms.Button btnDetalleGuardar;
        private System.Windows.Forms.ErrorProvider errorCampoValido;
    }
}