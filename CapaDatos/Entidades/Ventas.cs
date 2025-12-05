using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entidades
{
    public class Venta
    {
        public string NumeroVenta { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public string TipoPago { get; set; }
        public decimal Total { get; set; }
    }
}

