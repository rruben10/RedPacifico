using RedPacifico.Interface;
using RedPacifico.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedPacifico.Controlador
{
    class CatalogoClienteController
    {
        private readonly ICatalogoClienteController _vista;
        private CatalogoClienteModel _model;

        public CatalogoClienteController(ICatalogoClienteController vista)
        {
            _vista = vista;
            _model = new CatalogoClienteModel();
        }

        public void ConsultarCatalogoClientes()
        {
            _vista.ConsultaClientes(_model.ObtenerClientes());
        }
    }
}
