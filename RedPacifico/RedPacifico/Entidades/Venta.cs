using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedPacifico.Entidades
{
    class Venta
    {
        public long IdVenta { get; set; }
        public long Cliente { get; set; }
        public long Producto { get; set; }
        public string DescProduc { get; set; }
        public string ModeloProduc { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }
        public int Importe { get; set; }
    }
}
