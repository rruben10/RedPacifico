using RedPacifico.MySql;
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
    public partial class Form_sistemaOpciones : Form
    {
        public Form_sistemaOpciones()
        {
            InitializeComponent();
        }

        private void boton_ventas_Click(object sender, EventArgs e)
        {
            Form_opcionVentas ventas = new Form_opcionVentas();
            ventas.ShowDialog();
        }

        private void boton_clientes_Click(object sender, EventArgs e)
        {
            Form_catalogoClientes clientes = new Form_catalogoClientes();
            clientes.ShowDialog();
        }

        private void boton_productos_Click(object sender, EventArgs e)
        {
            Form_catalogoProductos productos = new Form_catalogoProductos();
            productos.ShowDialog();
        }

        private void boton_configuracion_Click(object sender, EventArgs e)
        {
            Form_catalogoConfiguracion configuracion = new Form_catalogoConfiguracion();
            configuracion.ShowDialog();
        }

        private void btnConexion_Click(object sender, EventArgs e)
        {
            Conexion.obtenerConexion();
            MessageBox.Show("Se conecto");
        }
    }
}
