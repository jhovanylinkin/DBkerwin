using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiTiendita
{
    public class ComprasC
    {
        public int idcompras { get; set; }
        public double totalCompras { get; set; }
        public string fechaCompras { get; set; }
        public double cantidad { get; set; }

        public ComprasC() { }
        public ComprasC(int compId, double compTotal, string compFecha, int compHTotal)
        {
            this.idcompras = compId;
            this.totalCompras = compTotal;
            this.fechaCompras = compFecha;
            this.cantidad = compHTotal;
        }


    }
}
