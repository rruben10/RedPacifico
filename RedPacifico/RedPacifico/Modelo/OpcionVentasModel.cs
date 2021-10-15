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
    class OpcionVentasModel
    {
        /// <summary>
        /// se consume servicio para obtener informacion del producto
        /// </summary>
        /// <param name="NombreProducto"></param>
        /// <returns></returns>
        public Producto ObtenerProducto(string NombreProducto)
        {
            Producto objProducto = new Producto();
            try
            {
                if (NombreProducto != "" && NombreProducto.Contains("|"))
                {
                    int idProducto = int.Parse(NombreProducto.Split('|')[1]);

                    var client = new RestClient("http://localhost:59384/api/productos?id=" + idProducto); //La url deberia de ser obtenida desde una bd para traer el DNS/Servidor y la URL
                    client.Timeout = -1;
                    var request = new RestRequest(Method.GET);
                    request.AddHeader("Content-Type", "application/json");
                    IRestResponse response = client.Execute(request);
                    objProducto = JsonConvert.DeserializeObject<Producto>(response.Content);
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
        /// <summary>
        /// se consume servicio para obtener la configuracion
        /// </summary>
        /// <returns></returns>
        public Configuracion ObtenerConfig()
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
            catch (Exception e)
            {

                throw e;
            }
            return conf;
        }
        /// <summary>
        /// se consume servicio para grabar la venta
        /// </summary>
        /// <param name="idCliente"></param>
        /// <param name="idProducto"></param>
        /// <param name="enganche"></param>
        /// <param name="bonificacionEnganche"></param>
        /// <param name="Total"></param>
        /// <returns></returns>
        public int GrabarVenta(string idCliente, string idProducto, string enganche, string bonificacionEnganche, string Total)
        {
            int grabo = 0;
            try
            {
                if (idCliente.Contains("|") && idProducto.Contains("|"))
                {
                    int idClient = int.Parse(idCliente.Split('|')[1]); //obtengo el ID del mismo textbox
                    int idProduct = int.Parse(idProducto.Split('|')[1]); //obtengo el ID del mismo textbox

                    //
                    var client = new RestClient("http://localhost:59384/api/ventas"); //La url deberia de ser obtenida desde una bd para traer el DNS/Servidor y la URL
                    client.Timeout = -1;
                    var request = new RestRequest(Method.POST);
                    request.AddHeader("Content-Type", "application/json");

                    Venta venta = new Venta()
                    {
                        Cliente = idClient,
                        Producto = idProduct,
                        Enganche = int.Parse(enganche),
                        BonificacionEnganche = int.Parse(bonificacionEnganche),
                        Total = int.Parse(Total)
                    };

                    var body = JsonConvert.SerializeObject(venta);

                    request.AddParameter("application/json", body, ParameterType.RequestBody);
                    IRestResponse response = client.Execute(request);

                    if (response.IsSuccessful)
                    {
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
