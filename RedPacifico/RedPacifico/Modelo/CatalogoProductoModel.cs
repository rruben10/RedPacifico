using RedPacifico.Entidades;
using RedPacifico.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedPacifico.Modelo
{
    class CatalogoProductoModel
    {
        public List<Producto> ObtenerProductos()
        {
            List<Producto> listaProductos = new List<Producto>();

            try
            {
                //Se hace conexion a la bd
                using (sistemaEntities1 db = new sistemaEntities1())
                {
                    //Se hace una lista de la consulta completa de la tabla clientes
                    var listaSqlCliente = db.productos.ToList();

                    //Se recorre la lista con los clientes
                    foreach (var oProducto in listaSqlCliente)
                    {
                        //Se agrega a un objeto cada cliente para una lista del tipo List<Cliente>
                        Producto objProducto = new Producto
                        {
                            IdProducto = Convert.ToInt32(oProducto.id),
                            Descripcion = oProducto.descripcion,
                            Modelo = oProducto.modelo,
                            Precio = oProducto.precio,
                            Existencia = oProducto.existencia
                        };

                        listaProductos.Add(objProducto);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listaProductos;
        }
    }
}
