using CapaDatos.Entidades;
using CapaDatos.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios.Servicios
{
    public class MovimientoStockServicio
    {
        private readonly RepositorioMovimientoStockMem _repo;

        public MovimientoStockServicio(RepositorioMovimientoStockMem repo)
        {
            _repo = repo;
        }

        public IEnumerable<MovimientoStock> Listar() => _repo.Listar();

        public void Registrar(MovimientoStock m) => _repo.Registrar(m);
    }
}