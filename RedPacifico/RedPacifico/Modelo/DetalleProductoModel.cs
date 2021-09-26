using RedPacifico.Entidades;
using RedPacifico.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedPacifico.Modelo
{
    class DetalleProductoModel
    {
        public int GrabarProducto(string descripcion, string modelo, int precio, int existencia)
        {
            int grabado = 0;
            try
            {
                using (sistemaEntities1 db = new sistemaEntities1())
                {
                    productos objProducto = new productos
                    {
                        descripcion = descripcion,
                        modelo = modelo,
                        precio = precio,
                        existencia = short.Parse(existencia.ToString())
                    };

                    db.productos.Add(objProducto);
                    db.SaveChanges();
                    grabado = 1;

                }
            }
            catch (Exception)
            {

                throw;
            }

            return grabado;
        }

        public Producto DetalleProducto(int idProducto)
        {
            Producto objProducto = new Producto();
            try
            {
                using (sistemaEntities1 db = new sistemaEntities1())
                {
                    var producto = db.productos.Find(idProducto);

                    objProducto.IdProducto = int.Parse(producto.id.ToString());
                    objProducto.Descripcion = producto.descripcion;
                    objProducto.Modelo = producto.modelo;
                    objProducto.Precio = producto.precio;
                    objProducto.Existencia = producto.existencia;
                }
            }
            catch (Exception)
            {

                throw;
            }


            return objProducto;
        }

        public Boolean ActualizarProducto(int idProducto, string descripcion, string modelo, int precio, int existencia)
        {
            bool actualizoProducto = false;
            try
            {
                using (sistemaEntities1 db = new sistemaEntities1())
                {
                    var producto = db.productos.Find(idProducto);

                    producto.descripcion = descripcion;
                    producto.modelo = modelo;
                    producto.precio = precio;
                    producto.existencia = short.Parse(existencia.ToString());

                    db.Entry(producto).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    actualizoProducto = true;
                }
            }
            catch (Exception)
            {

                throw;
            }

            return actualizoProducto;
        }
    }
}
