﻿using RedPacifico.Entidades;
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
    public partial class Form_detalleProducto : Form, IDetalleProductoController
    {
        private Controlador.DetalleProductoController _controlador;
        public Form_detalleProducto()
        {
            InitializeComponent();
            _controlador = new Controlador.DetalleProductoController(this);
        }

        public Form_detalleProducto(int idProducto)
        {
            InitializeComponent();
            _controlador = new Controlador.DetalleProductoController(this);

            _controlador.ConsultaProducto(idProducto);

            this.btnDetalleGuardar.Text = "Actualizar";
        }

        public int IdProducto { get => int.Parse(txtIdProducto.Text); set => IdProducto = value; }
        public string DescripcionProducto { get => txtProductoDes.Text; set => DescripcionProducto = value; }
        public string ModeloProducto { get => txtProductoModelo.Text; set => ModeloProducto = value; }
        public int PrecioProducto { get => int.Parse(txtProductoPrecio.Text); set => PrecioProducto = value; }
        public int ExistenciaProducto { get => int.Parse(txtProductoExistencia.Text); set => ExistenciaProducto = value; }

        void IDetalleProductoController.ConsultaProducto(Producto objProducto)
        {
            txtIdProducto.Text = objProducto.IdProducto.ToString();
            txtProductoDes.Text = objProducto.Descripcion;
            txtProductoModelo.Text = objProducto.Modelo;
            txtProductoPrecio.Text = objProducto.Precio.ToString();
            txtProductoExistencia.Text = objProducto.Existencia.ToString();
        }

        public void GuardarRegistro(int grabado)
        {
            if (grabado == 1)
            {
                MessageBox.Show("El Producto ha sido registrado correctamente");

                this.Close();

                Form_catalogoProductos formCatalogoProductos = new Form_catalogoProductos();
                formCatalogoProductos.ShowDialog();
            }
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
                if (_controlador.ActualizarDatosProducto())
                {
                    MessageBox.Show("Se actualizaron los datos correctamente.");
                    this.Close();
                    Form_catalogoProductos catalogo = new Form_catalogoProductos();
                    catalogo.ShowDialog();
                }
            }
            else
            {
                _controlador.GuardarProducto();
            }
        }
        string ValidarDatosCapturados()
        {
            inicializarErrorProviderCampos();

            string MensajeCamposInvalidos = string.Empty;

            if (txtProductoDes.Text == "")
            {
                errorCampoValido.SetError(txtProductoDes, "Ingresar Descripcion");
                MensajeCamposInvalidos = string.Format("Favor de ingresar {0} es obligatorio", lblProductoDes.Text);
                return MensajeCamposInvalidos;
            }
            if (txtProductoModelo.Text == "")
            {
                errorCampoValido.SetError(txtProductoModelo, "Ingresar Modelo");
                MensajeCamposInvalidos = string.Format("Favor de ingresar {0} es obligatorio", lblProductoModelo.Text);
                return MensajeCamposInvalidos;
            }
            if (txtProductoPrecio.Text == "")
            {
                errorCampoValido.SetError(txtProductoPrecio, "Ingresar Precio");
                MensajeCamposInvalidos = string.Format("Favor de ingresar {0} es obligatorio", lblProductoPrecio.Text);
                return MensajeCamposInvalidos;
            }
            if (txtProductoExistencia.Text == "")
            {
                errorCampoValido.SetError(txtProductoExistencia, "Ingresar Existencia");
                MensajeCamposInvalidos = string.Format("Favor de ingresar {0} es obligatorio", lblProductoExistencia.Text);
                return MensajeCamposInvalidos;
            }

            return MensajeCamposInvalidos;
        }
        private void inicializarErrorProviderCampos()
        {
            errorCampoValido.SetError(txtProductoDes, "");
            errorCampoValido.SetError(txtProductoModelo, "");
            errorCampoValido.SetError(txtProductoPrecio, "");
            errorCampoValido.SetError(txtProductoExistencia, "");
        }

        private void Form_detalleProducto_KeyDown(object sender, KeyEventArgs e)
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
        private void validarCampoNumerico(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtProductoPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarCampoNumerico(sender, e);
        }

        private void txtProductoExistencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarCampoNumerico(sender, e);
        }

        private void txtProductoDes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
