using RedPacifico.Entidades;
using RedPacifico.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedPacifico.Modelo
{
    class CatalogoVentaModel
    {
        public List<Venta> ObtenerVentas()
        {
            List<Venta> listaVentas = new List<Venta>();

            try
            {
                //Se hace conexion a la bd
                using (sistemaEntities2 db = new sistemaEntities2())
                {
                    //Se hace una lista de la consulta completa de la tabla ventas
                    var listaSqlVentas = db.ventas.ToList();

                    //Se recorre la lista con las ventas
                    foreach (var oVenta in listaSqlVentas)
                    {
                        var detalleProducto = db.productos.Find(oVenta.producto);

                        //Se agrega a un objeto cada venta para una lista del tipo List<Venta>
                        Venta objVenta = new Venta
                        {
                            IdVenta = oVenta.id,
                            Cliente = Convert.ToInt64(oVenta.cliente),
                            Producto = Convert.ToInt64(oVenta.producto),
                            DescProduc = detalleProducto.descripcion,
                            ModeloProduc = detalleProducto.modelo,
                            Cantidad = oVenta.cantidad,
                            Precio = oVenta.precio,
                            Importe = oVenta.importe
                        };

                        listaVentas.Add(objVenta);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listaVentas;
        }
    }
}
