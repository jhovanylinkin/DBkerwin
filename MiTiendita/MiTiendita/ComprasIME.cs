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

//------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        public static List<listCompras> BuscarProductosPARACOMPRAS(string compID)//Busca
        {
            List<listCompras> _listaProductos = new List<listCompras>();
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT compras.idCompras, producto.idProducto,producto.nombre,producto.unidades,producto.precio,producto_has_compras.cantidad,compras.idProveedor,compras.totalCompras,compras.fechaCompras from compras,producto,producto_has_compras where producto.idProducto='{0}' and producto_has_compras.idCompras=compras.idCompras and producto_has_compras.idProducto=producto.idProducto", compID), conexionSQL.obtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                
                listCompras listComp = new listCompras();


                listComp.idcompras = _reader.GetInt32(0);
                listComp.idProducto = _reader.GetInt32(1);
                listComp.nombre = _reader.GetString(2);
                listComp.unidanes = _reader.GetString(3);
                listComp.precio = _reader.GetDouble(4);
                listComp.cantidad = _reader.GetInt32(5);
                listComp.idProveedor = _reader.GetInt32(6);
                listComp.totalCompras = _reader.GetDouble(7);
                listComp.fechaCompras = _reader.GetString(8);



                _listaProductos.Add(listComp);
            }
            return _listaProductos;
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

        public static int ActualizarCompra(ComprasC compCompras,Productos pProductos,Proveedoress provProveedores)//Metodo Actualizar
        {
            int retorno = 0;
            MySqlConnection conexion = conexionSQL.obtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Update compras,producto,producto_has_compras set producto.nombre='{0}', producto.unidades='{1}', producto.precio='{2}',producto_has_compras.cantidad='{3}',compras.idProveedor='{4}',compras.totalCompras='{5}',compras.fechaCompras='{6}'  where producto.idProducto='{7}' and producto_has_compras.idCompras=compras.idCompras and producto_has_compras.idProducto=producto.idProducto", pProductos.nombre, pProductos.unidanes, pProductos.precio,compCompras.cantidad,provProveedores.idProveedor,compCompras.totalCompras,compCompras.fechaCompras, pProductos.idProducto), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;


        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
    }
}
