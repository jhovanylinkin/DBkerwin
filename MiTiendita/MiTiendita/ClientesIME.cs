using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MiTiendita
{
    class ClientesIME
    {
        public static int AgregarClientes(Clientes clClientes) //Funcion Agregar a Consola
        {
            int retorno = 0;
            try
            {
                MySqlCommand comando = new MySqlCommand(string.Format("Insert into cliente (nombreCliente,telefonoCliente,direccionCliente) values ('{0}','{1}','{2}')", clClientes.nombreCliente, clClientes.telefonoCliente, clClientes.direccionCliente), conexionSQL.obtenerConexion());
                retorno = comando.ExecuteNonQuery();
                return retorno;
            }
            catch { return 0; }
        }


        public static List<Clientes> BuscarClientes(string clNombre)//Metodo Busqueda
        {

            List<Clientes> _listaClientes = new List<Clientes>();
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT idCliente,nombreCliente,telefonoCliente,direccionCliente FROM cliente where nombreCliente='{0}'",clNombre), conexionSQL.obtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Clientes clClientes = new Clientes();

                clClientes.idCliente = _reader.GetInt32(0);
                clClientes.nombreCliente = _reader.GetString(1);
                clClientes.telefonoCliente = _reader.GetString(2);
                clClientes.direccionCliente = _reader.GetString(3);
               


                _listaClientes.Add(clClientes);
            }
            return _listaClientes;

        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////
        public static Clientes ObtenerClientes(int clId)//Metodo Obtener
        {
            Clientes clClientes = new Clientes();
            MySqlConnection conexion = conexionSQL.obtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT idCliente, nombreCliente,telefonoCliente,direccionCliente FROM cliente where idCliente={0}", clId), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                clClientes.idCliente = _reader.GetInt32(0);
                clClientes.nombreCliente = _reader.GetString(1);
                clClientes.telefonoCliente = _reader.GetString(2);
                clClientes.direccionCliente= _reader.GetString(3);
               

            }

            conexion.Close();
            return clClientes;
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static List<Clientes> obtenerclientesName()
        {

            List<Clientes> _NameClientes = new List<Clientes>();
            MySqlConnection conexion = conexionSQL.obtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT idCliente, nombreCliente from cliente"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                Clientes cliClientes = new Clientes();
                cliClientes.idCliente = _reader.GetInt32(0);
                cliClientes.nombreCliente = _reader.GetString(1);
                _NameClientes.Add(cliClientes);
            }
            conexion.Close();
            return _NameClientes;
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static int ActualizarCliente(Clientes clClientes)//Metodo Actualizar
        {
            int retorno = 0;
            MySqlConnection conexion = conexionSQL.obtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Update cliente set nombreCliente='{0}', telefonoCliente='{1}', direccionCliente='{2}' where idCliente='{3}'", clClientes.nombreCliente,clClientes.telefonoCliente,clClientes.direccionCliente,clClientes.idCliente), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;


        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static int EliminarClientes(int clId)//Metodo Eliminar
        {
            int retorno = 0;
            MySqlConnection conexion = conexionSQL.obtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("Delete From cliente where idCliente={0}", clId), conexion);
            retorno = comando.ExecuteNonQuery();
            conexion.Close();
            return retorno;


        }


    }
}
