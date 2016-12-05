using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MiTiendita
{
    class ProveedoresIME
    {
        public static int AgregarProveedores(Proveedoress provProvedores) //Funcion Agregar a Consola
        {
            int retorno = 0;
            try
            {
                MySqlCommand comando = new MySqlCommand(string.Format("Insert into proveedores (nombreProveedor,rfcProveedor,direccionProveedor,telefonoProveedor) values ('{0}','{1}','{2}','{3}')", provProvedores.nombreProveedor, provProvedores.rfcProveedor, provProvedores.direccionProveedor, provProvedores.telefonoProveedor), conexionSQL.obtenerConexion());
                retorno = comando.ExecuteNonQuery();
                return retorno;
            }
            catch { return 0; }
        }


        public static List<Proveedoress> BuscarProveedores(string provNombre)//Metodo Busqueda
        {

            List<Proveedoress> _listaProveedores = new List<Proveedoress>();
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT idProveedor,nombreProveedor,rfcProveedor,direccionProveedor,telefonoProveedor FROM proveedores where nombreProveedor='{0}'", provNombre), conexionSQL.obtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Proveedoress provProveedores = new Proveedoress();

                provProveedores.idProveedor = _reader.GetInt32(0);
                provProveedores.nombreProveedor = _reader.GetString(1);
                provProveedores.rfcProveedor = _reader.GetString(2);
                provProveedores.direccionProveedor = _reader.GetString(3);
                provProveedores.telefonoProveedor = _reader.GetString(4);



                _listaProveedores.Add(provProveedores);
            }
            return _listaProveedores;

        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////
        public static Proveedoress ObtenerProveedores(int provId)//Metodo Obtener
        {
            Proveedoress provProveedores = new Proveedoress();
            MySqlConnection conexion = conexionSQL.obtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT idProveedor,nombreProveedor,rfcProveedor,direccionProveedor,telefonoProveedor FROM proveedores where idProveedor={0}", provId), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                provProveedores.idProveedor = _reader.GetInt32(0);
                provProveedores.nombreProveedor = _reader.GetString(1);
                provProveedores.rfcProveedor = _reader.GetString(2);
                provProveedores.direccionProveedor = _reader.GetString(3);
                provProveedores.telefonoProveedor = _reader.GetString(4);


            }

            conexion.Close();
            return provProveedores;
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static List<Proveedoress> obtenerProveedoresName() {

            List<Proveedoress> _NameProveedor = new List<Proveedoress>();
            MySqlConnection conexion = conexionSQL.obtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT idProveedor, nombreProveedor from proveedores"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
           
            while (_reader.Read())
            {
                Proveedoress provProveedores = new Proveedoress();
                provProveedores.idProveedor = _reader.GetInt32(0);
                provProveedores.nombreProveedor = _reader.GetString(1);
                _NameProveedor.Add(provProveedores);
            }
            conexion.Close();
            return _NameProveedor;
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static int ActualizarProveedor(Proveedoress provProveedores)//Metodo Actualizar
        {
            int retorno = 0;
            MySqlConnection conexion = conexionSQL.obtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Update proveedores set nombreProveedor='{0}', rfcProveedor='{1}', direccionProveedor='{2}', telefonoProveedor='{3}' where idProveedor='{4}'", provProveedores.nombreProveedor, provProveedores.rfcProveedor, provProveedores.direccionProveedor, provProveedores.telefonoProveedor, provProveedores.idProveedor), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;


        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static int EliminarProveedores(int provId)//Metodo Eliminar
        {
            int retorno = 0;
            MySqlConnection conexion = conexionSQL.obtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("Delete From proveedores where idProveedor={0}", provId), conexion);
            retorno = comando.ExecuteNonQuery();
            conexion.Close();
            return retorno;


        }
    }
}
