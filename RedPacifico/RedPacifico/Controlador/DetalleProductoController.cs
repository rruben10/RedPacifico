using RedPacifico.Interface;
using RedPacifico.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedPacifico.Controlador
{
    class DetalleProductoController
    {
        private IDetalleProductoController _vista;
        private DetalleProductoModel _modelo;
        public DetalleProductoController(IDetalleProductoController vista)
        {
            _vista = vista;
            _modelo = new DetalleProductoModel();
        }
    }
}
