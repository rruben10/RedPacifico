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
    class CatalogoProductoModel
    {
        /// <summary>
        /// se consume servicio para obtener los productos
        /// </summary>
        /// <returns></returns>
        public List<Producto> ObtenerProductos()
        {
            List<Producto> listaProductos = new List<Producto>();

            try
            {
                //
                var client = new RestClient("http://localhost:59384/api/productos"); //La url deberia de ser obtenida desde una bd para traer el DNS/Servidor y la URL
                client.Timeout = -1;
                var request = new RestRequest(Method.GET);
                request.AddHeader("Content-Type", "application/json");
                IRestResponse response = client.Execute(request);
                var responseContent = JsonConvert.DeserializeObject<IEnumerable<Producto>>(response.Content);
                foreach (var oProducto in responseContent)
                {
                    Producto producto = new Producto
                    {
                        Id = Convert.ToInt32(oProducto.Id),
                        Descripcion = oProducto.Descripcion,
                        Modelo = oProducto.Modelo,
                        Precio = oProducto.Precio,
                        Existencia = oProducto.Existencia
                    };
                    listaProductos.Add(producto);
                }
                //
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listaProductos;
        }
    }
}
