using MySql.Data.MySqlClient;
using RedPacifico.Entidades;
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
    public partial class Form_opcionVentas : Form
    {
        MySqlConnection conexion = Conexion.obtenerConexion();
        public Form_opcionVentas()
        {
            InitializeComponent();
            AutoCompletarClientes();
            AutoCompletarProductos();

            conexion.Close();
        }


        void AutoCompletarClientes()
        {
            DataTable datosCliente = new DataTable();
            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            MySqlDataAdapter adaptador = new MySqlDataAdapter("CALL proc_consultarclientes()", conexion);

            adaptador.Fill(datosCliente);

            for (int i = 0; i < datosCliente.Rows.Count; i++)
            {
                string nombreCompleto = datosCliente.Rows[i]["nombre"].ToString() + " " + 
                    datosCliente.Rows[i]["apellidoPaterno"].ToString() + " " + 
                    datosCliente.Rows[i]["apellidoMaterno"].ToString();
                lista.Add(nombreCompleto);
            }

            txtCliente.AutoCompleteCustomSource = lista;
        }

        void AutoCompletarProductos()
        {
            DataTable datosProducto = new DataTable();
            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            MySqlDataAdapter adaptador = new MySqlDataAdapter("CALL proc_consultarproductos()", conexion);

            adaptador.Fill(datosProducto);

            for (int i = 0; i < datosProducto.Rows.Count; i++)
            {
                lista.Add(datosProducto.Rows[i]["descripcion"].ToString());
            }

            txtProducto.AutoCompleteCustomSource = lista;
        }
    }
}
