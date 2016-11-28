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
        /// <summary>
        //
        /// </summary>
        /// <param name="cId"></param>
        /// <param name="cDescripcion"></param>
        /// <returns></returns>
        /// 
        
        public static List<Productos> BuscarCompras(int pId, string pNombre)//Metodo que busca los productos
        {
            List<Productos> _listaProductos = new List<Productos>();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT idProducto, nombre,unidades,precio, pieza  where idProducto ='{0}' or nombre='{1}'", pId, pNombre), conexionSQL.obtenerConexion());
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
        /*
        /////////////////////////////////////////////////////////////////////////////////////////////////////
        public static Compras ObtenerCompras(int cId)//Metodo ObtenerCompras 
        {
            Compras pCompras = new Compras();
            MySqlConnection conexion = bdComun.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT idCompras, Descripcion_Compras, Provedor_Compras,Cantidad_Compras,PrecioPruducto_Compras, Total_Compras  FROM Compras where idCompras={0}", cId), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pCompras.idCompras = _reader.GetInt32(0);
                pCompras.Descripcion_Compras = _reader.GetString(1);
                pCompras.PrecioProducto_Compras = _reader.GetString(2);
                pCompras.Cantidad_Compras = _reader.GetString(3);
                pCompras.PrecioProducto_Compras = _reader.GetString(4);
                pCompras.Total_Compras = _reader.GetString(5);

            }

            conexion.Close();
            return pCompras;
        }
        
        //////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static int ActualizarCompras(Compras pCompras)//Metodo Actualizar
        {
            int retorno = 0;
            MySqlConnection conexion = bdComun.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Update Compras set Descripcion_Compras='{0}', Provedor_Compras='{1}', Cantidad_Compras='{2}', PrecioProducto_Compras='{3}', Total_Compras='{4}' where idCompras='{5}', ", pCompras.Descripcion_Compras, pCompras.PrecioProducto_Compras, pCompras.PrecioProducto_Compras, pCompras.Cantidad_Compras, pCompras.Total_Compras, pCompras.idCompras), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;


        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static int EliminarCompras(int cId)//Metodo Eliminar en Compras
        {
            int retorno = 0;
            MySqlConnection conexion = bdComun.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("Delete From Compras where idCompras={0}", cId), conexion);
            retorno = comando.ExecuteNonQuery();
            conexion.Close();
            return retorno;


        }
        */

    }
}
