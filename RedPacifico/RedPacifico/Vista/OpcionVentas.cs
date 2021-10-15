using MySql.Data.MySqlClient;
using RedPacifico.Entidades;
using RedPacifico.Interface;
using RedPacifico.MySql;
using RedPacifico.Vista;
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
    public partial class Form_opcionVentas : Form, IOpcionVentasController
    {
        MySqlConnection conexion = Conexion.obtenerConexion();
        private Controlador.OpcionVentasController _controlador;
        /// <summary>
        /// variables de control para la vista
        /// </summary>
        public string NombreCliente { get => txtCliente.Text; set => NombreCliente = value; }
        public string NombreProducto { get => txtProducto.Text; set => NombreProducto = value; }
        public string Enganche { get => txtEnganche.Text; set => Enganche = value; }
        public string BonificacionEnganche { get => txtBonificacion.Text; set => BonificacionEnganche = value; }
        public string Total { get => txtTotal.Text; set => Total = value; }

        public Form_opcionVentas()
        {
            InitializeComponent();
            _controlador = new Controlador.OpcionVentasController(this);
            AutoCompletarClientes();
            AutoCompletarProductos();
            conexion.Close();
        }
        /// <summary>
        /// Metodo para realizar el "autocompletado" de la busqueda de clientes
        /// </summary>
        void AutoCompletarClientes()
        {
            DataTable datosCliente = new DataTable();
            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            MySqlDataAdapter adaptador = new MySqlDataAdapter("CALL proc_consultarclientes()", conexion);

            adaptador.Fill(datosCliente);

            for (int i = 0; i < datosCliente.Rows.Count; i++)
            {
                string nombreCompleto =
                    datosCliente.Rows[i]["nombre"].ToString() + " " +
                    datosCliente.Rows[i]["apellidoPaterno"].ToString() + " " +
                    datosCliente.Rows[i]["apellidoMaterno"].ToString() +
                " |" + datosCliente.Rows[i]["id"].ToString() + "|"; //Agregamos el id del cliente
                lista.Add(nombreCompleto);
            }

            txtCliente.AutoCompleteCustomSource = lista;
        }
        /// <summary>
        /// Metodo para realizar el "autocompletado" de la busqueda de producto
        /// </summary>
        void AutoCompletarProductos()
        {
            DataTable datosProducto = new DataTable();
            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            MySqlDataAdapter adaptador = new MySqlDataAdapter("CALL proc_consultarproductos()", conexion);

            adaptador.Fill(datosProducto);

            for (int i = 0; i < datosProducto.Rows.Count; i++)
            {
                string producto =
                    datosProducto.Rows[i]["descripcion"].ToString()+
                    " |" + datosProducto.Rows[i]["id"].ToString() + "|";
                lista.Add(producto);
            }

            txtProducto.AutoCompleteCustomSource = lista;
        }

        private void btnAgregarProductoVenta_Click(object sender, EventArgs e)
        {
            _controlador.ConsultaProducto();
        }
        /// <summary>
        /// obtiene informacion de producto y valida su existencia
        /// </summary>
        /// <param name="producto">objeto con la informacion del producto, se llena desde el modelo mediante la interfaz</param>
        void IOpcionVentasController.ConsultaProducto(Producto producto)
        {
            int cantidad = 1;
            Configuracion config = new Configuracion();
            try
            {
                config = _controlador.ConsultaConfig(); //obtengo las configuraciones para calcular totales
                string mensaje = ValidarDatosCapturados();
                if (mensaje != "")
                {
                    MessageBox.Show(mensaje);
                }
                else
                {
                    if (producto.Existencia <= 0) //valido que el producto tenga existencia
                    {
                        MessageBox.Show("Este producto no tiene existencia");
                        return;
                    }

                    for (int i = 0; i < gridVenta.Rows.Count; i++)
                    {
                        if (producto.Id == int.Parse(gridVenta.Rows[i].Cells[0].Value.ToString()))
                        {
                            cantidad++;
                            //Se elimina producto repetido
                            DataGridViewRow grid = gridVenta.Rows[i];
                            gridVenta.Rows.Remove(grid);
                        }
                    }
                    int precio = (int)(producto.Precio * (1 + config.Tasa * config.Plazo) / 100);
                    int importe = precio * cantidad;

                    gridVenta.Rows.Add(producto.Id, producto.Descripcion, producto.Modelo, cantidad, precio, importe);

                    CalcularTotales();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void btnGuardarVenta_Click(object sender, EventArgs e)
        {
            string mensaje = ValidarDatosCapturados();
            if (mensaje != "")
            {
                MessageBox.Show(mensaje);
            }
            else
            {
                int grabo = _controlador.GuardarVenta();
                if (grabo==1)
                {
                    Form_CatalogoVentas ventas = new Form_CatalogoVentas();
                    ventas.ShowDialog();

                    this.Close();
                }
            }
        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inicializarErrorProviderCampos()
        {
            errorCampoValido.SetError(txtCliente, "");
            errorCampoValido.SetError(txtProducto, "");
        }
        /// <summary>
        /// valida campos capturados
        /// </summary>
        /// <returns></returns>
        private string ValidarDatosCapturados()
        {
            inicializarErrorProviderCampos();

            string MensajeCamposInvalidos = string.Empty;

            if (txtCliente.Text == "")
            {
                errorCampoValido.SetError(txtCliente, "Ingresar Cliente");
                MensajeCamposInvalidos = string.Format("Favor de ingresar {0} es obligatorio", "Cliente");
                return MensajeCamposInvalidos;
            }
            if (txtProducto.Text == "")
            {
                errorCampoValido.SetError(txtProducto, "Ingresar Producto");
                MensajeCamposInvalidos = string.Format("Favor de ingresar {0} es obligatorio", "Producto");
                return MensajeCamposInvalidos;
            }

            return MensajeCamposInvalidos;
        }
        /// <summary>
        /// evento para eliminar un registro del grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridVenta.Columns[e.ColumnIndex].Name == "columEliminar")
            {
                DataGridViewRow grid = gridVenta.Rows[e.RowIndex];
                gridVenta.Rows.Remove(grid);
                CalcularTotales();
            }
        }
        /// <summary>
        /// Calcula y asigna totales
        /// </summary>
        private void CalcularTotales()
        {
            Configuracion config = new Configuracion();
            int importe = 0;
            config = _controlador.ConsultaConfig(); //obtengo las configuraciones para calcular totales

            for (int i = 0; i < gridVenta.Rows.Count; i++)
            {
                //Se suman todos los importes del grid para sacar los totales de la venta
                importe += int.Parse(gridVenta.Rows[i].Cells[5].Value.ToString()); //columna importe
            }

            //Se calculan valores iniciales
            int enganche = (int)(config.Enganche / 100 * importe);
            int bonificacionEnganche = (int)(enganche * (config.Tasa * config.Plazo) / 100);

            //Se ordenan importes para evitar numeros negativos
            var valores = new List<int> { importe, enganche, bonificacionEnganche };
            List<int> importesOrdenados = valores.OrderByDescending(valor => valor).ToList();
            
            //Se calcula el total con numeros ordenados para evitar negativos
            int total = importesOrdenados[0] - importesOrdenados[1] - importesOrdenados[2];

            //Textbox de importes
            txtEnganche.Text = enganche.ToString();
            txtBonificacion.Text = bonificacionEnganche.ToString();
            txtTotal.Text = total.ToString();
        }

        private void Form_opcionVentas_KeyDown(object sender, KeyEventArgs e)
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

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
