using RedPacifico.Entidades;
using RedPacifico.Interface;
using RedPacifico.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedPacifico.Controlador
{
    class OpcionVentasController
    {
        private readonly IOpcionVentasController _vista;
        private OpcionVentasModel _model;

        public OpcionVentasController(IOpcionVentasController vista)
        {
            _vista = vista;
            _model = new OpcionVentasModel();
        }
        public void ConsultaProducto()
        {
            _vista.ConsultaProducto(_model.ObtenerProducto(_vista.NombreProducto));
        }

        public Configuracion ConsultaConfig()
        {
            //intelligy me recomendo instanciar asi
            _ = new Configuracion();
            return _ = _model.ObtenerConfig();
        }
        public int GuardarVenta()
        {
            int grabo = _model.GrabarVenta(_vista.NombreCliente, _vista.NombreProducto, _vista.Enganche, _vista.BonificacionEnganche, _vista.Total);
            return grabo;
        }
    }
}
