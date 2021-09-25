using RedPacifico.Interface;
using RedPacifico.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedPacifico.Controlador
{
    class CatalogoProductoController
    {
        private readonly ICatalogoProductoController _vista;
        private CatalogoProductoModel _model;
        public CatalogoProductoController(ICatalogoProductoController vista)
        {
            _vista = vista;
            _model = new CatalogoProductoModel();
        }

        public void ConsultarCatalogoProductos()
        {
            _vista.ConsultaProductos(_model.ObtenerProductos());
        }

    }
}
