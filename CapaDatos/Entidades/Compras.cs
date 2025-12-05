using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entidades
{
    public class Compra
    {
        public int Codigo { get; set; }
        public DateTime Fecha { get; set; }
        public int ProveedorId { get; set; }
        public decimal Total { get; set; }
        public List<CompraDetalle> Detalles { get; set; } = new List<CompraDetalle>();
    }

    public class CompraDetalle
    {
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal => Cantidad * PrecioUnitario;
    }
}
