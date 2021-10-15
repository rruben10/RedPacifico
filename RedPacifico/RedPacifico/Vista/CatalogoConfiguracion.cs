using RedPacifico.Entidades;
using RedPacifico.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedPacifico
{
    public partial class Form_catalogoConfiguracion : Form, ICatalogoConfiguracionController
    {
        private Controlador.CatalogoConfiguracionController _controlador;
        public Form_catalogoConfiguracion()
        {
            InitializeComponent();
            _controlador = new Controlador.CatalogoConfiguracionController(this);
            ConsultarConfiguracion();
        }

        /// <summary>
        /// variables de la vista
        /// </summary>
        public int IdConfig { get => int.Parse(txtIdConfig.Text); set => IdConfig = value; }
        public float TasaFinanciamiento { get => float.Parse(txtTasaFinanciamiento.Text); set => TasaFinanciamiento = value; }
        public float PorcentajeEnganche { get => float.Parse(txtPorcentajeEnganche.Text); set => PorcentajeEnganche = value; }
        public short Plazo { get => short.Parse(txtPlazo.Text); set => Plazo = value; }

        /// <summary>
        /// Se consulta la configuracion existente
        /// </summary>
        /// <param name="config">objeto con la informacion de la configuracion, se llena desde el modelo mediante la interfaz</param>
        void ICatalogoConfiguracionController.ConsultaConfiguracion(Configuracion config)
        {
            try
            {
                txtIdConfig.Text = config.Id.ToString();
                txtTasaFinanciamiento.Text = String.Format("{0:0.00}", config.Tasa);
                txtPorcentajeEnganche.Text = String.Format("{0:0.00}", config.Enganche);
                txtPlazo.Text = config.Plazo.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Se manda llamar el controlador para obtener la configuracion
        /// </summary>
        public void ConsultarConfiguracion()
        {
            _controlador.ConsultaConfiguracion();
        }
        /// <summary>
        /// Se valida textbox tasa financiamiento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTasaFinanciamiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarCampoFloat(sender, e);
        }
        /// <summary>
        /// Metodo para validar datos tipo float
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void validarCampoFloat(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Metodo para admitir datos solo numericos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void validarCampoNumerico(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Se valida textbox Porcentaje enganche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPorcentajeEnganche_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarCampoFloat(sender, e);
        }
        /// <summary>
        /// Se valida textbox plazo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPlazo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarCampoNumerico(sender, e);
        }
        /// <summary>
        /// Metodo que detorna el evento guardar, valida esten todos los campos validados correctamente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = ValidarDatosCapturados();
            if (mensaje != "")
            {
                MessageBox.Show(mensaje);
            }
            else
            {
                if (_controlador.ModificarConfiguracion())
                {
                    MessageBox.Show("La configuración ha sido registrada");
                }
            }
        }
        /// <summary>
        /// Se valida cada textbox de esta vista
        /// </summary>
        /// <returns></returns>
        private string ValidarDatosCapturados()
        {
            inicializarErrorProviderCampos();

            string MensajeCamposInvalidos = string.Empty;

            if (txtTasaFinanciamiento.Text == "" || float.Parse(txtTasaFinanciamiento.Text) <= 0)
            {
                errorCampoValido.SetError(txtTasaFinanciamiento, "Ingresar Tasa");
                MensajeCamposInvalidos = string.Format("Favor de ingresar {0} es obligatorio", lblTasaFinanciamiento.Text);
                return MensajeCamposInvalidos;
            }
            if (txtPorcentajeEnganche.Text == "" || float.Parse(txtPorcentajeEnganche.Text) <= 0)
            {
                errorCampoValido.SetError(txtPorcentajeEnganche, "Ingresar Enganche");
                MensajeCamposInvalidos = string.Format("Favor de ingresar {0} es obligatorio", lblPorcentajeEnganche.Text);
                return MensajeCamposInvalidos;
            }
            if (txtPlazo.Text == "" || int.Parse(txtPlazo.Text) <= 0)
            {
                errorCampoValido.SetError(txtPlazo, "Ingresar Plazo");
                MensajeCamposInvalidos = string.Format("Favor de ingresar {0} es obligatorio", lblPlazo.Text);
                return MensajeCamposInvalidos;
            }
           
            return MensajeCamposInvalidos;
        }
        private void inicializarErrorProviderCampos()
        {
            errorCampoValido.SetError(txtTasaFinanciamiento, "");
            errorCampoValido.SetError(txtPorcentajeEnganche, "");
            errorCampoValido.SetError(txtPlazo, "");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_catalogoConfiguracion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult cerrarDialogo = MessageBox.Show("Desea salir de la pantalla actual?", "Salir", MessageBoxButtons.YesNo);
                if (cerrarDialogo == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }
    }
}
