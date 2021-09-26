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

namespace RedPacifico.Vista
{
    public partial class Form_CatalogoVentas : Form, ICatalogoVentaController
    {
        private Controlador.CatalogoVentaController _controlador;
        public Form_CatalogoVentas()
        {
            InitializeComponent();
            _controlador = new Controlador.CatalogoVentaController(this);
            MostrarVentas();
        }

        void ICatalogoVentaController.ConsultarVentas(List<Venta> listVentas)
        {
            try
            {
                gridCatalogoVentas.Rows.Clear();

                foreach (Venta ventas in listVentas)
                {
                    gridCatalogoVentas.Rows.Add(ventas.IdVenta, ventas.Cliente, ventas.Producto, ventas.DescProduc, ventas.ModeloProduc, ventas.Cantidad, ventas.Precio, ventas.Importe);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void MostrarVentas()
        {
            _controlador.ConsultarCatalogoVentas();
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            Form_opcionVentas NuevaVenta = new Form_opcionVentas();
            NuevaVenta.ShowDialog();
        }
    }
}
