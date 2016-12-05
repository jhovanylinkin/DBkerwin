using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MiTiendita
{
   public class ComprasIME
    {
        public static List<ComprasC> obtenerComprasUltimoID()
        {

            List<ComprasC> _UltimoID = new List<ComprasC>();
            MySqlConnection conexion = conexionSQL.obtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("select max(idcompras) from compras"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                ComprasC compCompras = new ComprasC();
                compCompras.idcompras = _reader.GetInt32(0);
                _UltimoID.Add(compCompras);
            }
            conexion.Close();
            return _UltimoID;
        }
    }
}
