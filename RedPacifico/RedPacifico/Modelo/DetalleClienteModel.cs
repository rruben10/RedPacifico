using Newtonsoft.Json;
using RedPacifico.Entidades;
using RedPacifico.Entity;
using RestSharp;
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
        /// <summary>
        /// se consume servicio para grabar cliente nuevo
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellidoPat"></param>
        /// <param name="apellidoMat"></param>
        /// <param name="RFC"></param>
        /// <returns></returns>
        public int GrabarCliente(string nombre, string apellidoPat, string apellidoMat, string RFC)
        {
            int grabado = 0;
            try
            {
                var client = new RestClient("http://localhost:59384/api/clientes"); //La url deberia de ser obtenida desde una bd para traer el DNS/Servidor y la URL
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/json");

                Cliente cliente = new Cliente()
                {
                    Nombre = nombre,
                    ApellidoPaterno = apellidoPat,
                    ApellidoMaterno = apellidoMat,
                    RFC = RFC
                };

                var body = JsonConvert.SerializeObject(cliente);

                request.AddParameter("application/json", body, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    grabado = 1;
                }
            }
            catch (Exception)
            {

                throw;
            }

            return grabado;
        }
        /// <summary>
        /// se consume servicio para obtener informacion del cliente
        /// </summary>
        /// <param name="idCliente"></param>
        /// <returns></returns>
        public Cliente DetalleCliente(int idCliente)
        {
            Cliente obCliente = new Cliente();
            try
            {
                var client = new RestClient("http://localhost:59384/api/clientes?id="+ idCliente); //La url deberia de ser obtenida desde una bd para traer el DNS/Servidor y la URL
                client.Timeout = -1;
                var request = new RestRequest(Method.GET);
                request.AddHeader("Content-Type", "application/json");
                IRestResponse response = client.Execute(request);
                obCliente = JsonConvert.DeserializeObject<Cliente>(response.Content);
            }
            catch (Exception)
            {

                throw;
            }

            return obCliente;
        }
        /// <summary>
        /// se consume servicio para actualizar datos del cliente
        /// </summary>
        /// <param name="idCliente"></param>
        /// <param name="nombre"></param>
        /// <param name="apellidoPat"></param>
        /// <param name="apellidoMat"></param>
        /// <param name="RFC"></param>
        /// <returns></returns>
        public Boolean ActualizarDatos(int idCliente, string nombre, string apellidoPat, string apellidoMat, string RFC)
        {
            bool actualizoCliente = false;
            try
            {
                var client = new RestClient("http://localhost:59384/api/clientes?id="+ idCliente); //La url deberia de ser obtenida desde una bd para traer el DNS/Servidor y la URL
                client.Timeout = -1;
                var request = new RestRequest(Method.PUT);
                request.AddHeader("Content-Type", "application/json");

                Cliente cliente = new Cliente()
                {
                    Id = idCliente,
                    Nombre = nombre,
                    ApellidoPaterno = apellidoPat,
                    ApellidoMaterno = apellidoMat,
                    RFC = RFC
                };

                var body = JsonConvert.SerializeObject(cliente);

                request.AddParameter("application/json", body, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);

                if (response.IsSuccessful)
                {
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
