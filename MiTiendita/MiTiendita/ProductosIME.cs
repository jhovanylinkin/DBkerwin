using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace MiTiendita
{
    class ProductosIME
    {
        public static int AgregarProductos(Productos pProductos) //Funcion Agregar a Consola
        {
            int retorno = 0;
            try
            {
                MySqlCommand comando = new MySqlCommand(string.Format("Insert into producto (idProducto,nombre,unidades,precio,pieza) values ('{0}','{1}','{2}', '{3}','{4}')",
                pProductos.idProducto, pProductos.nombre, pProductos.unidanes, pProductos.precio, pProductos.pieza), conexionSQL.obtenerConexion());
                retorno = comando.ExecuteNonQuery();
                return retorno;
            }
            catch { return 0; }
        }
       
 
        public static List<Productos> BuscarProductos(int pId, string pNombre)//Metodo que busca los productos
        {

            List<Productos> _listaProductos = new List<Productos>();
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT idProducto,nombre,unidades,precio, pieza FROM producto where idProducto='{0}' or nombre='{1}'", pId, pNombre), conexionSQL.obtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Productos pProductos = new Productos();

                pProductos.idProducto = _reader.GetInt32(0);
                pProductos.nombre = _reader.GetString(1);
                pProductos.unidanes = _reader.GetString(2);
                pProductos.precio = _reader.GetDouble(3);
                pProductos.pieza = _reader.GetInt32(4);
               

                _listaProductos.Add(pProductos);
            }
            return _listaProductos;

        }
        
        /////////////////////////////////////////////////////////////////////////////////////////////////////
        public static Productos ObtenerProductos(int pId)//Metodo ObtenerProductos
        {
            Productos pProductos = new Productos();
            MySqlConnection conexion = conexionSQL.obtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT idProducto, nombre, unidades,precio,pieza FROM producto where idProducto={0}", pId),conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pProductos.idProducto = _reader.GetInt32(0);
                pProductos.nombre= _reader.GetString(1);
                pProductos.unidanes = _reader.GetString(2);
                pProductos.precio = _reader.GetDouble(3);
                pProductos.pieza = _reader.GetInt32(4);
             
            }

            conexion.Close();
            return pProductos;
        }
        
        //////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static int ActualizarProducto(Productos pProductos)//Metodo Actualizar
        {
            int retorno = 0;
            MySqlConnection conexion = conexionSQL.obtenerConexion();

           MySqlCommand comando = new MySqlCommand(string.Format("Update producto set nombre='{0}', unidades='{1}', precio='{2}', pieza='{3}' where idProducto='{4}'", pProductos.nombre, pProductos.unidanes, pProductos.precio, pProductos.pieza, pProductos.idProducto), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;


        }
        
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static int EliminarProductos(int pId)//Metodo Eliminar en Compras
        {
            int retorno = 0;
            MySqlConnection conexion = conexionSQL.obtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("Delete From producto where idProducto={0}", pId), conexion);
            retorno = comando.ExecuteNonQuery();
            conexion.Close();
            return retorno;


        }
        

    }
}
