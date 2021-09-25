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
    class DetalleClienteModel
    {
        public int GrabarCliente(string nombre, string apellidoPat, string apellidoMat, string RFC)
        {
            int grabado = 0;
            try
            {
                using (sistemaEntities1 db = new sistemaEntities1())
                {
                    clientes oCliente = new clientes
                    {
                        nombre = nombre,
                        apellidoPaterno = apellidoPat,
                        apellidoMaterno = apellidoMat,
                        RFC = RFC
                    };

                    db.clientes.Add(oCliente);
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

        public Cliente DetalleCliente(int idCliente)
        {
            Cliente obCliente = new Cliente();
            try
            {
                using (sistemaEntities1 db = new sistemaEntities1())
                {
                    var cliente = db.clientes.Find(idCliente);

                    obCliente.Id = int.Parse(cliente.id.ToString());
                    obCliente.Nombre = cliente.nombre;
                    obCliente.ApellidoPaterno = cliente.apellidoPaterno;
                    obCliente.ApellidoMaterno = cliente.apellidoMaterno;
                    obCliente.RFC = cliente.RFC;
                }
            }
            catch (Exception)
            {

                throw;
            }


            return obCliente;
        }

        public Boolean ActualizarDatos(int idCliente, string nombre, string apellidoPat, string apellidoMat, string RFC)
        {
            bool actualizoCliente = false;
            try
            {
                using (sistemaEntities1 db = new sistemaEntities1())
                {
                    var cliente = db.clientes.Find(idCliente);

                    cliente.nombre = nombre;
                    cliente.apellidoPaterno = apellidoPat;
                    cliente.apellidoMaterno = apellidoMat;
                    cliente.RFC = RFC;

                    db.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    actualizoCliente = true;
                }
            }
            catch (Exception)
            {

                throw;
            }

            return actualizoCliente;
        }
    }
}
