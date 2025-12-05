using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Repositorios;

namespace CapaNegocios.Servicios
{
    public class VentaServicio
    {
        private readonly RepositorioVentaMem _repositorio;

        public VentaServicio(RepositorioVentaMem repositorio)
        {
            _repositorio = repositorio;
        }

        // 👇 ESTE MÉTODO ES EL QUE NECESITAS
        public IEnumerable<Venta> Filtrar(DateTime desde, DateTime hasta, string cliente, string tipoPago, string numeroVenta)
        {
            var lista = _repositorio.Listar();

            var filtrado = lista.Where(v =>
                v.Fecha >= desde &&
                v.Fecha <= hasta &&
                (string.IsNullOrEmpty(cliente) || v.Cliente.Contains(cliente)) &&
                (string.IsNullOrEmpty(tipoPago) || v.TipoPago == tipoPago) &&
                (string.IsNullOrEmpty(numeroVenta) || v.NumeroVenta.Contains(numeroVenta))
            );

            return filtrado;
        }
    }
}
