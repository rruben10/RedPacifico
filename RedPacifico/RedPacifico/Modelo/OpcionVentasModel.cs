using RedPacifico.Entidades;
using RedPacifico.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedPacifico.Modelo
{
    class OpcionVentasModel
    {
        public Producto ObtenerProducto(string NombreProducto)
        {
            Producto objProducto = new Producto();
            try
            {
                if (NombreProducto != "" && NombreProducto.Contains("|"))
                {
                    int idProducto = int.Parse(NombreProducto.Split('|')[1]);
                    using (sistemaEntities2 db = new sistemaEntities2())
                    {
                        var producto = db.productos.Find(idProducto);

                        objProducto.IdProducto = idProducto;
                        objProducto.Descripcion = producto.descripcion;
                        objProducto.Modelo = producto.modelo;
                        objProducto.Existencia = producto.existencia;
                        objProducto.Precio = producto.precio;
                    }
                }
                else
                {
                    MessageBox.Show("Favor de capturar Producto registrado");
                }
                
            }
            catch (Exception e)
            {
                throw e;
            }

            return objProducto;
        }
        public Configuracion ObtenerConfig()
        {
            Configuracion objConfig = new Configuracion();
            try
            {
                using(sistemaEntities2 db = new sistemaEntities2())
                {
                    var config = db.configuracion.ToList();

                    foreach (var oConfig in config)
                    {
                        objConfig.IdConfiguracion = int.Parse(oConfig.id.ToString());
                        objConfig.TasaFinanciamiento = oConfig.tasa;
                        objConfig.PorcentajeEnganche = oConfig.enganche;
                        objConfig.Plazo = oConfig.plazo;
                    }
                }
            }
            catch (Exception e)
            {

                throw e;
            }
            return objConfig;
        }
        public int GrabarVenta(string idCliente, string idProducto, string enganche, string bonificacionEnganche, string Total)
        {
            int grabo = 0;
            try
            {
                if (idCliente.Contains("|") && idProducto.Contains("|"))
                {
                    int idClient = int.Parse(idCliente.Split('|')[1]); //obtengo el ID del mismo textbox
                    int idProduct = int.Parse(idProducto.Split('|')[1]); //obtengo el ID del mismo textbox
                    using (sistemaEntities2 db = new sistemaEntities2())
                    {
                        ventas oVenta = new ventas
                        {
                            cliente = idClient,
                            producto = idProduct,
                            enganche = int.Parse(enganche),
                            bonificacionEnganche = int.Parse(bonificacionEnganche),
                            total = int.Parse(Total)
                        };

                        db.ventas.Add(oVenta);
                        db.SaveChanges();
                        grabo = 1;
                    }
                }
                else
                {
                    MessageBox.Show("Favor de capturar Cliente / Producto registrado");
                }
                
            }
            catch (Exception)
            {
                throw;
            }
            return grabo;
        }
    }
}
