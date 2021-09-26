using RedPacifico.Interface;
using RedPacifico.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedPacifico.Controlador
{
    class CatalogoVentaController
    {
        private readonly ICatalogoVentaController _vista;
        private CatalogoVentaModel _model;

        public CatalogoVentaController(ICatalogoVentaController vista)
        {
            _vista = vista;
            _model = new CatalogoVentaModel();
        }

        public void ConsultarCatalogoVentas()
        {
            _vista.ConsultarVentas(_model.ObtenerVentas());
        }
    }
}
