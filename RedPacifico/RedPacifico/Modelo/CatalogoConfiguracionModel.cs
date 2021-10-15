using RedPacifico.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedPacifico.Entity;
using RestSharp;
using Newtonsoft.Json;

namespace RedPacifico.Modelo
{
    class CatalogoConfiguracionModel
    {
        /// <summary>
        /// se consume servicio para obtener la configuracion
        /// </summary>
        /// <returns></returns>
        public Configuracion ObtenerConfiguracion()
        {
            Configuracion conf = new Configuracion();
            try
            {
                var client = new RestClient("http://localhost:59384/api/configuracions"); //La url deberia de ser obtenida desde una bd para traer el DNS/Servidor y la URL
                client.Timeout = -1;
                var request = new RestRequest(Method.GET);
                request.AddHeader("Content-Type", "application/json");
                IRestResponse response = client.Execute(request);
                var responseContent = JsonConvert.DeserializeObject<IEnumerable<Configuracion>>(response.Content);
                foreach (var oConfig in responseContent)
                {
                    conf.Id = int.Parse(oConfig.Id.ToString());
                    conf.Tasa = oConfig.Tasa;
                    conf.Enganche = oConfig.Enganche;
                    conf.Plazo = oConfig.Plazo;   
                }
            }
            catch (Exception)
            {

                throw;
            }
            return conf;
        }
        /// <summary>
        /// se consume servicio para actualizar la configuracion
        /// </summary>
        /// <param name="idConfig"></param>
        /// <param name="tasaFinanciamiento"></param>
        /// <param name="porcentajeEnganche"></param>
        /// <param name="plazo"></param>
        /// <returns></returns>
        public Boolean ModificarConfiguracion(int idConfig, float tasaFinanciamiento, float porcentajeEnganche, short plazo)
        {
            bool graboConfig = false;
            try
            {
                //Modifico decimales a 2
                tasaFinanciamiento = float.Parse(String.Format("{0:0.00}", tasaFinanciamiento));
                porcentajeEnganche = float.Parse(String.Format("{0:0.00}", porcentajeEnganche));
                if (idConfig == 0)
                {
                    var client = new RestClient("http://localhost:59384/api/configuracions"); //La url deberia de ser obtenida desde una bd para traer el DNS/Servidor y la URL
                    client.Timeout = -1;
                    var request = new RestRequest(Method.POST);
                    request.AddHeader("Content-Type", "application/json");

                    Configuracion config = new Configuracion()
                    {
                        Id = idConfig,
                        Tasa = tasaFinanciamiento,
                        Enganche = porcentajeEnganche,
                        Plazo = plazo
                    };

                    var body = JsonConvert.SerializeObject(config);

                    request.AddParameter("application/json", body, ParameterType.RequestBody);
                    IRestResponse response = client.Execute(request);

                    if (response.IsSuccessful)
                    {
                        graboConfig = true;
                    }
                }
                else
                {
                    var client = new RestClient("http://localhost:59384/api/configuracions?id="+ idConfig); //La url deberia de ser obtenida desde una bd para traer el DNS/Servidor y la URL
                    client.Timeout = -1;
                    var request = new RestRequest(Method.PUT);
                    request.AddHeader("Content-Type", "application/json");

                    Configuracion config = new Configuracion()
                    {
                        Id = idConfig,
                        Tasa = tasaFinanciamiento,
                        Enganche = porcentajeEnganche,
                        Plazo = plazo
                    };

                    var body = JsonConvert.SerializeObject(config);

                    request.AddParameter("application/json", body, ParameterType.RequestBody);
                    IRestResponse response = client.Execute(request);
                    
                    if (response.IsSuccessful)
                    {
                        graboConfig = true;
                    }
                }
            }
            catch (Exception e)
            {

                throw e;
            }

            return graboConfig;
        }
    }
}
