using RedPacifico.Entidades;
using RedPacifico.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedPacifico.Modelo
{
    class CatalogoClienteModel
    {
        public List<Cliente> ObtenerClientes()
        {
            List<Cliente> listaClientes = new List<Cliente>();

            try
            {
                //Se hace conexion a la bd
                using (sistemaEntities db = new sistemaEntities())
                {
                    //Se hace una lista de la consulta completa de la tabla clientes
                    var listaSqlCliente = db.clientes.ToList();

                    //Se recorre la lista con los clientes
                    foreach (var oCliente in listaSqlCliente)
                    {
                        //Se agrega a un objeto cada cliente para una lista del tipo List<Cliente>
                        Cliente ObjCliente = new Cliente
                        {
                            Id = Convert.ToInt32(oCliente.id),
                            Nombre = oCliente.nombre,
                            ApellidoPaterno = oCliente.apellidoPaterno,
                            ApellidoMaterno = oCliente.apellidoMaterno,
                            RFC = oCliente.RFC
                        };

                        listaClientes.Add(ObjCliente);
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return listaClientes;
        }
    }
}
