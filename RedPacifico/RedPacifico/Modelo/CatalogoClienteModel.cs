using Newtonsoft.Json;
using RedPacifico.Entidades;
using RedPacifico.Entity;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedPacifico.Modelo
{
    class CatalogoClienteModel
    {
        /// <summary>
        /// se consume servicio para obtener los clientes
        /// </summary>
        /// <returns></returns>
        public List<Cliente> ObtenerClientes()
        {
            List<Cliente> listaClientes = new List<Cliente>();

            try
            {
                var client = new RestClient("http://localhost:59384/api/clientes"); //La url deberia de ser obtenida desde una bd para traer el DNS/Servidor y la URL
                client.Timeout = -1;
                var request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);
                var responseContent = JsonConvert.DeserializeObject<IEnumerable<Cliente>>(response.Content);
                foreach (var oCliente in responseContent)
                {
                    Cliente cliente = new Cliente
                    {
                        Id = Convert.ToInt32(oCliente.Id),
                        Nombre = oCliente.Nombre,
                        ApellidoPaterno = oCliente.ApellidoPaterno,
                        ApellidoMaterno = oCliente.ApellidoMaterno,
                        RFC = oCliente.RFC
                    };
                    listaClientes.Add(cliente);
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
