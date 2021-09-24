using RedPacifico.Interface;
using RedPacifico.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedPacifico.Controlador
{
    class DetalleClienteController
    {
        private readonly IDetalleClienteController _vista;
        private DetalleClienteModel _model;

        public DetalleClienteController(IDetalleClienteController vista)
        {
            _vista = vista;
            _model = new DetalleClienteModel();
        }

        public void GuardarCliente()
        {
            _vista.GuardarRegistro(_model.GrabarCliente(_vista.DetalleNombre, _vista.DetalleApePaterno, _vista.DetalleApeMaterno, _vista.DetalleRFC));
        }

        public void ConsultaCliente(int idCliente)
        {
            _vista.ConsultaClientes(_model.DetalleCliente(idCliente));
        }
    }
}
