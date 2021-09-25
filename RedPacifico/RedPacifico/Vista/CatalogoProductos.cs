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
    public partial class Form_catalogoProductos : Form, ICatalogoProductoController
    {
        private Controlador.CatalogoProductoController _controlador;
        public Form_catalogoProductos()
        {
            InitializeComponent();
            _controlador = new Controlador.CatalogoProductoController(this);
            MostrarProductos();
        }

        void ICatalogoProductoController.ConsultaProductos(List<Producto> listProductos)
        {
            try
            {
                gridCatalogoProductos.Rows.Clear();

                foreach (Producto producto in listProductos)
                {
                    gridCatalogoProductos.Rows.Add(producto.IdProducto, producto.Descripcion);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void MostrarProductos()
        {
            _controlador.ConsultarCatalogoProductos();
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            Form_detalleProducto detalleProducto = new Form_detalleProducto();
            detalleProducto.ShowDialog();

            this.Close();
        }

        private void gridCatalogoProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridCatalogoProductos.Columns[e.ColumnIndex].Name == "columEditar")
            {
                int idProducto = int.Parse(gridCatalogoProductos.Rows[e.RowIndex].Cells[0].Value.ToString());

                Form_detalleProducto detalleProducto = new Form_detalleProducto(idProducto);
                detalleProducto.ShowDialog();

                this.Close();
            }
        }
    }
}
