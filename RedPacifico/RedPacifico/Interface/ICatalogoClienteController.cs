﻿using RedPacifico.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedPacifico.Interface
{
    interface ICatalogoClienteController
    {
        void ConsultaClientes(List<Cliente> listClientes);
    }
}
