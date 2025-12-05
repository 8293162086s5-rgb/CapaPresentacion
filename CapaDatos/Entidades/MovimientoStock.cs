using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entidades
{
    public class MovimientoStock
    {
        public int Codigo { get; set; }
        public int ProductoId { get; set; }
        public DateTime Fecha { get; set; }
        public int Cantidad { get; set; }
        public string Motivo { get; set; } = string.Empty;
    }
}
