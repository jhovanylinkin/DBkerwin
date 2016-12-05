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
        public static int AgregarProductos(ventass vVentas, Clientes cClientes, Productos pProductos) //Funcion Agregar a Consola
        {
            int retorno = 0;

            try
            {
                MySqlCommand comando = new MySqlCommand(string.Format("Insert into ventas (totalVentas,fechaVentas,idCliente,Producto_idProducto) values ('{0}','{1}','{2}', '{3}')",
                vVentas.totalVentas, vVentas.fechaVentas, cClientes.idCliente, pProductos.idProducto), conexionSQL.obtenerConexion());
                retorno = comando.ExecuteNonQuery();
                return retorno;
            }
            catch { return 0; }
        }
    }
}
