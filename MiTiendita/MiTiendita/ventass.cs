﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiTiendita
{
    public class ventass
    {
        public int idVentas { get; set; }
        public int totalVentas { get; set; }
        public string fechaVentas { get; set; }
        public int cantidad { get; set; }


        public ventass() { }

        public ventass(int vId, int vTotal, string vfecha,int vCantidad)

        {

            this.idVentas = vId;
            this.totalVentas = vTotal;
            this.fechaVentas = vfecha;
            this.cantidad = vCantidad;

        }
    }
}
