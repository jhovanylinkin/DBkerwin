using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiTiendita
{
   public class listVentas
    {
        public int idVentas { get; set; }
        public string totalVentas { get; set; }
        public string fechaVentas { get; set; }
        public int idCliente { get; set; }
        public int idProducto { get; set; }
        public int cantidad { get; set; }


        public listVentas() { }

        public listVentas(int LidV, string LtotalVentas,string Lfecha, int LidCliente, int LidProducto,int LCantidad)

        {
            this.idVentas = LidV;
            this.totalVentas = LtotalVentas;
            this.fechaVentas = Lfecha;
            this.idCliente = LidCliente;
            this.idProducto = LidProducto;
            this.cantidad = LCantidad;


        }
    }
}
