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

        }

        public int IdProducto { get => int.Parse(txtIdProducto.Text); set => IdProducto = value; }
        public string DescripcionProducto { get => txtProductoDes.Text; set => DescripcionProducto = value; }
        public string ModeloProducto { get => txtProductoModelo.Text; set => ModeloProducto = value; }
        public int PrecioProducto { get => int.Parse(txtProductoPrecio.Text); set => PrecioProducto = value; }
        public int ExistenciaProducto { get => int.Parse(txtProductoExistencia.Text); set => ExistenciaProducto = value; }

        public void ConsultaProducto(Producto objProducto)
        {
            throw new NotImplementedException();
        }

        public void GuardarRegistro(int grabado)
        {
            throw new NotImplementedException();
        }
    }
}
