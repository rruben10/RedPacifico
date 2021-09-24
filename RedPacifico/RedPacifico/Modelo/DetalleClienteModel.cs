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
                using (sistemaEntities db = new sistemaEntities())
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
                using (sistemaEntities db = new sistemaEntities())
                {
                    var cliente = db.clientes.Find(idCliente);

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
    }
}
