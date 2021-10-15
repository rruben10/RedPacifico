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
    public partial class Form_CatalogoClientes : Form, ICatalogoClienteController
    {
        //Conexion a la antigua
        MySqlConnection conexion = Conexion.obtenerConexion();

        private Controlador.CatalogoClienteController _controlador;
        public Form_CatalogoClientes()
        {
            InitializeComponent();
            _controlador = new Controlador.CatalogoClienteController(this);
            MostrarClientes();
        }
        /// <summary>
        /// Se consultan todos los clientes que existen en el sistema para agregarlos al grid
        /// </summary>
        /// <param name="listClientes">lista con la informacion de los clientes, se llena desde el modelo mediante la interfaz</param>

        void ICatalogoClienteController.ConsultaClientes(List<Cliente> listClientes)
        {
            try
            {
                gridCatalogoClientes.Rows.Clear();

                foreach(Cliente cliente in listClientes)
                {
                    string nombreCompleto = cliente.Nombre +" "+ cliente.ApellidoPaterno +" "+ cliente.ApellidoMaterno;
                    gridCatalogoClientes.Rows.Add(cliente.Id, nombreCompleto);
                }

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Se manda llamar el controlador para consultar los clientes
        /// </summary>
        public void MostrarClientes()
        {
            _controlador.ConsultarCatalogoClientes();
        }

        /// <summary>
        /// Se manda llamar vista para "nuevo cliente"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            Form_detalleCliente detalleCliente = new Form_detalleCliente();
            detalleCliente.ShowDialog();

            this.Close();
        }
        /// <summary>
        /// Se identifica cuando se de clic en boton editar cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridCatalogoClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridCatalogoClientes.Columns[e.ColumnIndex].Name == "columEditar")
            {
                int idCliente = int.Parse(gridCatalogoClientes.Rows[e.RowIndex].Cells[0].Value.ToString());

                Form_detalleCliente detalleCliente = new Form_detalleCliente(idCliente);
                detalleCliente.ShowDialog();

                this.Close();
            }
        }
        /// <summary>
        /// Se valida tecla Escape para salir de esta opcion del sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_CatalogoClientes_KeyDown(object sender, KeyEventArgs e)
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
