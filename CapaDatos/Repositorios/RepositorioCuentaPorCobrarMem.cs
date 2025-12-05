using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Repositorios
{
    public class RepositorioCuentaPorCobrarMem
    {
        private readonly List<CuentaPorCobrar> _tabla = new List<CuentaPorCobrar>();
        private int _ultimoCodigo = 0;

        public IEnumerable<CuentaPorCobrar> Listar() => _tabla;
        public CuentaPorCobrar ObtenerPorId(int codigo) => _tabla.FirstOrDefault(x => x.Codigo == codigo);

        public void Insertar(CuentaPorCobrar c)
        {
            c.Codigo = ++_ultimoCodigo;
            _tabla.Add(c);
        }

        public void MarcarComoPagada(int codigo)
        {
            var cuenta = ObtenerPorId(codigo);
            if (cuenta != null) cuenta.Pagada = true;
        }

        public int ObtenerUltimoCodigo() => _ultimoCodigo;
    }
}
