using CapaDatos.Entidades;
using CapaDatos.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios.Servicios
{
    public class CuentaPorCobrarServicio
    {
        private readonly RepositorioCuentaPorCobrarMem _repo;

        public CuentaPorCobrarServicio(RepositorioCuentaPorCobrarMem repo)
        {
            _repo = repo;
        }

        public IEnumerable<CuentaPorCobrar> Listar() => _repo.Listar();

        public CuentaPorCobrar ObtenerPorId(int codigo) => _repo.ObtenerPorId(codigo);

        public void Insertar(CuentaPorCobrar c) => _repo.Insertar(c);

        public void MarcarComoPagada(int codigo) => _repo.MarcarComoPagada(codigo);
    }
}
