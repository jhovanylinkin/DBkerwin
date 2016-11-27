using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MiTiendita
{
    class conexionSQL
    {
        public static MySqlConnection obtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=mydb; Uid=root; pwd=fundamentos;");
            conectar.Open();
            return conectar;
        }
    }
}
