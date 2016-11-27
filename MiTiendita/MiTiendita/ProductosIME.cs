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

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into producto (idProducto,nombre,unidades,precio,pieza) values ('{0}','{1}','{2}', '{3}','{4}')",
            pProductos.idProducto, pProductos.nombre, pProductos.unidanes, pProductos.precio, pProductos.pieza), conexionSQL.obtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        /// <summary>
        //
        /// </summary>
        /// <param name="cId"></param>
        /// <param name="cDescripcion"></param>
        /// <returns></returns>
        /// 
        /*
        public static List<Compras> BuscarCompras(int cId, string cDescripcion)//Metodo que busca las Compras realizadas
        {
            List<Compras> _listaCompra = new List<Compras>();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT idCompras, Descripcion_Compras,Cantidad_Compras,PrecioPruducto_Compras, Total_Compras  where idCompras ='{0}' or Descripcion_Compras='{1}'", cId, cDescripcion), bdComun.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Compras pCompras = new Compras();

                pCompras.idCompras = _reader.GetInt32(0);
                pCompras.Descripcion_Compras = _reader.GetString(1);
                pCompras.PrecioProducto_Compras = _reader.GetString(2);
                pCompras.Cantidad_Compras = _reader.GetString(3);
                pCompras.PrecioProducto_Compras = _reader.GetString(4);
                pCompras.Total_Compras = _reader.GetString(5);

                _listaCompra.Add(pCompras);
            }
            return _listaCompra;

        }

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
