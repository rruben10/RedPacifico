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
    class DetalleProductoModel
    {
        /// <summary>
        /// se consume servicio para grabar un producto
        /// </summary>
        /// <param name="descripcion"></param>
        /// <param name="modelo"></param>
        /// <param name="precio"></param>
        /// <param name="existencia"></param>
        /// <returns></returns>
        public int GrabarProducto(string descripcion, string modelo, int precio, int existencia)
        {
            int grabado = 0;
            try
            {
                var client = new RestClient("http://localhost:59384/api/productos");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/json");

                Producto producto = new Producto()
                {
                    Descripcion = descripcion,
                    Modelo = modelo,
                    Precio = precio,
                    Existencia = existencia
                };

                var body = JsonConvert.SerializeObject(producto);

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
        /// se consume servicio para obtener informacion del producto
        /// </summary>
        /// <param name="idProducto"></param>
        /// <returns></returns>
        public Producto DetalleProducto(int idProducto)
        {
            Producto objProducto = new Producto();
            try
            {
                var client = new RestClient("http://localhost:59384/api/productos?id="+ idProducto); //La url deberia de ser obtenida desde una bd para traer el DNS/Servidor y la URL
                client.Timeout = -1;
                var request = new RestRequest(Method.GET);
                request.AddHeader("Content-Type", "application/json");
                IRestResponse response = client.Execute(request);
                objProducto = JsonConvert.DeserializeObject<Producto>(response.Content);
            }
            catch (Exception)
            {
                throw;
            }

            return objProducto;
        }
        /// <summary>
        /// se consume servicio para actualizar informacion del producto
        /// </summary>
        /// <param name="idProducto"></param>
        /// <param name="descripcion"></param>
        /// <param name="modelo"></param>
        /// <param name="precio"></param>
        /// <param name="existencia"></param>
        /// <returns></returns>
        public Boolean ActualizarProducto(int idProducto, string descripcion, string modelo, int precio, int existencia)
        {
            bool actualizoProducto = false;
            try
            {
                var client = new RestClient("http://localhost:59384/api/productos?id="+ idProducto); //La url deberia de ser obtenida desde una bd para traer el DNS/Servidor y la URL
                client.Timeout = -1;
                var request = new RestRequest(Method.PUT);
                request.AddHeader("Content-Type", "application/json");

                Producto producto = new Producto()
                {
                    Id = idProducto,
                    Descripcion = descripcion,
                    Modelo = modelo,
                    Precio = precio,
                    Existencia = existencia
                };

                var body = JsonConvert.SerializeObject(producto);

                request.AddParameter("application/json", body, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);

                if (response.IsSuccessful)
                {
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
