using RedPacifico.Interface;
using RedPacifico.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedPacifico.Controlador
{
    class CatalogoConfiguracionController
    {
        private readonly ICatalogoConfiguracionController _vista;
        private CatalogoConfiguracionModel _model;

        public CatalogoConfiguracionController(ICatalogoConfiguracionController vista)
        {
            _vista = vista;
            _model = new CatalogoConfiguracionModel();
        }

        public void ConsultaConfiguracion()
        {
            _vista.ConsultaConfiguracion(_model.ObtenerConfiguracion());
        }

        public bool ModificarConfiguracion()
        {
            bool respuesta = false;
            if(_model.ModificarConfiguracion(_vista.IdConfig, _vista.TasaFinanciamiento, _vista.PorcentajeEnganche, _vista.Plazo))
            {
                respuesta = true;
            }
            return respuesta;
        }
    }
}
