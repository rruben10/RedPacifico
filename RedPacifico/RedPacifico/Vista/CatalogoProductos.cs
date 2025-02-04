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
    public partial class Form_catalogoProductos : Form, ICatalogoProductoController
    {
        private Controlador.CatalogoProductoController _controlador;
        public Form_catalogoProductos()
        {
            InitializeComponent();
            _controlador = new Controlador.CatalogoProductoController(this);
            MostrarProductos();
        }
        /// <summary>
        /// Se consultan los productos existentes
        /// </summary>
        /// <param name="listProductos">lista con los productos, se llena desde el modelo mediante la interfaz</param>
        void ICatalogoProductoController.ConsultaProductos(List<Producto> listProductos)
        {
            try
            {
                gridCatalogoProductos.Rows.Clear();

                foreach (Producto producto in listProductos)
                {
                    gridCatalogoProductos.Rows.Add(producto.Id, producto.Descripcion);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Se manda llamar el controlador para consultar los productos
        /// </summary>
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
        /// <summary>
        /// Metodo para validar cuando se da clic en editar articulo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void Form_catalogoProductos_KeyDown(object sender, KeyEventArgs e)
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
