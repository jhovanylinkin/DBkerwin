using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiTiendita
{
    public class listCompras
    {
    public int idcompras { get; set; }
    public int idProducto { get; set; }
    public string nombre { get; set; }
    public string unidanes { get; set; }
    public double precio { get; set; }
    public int cantidad { get; set; }
    public int idProveedor { get; set; }
    public double totalCompras { get; set; }
    public string fechaCompras { get; set; }



    public listCompras() { }

    public listCompras(int lidCompras,int lId, string lNombre, string lUnidades, double lPrecio,int lcantidad,int lidProve,double ltotalComp,string lfechaComp)

    {
        this.idcompras = lidCompras;
        this.idProducto = lId;
        this.nombre = lNombre;
        this.unidanes = lUnidades;
        this.precio = lPrecio;
        this.cantidad = lcantidad;
        this.idProveedor = lidProve;
        this.totalCompras = ltotalComp;
        this.fechaCompras = lfechaComp;


    }

}
}
