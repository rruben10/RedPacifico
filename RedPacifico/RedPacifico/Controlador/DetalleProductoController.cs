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
        private DetalleProductoModel _model;
        public DetalleProductoController(IDetalleProductoController vista)
        {
            _vista = vista;
            _model = new DetalleProductoModel();
        }
        public void GuardarProducto()
        {
            _vista.GuardarRegistro(_model.GrabarProducto(_vista.DescripcionProducto, _vista.ModeloProducto, _vista.PrecioProducto, _vista.ExistenciaProducto));
        }

        public void ConsultaProducto(int idProducto)
        {
            _vista.ConsultaProducto(_model.DetalleProducto(idProducto));
        }

        public Boolean ActualizarDatosProducto()
        {
            bool actualizoProducto = false;
            actualizoProducto = (_model.ActualizarProducto(_vista.IdProducto, _vista.DescripcionProducto, _vista.ModeloProducto, _vista.PrecioProducto, _vista.ExistenciaProducto));
            
            return actualizoProducto;
        }
    }
}
