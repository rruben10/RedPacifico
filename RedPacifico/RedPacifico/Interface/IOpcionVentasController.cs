using RedPacifico.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedPacifico.Interface
{
    interface IOpcionVentasController
    {
        string NombreCliente { get; set; }
        string NombreProducto { get; set; }
        string Enganche { get; set; }
        string BonificacionEnganche { get; set; }
        string Total { get; set; }
        void ConsultaProducto(Producto producto);
    }
}
