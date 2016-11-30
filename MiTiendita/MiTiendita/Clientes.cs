using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiTiendita
{
    public class Clientes
    {
        public int idCliente { get; set; }
        public string nombreCliente { get; set; }
        public string telefonoCliente { get; set; }
        public string direccionCliente { get; set; }


        public Clientes() { }

        public Clientes(int clId, string clNombre, string clTelefono, string clDireccion)
        {


            this.idCliente= clId;
            this.nombreCliente = clNombre;
            this.telefonoCliente = clTelefono;
            this.direccionCliente = clDireccion;
        }

    }

}
