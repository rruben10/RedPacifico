using MySql.Data.MySqlClient;
using RedPacifico.Entidades;
using RedPacifico.Interface;
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
    public partial class Form_catalogoClientes : Form, ICatalogoClienteController
    {
        MySqlConnection conexion = Conexion.obtenerConexion();
        private Controlador.CatalogoClienteController _controlador;
        public Form_catalogoClientes()
        {
            InitializeComponent();
            _controlador = new Controlador.CatalogoClienteController(this);
            MostrarClientes();
        }

        void ICatalogoClienteController.ConsultaClientes(List<Cliente> listClientes)
        {
            try
            {
                gridCatalogoClientes.Rows.Clear();

                foreach(Cliente cliente in listClientes)
                {
                    string nombreCompleto = cliente.Nombre +" "+ cliente.ApellidoMaterno +" "+ cliente.ApellidoMaterno;
                    gridCatalogoClientes.Rows.Add(cliente.Id, nombreCompleto);
                }

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void MostrarClientes()
        {
            _controlador.ConsultarCatalogoClientes();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            Form_detalleCliente detalleCliente = new Form_detalleCliente();
            detalleCliente.ShowDialog();
        }
    }
}
