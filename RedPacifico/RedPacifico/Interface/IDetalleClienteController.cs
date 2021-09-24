using RedPacifico.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedPacifico.Interface
{
    interface IDetalleClienteController
    {
        string DetalleNombre { get; set; }
        string DetalleApePaterno { get; set; }
        string DetalleApeMaterno { get; set; }
        string DetalleRFC { get; set; }
        //int IdCliente { get; set; }

        void GuardarRegistro(int grabado);
        void ConsultaClientes(Cliente objCliente);
    }
}
