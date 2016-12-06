using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MiTiendita
{
    class VentasIME
    {
        public static List<ventass> obtenerComprasUltimoID()
        {

            List<ventass> _UltimoID = new List<ventass>();
            MySqlConnection conexion = conexionSQL.obtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("select max(idVentas) from ventas"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                ventass vventas = new ventass();
                vventas.idVentas = _reader.GetInt32(0);
                _UltimoID.Add(vventas);
            }
            conexion.Close();
            return _UltimoID;
        }
        //-------------------------------------------------------------------------------------------------------------------------
        public static int AgregarVentas(ventass vVentas, Clientes cClientes, Productos pProductos) //Funcion Agregar a Consola
        {
            int retorno = 0;

            try
            {
                MySqlCommand comando = new MySqlCommand(string.Format("Insert into ventas (totalVentas,fechaVentas,idCliente) values ('{0}','{1}','{2}')",
                vVentas.totalVentas, vVentas.fechaVentas, cClientes.idCliente), conexionSQL.obtenerConexion());
                retorno = comando.ExecuteNonQuery();
                return retorno;
            }
            catch { return 0; }
        }
        //------------------------------------------------------------------------------------------------------------------------- 
        /*
        public static int ActualizarProducto(ComprasC compCompras, Productos pProductos)//Metodo Actualizar los productos al realizar una compra
        {
            int retorno = 0;
            MySqlConnection conexion = conexionSQL.obtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Update producto,producto_has_compras set producto_has_compras.cantidad='{0}'  where producto.idProducto='{1}' and producto_has_compras.idProducto=producto.idProducto ", compCompras.cantidad, pProductos.idProducto), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;


        }*/
        //-------------------------------------------------------------------------------------------------------------------------
        public static int AgregarVentas_has_producto(ventass vVentas,Productos pProductos) //Funcion Agregar a Consola
        {
            int retorno = 0;

            try
            {
                MySqlCommand comando = new MySqlCommand(string.Format("Insert into ventas_has_producto (idVentas,idProducto,cantidad) values ('{0}','{1}','{2}')",
                vVentas.idVentas, pProductos.idProducto,vVentas.cantidad), conexionSQL.obtenerConexion());
                retorno = comando.ExecuteNonQuery();
                return retorno;
            }
            catch { return 0; }
        }

        //-------------------------------------------------------------------------------------------------------------------------
        
        public static List<listVentas> BuscarVentas(string VentID)//Busca
        {
            List<listVentas> _listaVentas = new List<listVentas>();
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT ventas.idVentas, ventas.totalVentas,ventas.fechaVentas,ventas.idcliente,ventas_has_producto.idProducto, ventas_has_producto.cantidad from ventas,ventas_has_producto where ventas.idVentas='{0}' and ventas_has_producto.idVentas=ventas.idVentas", VentID), conexionSQL.obtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                

                listVentas listVent = new listVentas();


                listVent.idVentas = _reader.GetInt32(0);
                listVent.totalVentas = _reader.GetString(1);
                listVent.fechaVentas = _reader.GetString(2);
                listVent.idCliente = _reader.GetInt32(3);
                listVent.idProducto = _reader.GetInt32(4);
                listVent.cantidad = _reader.GetInt32(5);
               


                _listaVentas.Add(listVent);
            }
            return _listaVentas;
        }

    }
}
