using RedPacifico.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedPacifico.Interface
{
    interface IDetalleProductoController
    {
        int IdProducto { get; set; }
        string DescripcionProducto { get; set; }
        string ModeloProducto { get; set; }
        int PrecioProducto { get; set; }
        int ExistenciaProducto { get; set; }

        void GuardarRegistro(int grabado);
        void ConsultaProducto(Producto objProducto);
    }
}
