using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace RedPacifico.MySql
{
    class Conexion
    {
        public static MySqlConnection obtenerConexion()
        {
            MySqlConnection conexion = new MySqlConnection("server=localhost;database=sistema;integrated security=true;Uid=root;pwd=root;");
            conexion.Open();
            return conexion;
        }
    }
}
