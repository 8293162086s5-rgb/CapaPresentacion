using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Repositorios
{
    public class RepositorioVentaMem
    {
        private List<Venta> _ventas = new List<Venta>
        {
            new Venta { NumeroVenta = "V001", Fecha = DateTime.Today, Cliente = "Juan", TipoPago = "Efectivo", Total = 100 },
            new Venta { NumeroVenta = "V002", Fecha = DateTime.Today.AddDays(-1), Cliente = "Maria", TipoPago = "Tarjeta", Total = 200 }
        };

        public IEnumerable<Venta> Listar()
        {
            return _ventas;
        }
    }
}
