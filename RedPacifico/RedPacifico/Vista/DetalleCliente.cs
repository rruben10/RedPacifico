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
    public partial class Form_detalleCliente : Form, IDetalleClienteController
    {
        private Controlador.DetalleClienteController _controlador;
        #region Asignacion de variables
        public string DetalleNombre
        {
            get
            {
                return txtDetalleNombre.Text;
            }

            set
            {
                DetalleNombre = value;
            }
        }
        public string DetalleApePaterno
        {
            get
            {
                return txtDetallePaterno.Text;
            }

            set
            {
                DetalleApePaterno = value;
            }
        }
        public string DetalleApeMaterno
        {
            get
            {
                return txtDetalleMaterno.Text;
            }

            set
            {
                DetalleApeMaterno = value;
            }
        }
        public string DetalleRFC
        {
            get
            {
                return txtDetalleRFC.Text;
            }

            set
            {
                DetalleRFC = value;
            }
        }

        public int IdCliente
        {
            get
            {
                return int.Parse(txtIdCliente.Text);
            }
            set
            {
                IdCliente = value;
            }
        }

        #endregion

        public Form_detalleCliente()
        {
            InitializeComponent();
            _controlador = new Controlador.DetalleClienteController(this);
        }

        public Form_detalleCliente(int idCliente)
        {
            InitializeComponent();
            _controlador = new Controlador.DetalleClienteController(this);

            _controlador.ConsultaCliente(idCliente);

            this.btnDetalleGuardar.Text = "Actualizar";



        }

        private void btnDetalleGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = ValidarDatosCapturados();
            if (mensaje != "")
            {
                MessageBox.Show(mensaje);
            }
            else if (this.btnDetalleGuardar.Text == "Actualizar")
            {
                if(_controlador.ActualizarDatosCliente())
                {
                    MessageBox.Show("Se actualizaron los datos correctamente.");
                    this.Close();
                    Form_CatalogoClientes catalogo = new Form_CatalogoClientes();
                    catalogo.ShowDialog();
                }
            }
            else
            {
                _controlador.GuardarCliente();
            }
        }

        private void btnDetalleCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string ValidarDatosCapturados()
        {
            inicializarErrorProviderCampos();

            string MensajeCamposInvalidos = string.Empty;

            if (txtDetalleNombre.Text == "")
            {
                errorCampoValido.SetError(txtDetalleNombre, "Ingresar Nombre");
                MensajeCamposInvalidos = string.Format("Favor de ingresar {0} es obligatorio", lblDetalleNombre.Text);
                return MensajeCamposInvalidos;
            }
            if (txtDetallePaterno.Text == "")
            {
                errorCampoValido.SetError(txtDetallePaterno, "Ingresar Apellido Paterno");
                MensajeCamposInvalidos = string.Format("Favor de ingresar {0} es obligatorio", lblDetallePaterno.Text);
                return MensajeCamposInvalidos;
            }
            if (txtDetalleMaterno.Text == "")
            {
                errorCampoValido.SetError(txtDetalleMaterno, "Ingresar Apellido Materno");
                MensajeCamposInvalidos = string.Format("Favor de ingresar {0} es obligatorio", lblDetalleMaterno.Text);
                return MensajeCamposInvalidos;
            }
            if (txtDetalleRFC.Text == "")
            {
                errorCampoValido.SetError(txtDetalleRFC, "Ingresar RFC");
                MensajeCamposInvalidos = string.Format("Favor de ingresar {0} es obligatorio", lblRFC.Text);
                return MensajeCamposInvalidos;
            }

            return MensajeCamposInvalidos;
        }

        private void inicializarErrorProviderCampos()
        {
            errorCampoValido.SetError(txtDetalleNombre, "");
            errorCampoValido.SetError(txtDetallePaterno, "");
            errorCampoValido.SetError(txtDetalleMaterno, "");
            errorCampoValido.SetError(txtDetalleRFC, "");
        }

        public void GuardarRegistro(int grabado)
        {
            if (grabado == 1)
            {
                MessageBox.Show("El cliente ha sido registrado correctamente");

                this.Close();

                Form_CatalogoClientes formCatalogoClientes = new Form_CatalogoClientes();
                formCatalogoClientes.ShowDialog();
            }
        }

        void IDetalleClienteController.ConsultaCliente(Cliente objCliente)
        {
            txtIdCliente.Text = objCliente.Id.ToString();
            txtDetalleNombre.Text = objCliente.Nombre;
            txtDetallePaterno.Text = objCliente.ApellidoPaterno;
            txtDetalleMaterno.Text = objCliente.ApellidoMaterno;
            txtDetalleRFC.Text = objCliente.RFC;
        }

        private void Form_detalleCliente_KeyDown(object sender, KeyEventArgs e)
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
