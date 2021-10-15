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
    class CatalogoVentaModel
    {
        /// <summary>
        /// se consume servicio para obtener las ventas
        /// </summary>
        /// <returns></returns>
        public List<Venta> ObtenerVentas()
        {
            List<Venta> listaVentas = new List<Venta>();

            try
            {
                var client = new RestClient("http://localhost:59384/api/ventas"); //La url deberia de ser obtenida desde una bd para traer el DNS/Servidor y la URL
                client.Timeout = -1;
                var request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);
                var responseContent = JsonConvert.DeserializeObject<IEnumerable<Venta>>(response.Content);
                foreach (var oVenta in responseContent)
                {
                    Venta venta = new Venta
                    {
                        Id = oVenta.Id,
                        Cliente = Convert.ToInt64(oVenta.Cliente),
                        Producto = Convert.ToInt64(oVenta.Producto),
                        Enganche = oVenta.Enganche,
                        BonificacionEnganche = oVenta.BonificacionEnganche,
                        Total = oVenta.Total
                    };
                    listaVentas.Add(venta);
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
