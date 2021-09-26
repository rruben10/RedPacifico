using RedPacifico.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedPacifico.Interface
{
    interface ICatalogoConfiguracionController
    {
        int IdConfig { get; set; }
        float TasaFinanciamiento { get; set; }
        float PorcentajeEnganche { get; set; }
        short Plazo { get; set; }
        void ConsultaConfiguracion(Configuracion config);
    }
}
