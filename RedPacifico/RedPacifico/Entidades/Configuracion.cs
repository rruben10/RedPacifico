using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedPacifico.Entidades
{
    class Configuracion
    {
        public int IdConfiguracion { get; set; }
        public float TasaFinanciamiento { get; set; }
        public float PorcentajeEnganche { get; set; }
        public short Plazo { get; set; }
    }
}
