using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiTiendita
{
   public class Proveedoress
    {
        
            public int idProveedor { get; set; }
            public string nombreProveedor { get; set; }
            public string rfcProveedor { get; set; }
            public string direccionProveedor { get; set; }
            public string telefonoProveedor { get; set; }


            public Proveedoress() { }

            public Proveedoress(int provId, string provNombre, string provRFC, string provDireccion, string provTelefono)

            {

                this.idProveedor = provId;
                this.nombreProveedor = provNombre;
                this.rfcProveedor = provRFC;
                this.direccionProveedor = provDireccion;
                this.telefonoProveedor = provTelefono;
            }

        
    }
}
