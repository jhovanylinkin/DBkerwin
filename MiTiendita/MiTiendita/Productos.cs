using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiTiendita
{
    public class Productos
    {
        public int idProducto { get; set; }
        public string nombre { get; set; }
        public string unidanes { get; set; }
        public double precio { get; set; }
        public int pieza { get; set; }


        public Productos(){ }

        public Productos(int pId, string pNombre, string pUnidades, double pPrecio, int pPieza)

        {
            
            this.idProducto = pId;
            this.nombre = pNombre;
            this.unidanes = pUnidades;
            this.precio = pPrecio;
            this.pieza = pPieza;
        } 
    
    }
    
}
