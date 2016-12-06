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
            int retorno2 = 0;

            try
            {
                MySqlCommand comando = new MySqlCommand(string.Format("Insert into producto (idProducto,nombre,unidades,precio) values ('{0}','{1}','{2}', '{3}')",
                pProductos.idProducto, pProductos.nombre, pProductos.unidanes, pProductos.precio), conexionSQL.obtenerConexion());
                retorno2 = comando.ExecuteNonQuery();
                return retorno2;
            }
            catch { return 0; }
        }


        public static int AgregarCompras(ComprasC compCompras, Proveedoress provProveedores) {
            int retorno = 0;
            try
            {
                MySqlCommand comandoCompras = new MySqlCommand(string.Format("Insert into compras (idcompras,totalCompras,fechaCompras,idProveedor) values ('{0}','{1}','{2}','{3}')",
               compCompras.idcompras, compCompras.totalCompras, compCompras.fechaCompras, provProveedores.idProveedor), conexionSQL.obtenerConexion());
                retorno = comandoCompras.ExecuteNonQuery();
                return retorno;

            }
            catch
            {
                return 0;
            }
        }

        public static int AgregarProductos_has_Compras(Productos pProductos,ComprasC compCompras) //Funcion Agregar a Consola
        {
            int retorno3 = 0;

            try
            {
                MySqlCommand comando = new MySqlCommand(string.Format("Insert into producto_has_compras (idProducto,idcompras,cantidad) values ('{0}','{1}','{2}')",
                pProductos.idProducto, compCompras.idcompras, compCompras.cantidad), conexionSQL.obtenerConexion());
                retorno3 = comando.ExecuteNonQuery();
                return retorno3;
            }
            catch { return 0; }
        }

        public static List<Productos> BuscarProductos(int pId,string pNombre)//Metodo que busca los productos
        {

            List<Productos> _listaProductos = new List<Productos>();
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT idProducto,nombre,unidades,precio FROM producto where idProducto='{0}' or nombre='{1}'", pId, pNombre), conexionSQL.obtenerConexion());

            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Productos pProductos = new Productos();

                pProductos.idProducto = _reader.GetInt32(0);
                pProductos.nombre = _reader.GetString(1);
                pProductos.unidanes = _reader.GetString(2);
                pProductos.precio = _reader.GetDouble(3);


                _listaProductos.Add(pProductos);
            }
            return _listaProductos;

        }
        public static List<Productos> BuscarProductosSinID(string pNombre)//Busca sin nececidad del ID
        {
            List<Productos> _listaProductos = new List<Productos>();
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT idProducto,nombre,unidades,precio FROM producto where nombre='{0}'", pNombre), conexionSQL.obtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Productos pProductos = new Productos();

                pProductos.idProducto = _reader.GetInt32(0);
                pProductos.nombre = _reader.GetString(1);
                pProductos.unidanes = _reader.GetString(2);
                pProductos.precio = _reader.GetDouble(3);



                _listaProductos.Add(pProductos);
            }
            return _listaProductos;
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////Metodo PARA BUSCAR Y MANDAR LOS DATOS EN ORDEN AL DATAgrIDvIEW
       

        /////////////////////////////////////////////////////////////////////////////////////////////////////
        public static Productos ObtenerProductos(int pId)//Metodo ObtenerProductos
        {
            Productos pProductos = new Productos();
            MySqlConnection conexion = conexionSQL.obtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT idProducto, nombre, unidades,precio FROM producto where idProducto='{0}'", pId),conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pProductos.idProducto = _reader.GetInt32(0);
                pProductos.nombre= _reader.GetString(1);
                pProductos.unidanes = _reader.GetString(2);
                pProductos.precio = _reader.GetDouble(3);


            }

            conexion.Close();
            return pProductos;
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static List<Productos> obtenerProductosName()
        {

            List<Productos> _NameProductos = new List<Productos>();
            MySqlConnection conexion = conexionSQL.obtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT idProducto, nombre from producto"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                Productos pProductos = new Productos();
                pProductos.idProducto = _reader.GetInt32(0);
                pProductos.nombre = _reader.GetString(1);
                _NameProductos.Add(pProductos);
            }
            conexion.Close();
            return _NameProductos;
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static int ActualizarProducto(Productos pProductos)//Metodo Actualizar
        {
            int retorno = 0;
            MySqlConnection conexion = conexionSQL.obtenerConexion();

           MySqlCommand comando = new MySqlCommand(string.Format("Update producto set nombre='{0}', unidades='{1}', precio='{2}' where idProducto='{3}'", pProductos.nombre, pProductos.unidanes, pProductos.precio, pProductos.idProducto), conexion);

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
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////


    }
}
