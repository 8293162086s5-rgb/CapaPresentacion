using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Repositorios
{
    public class RepositorioMovimientoStockMem
    {
        private readonly List<MovimientoStock> _tabla = new List<MovimientoStock>();
        private int _ultimoCodigo = 0;

        public IEnumerable<MovimientoStock> Listar() => _tabla;

        public void Registrar(MovimientoStock m)
        {
            m.Codigo = ++_ultimoCodigo;
            _tabla.Add(m);
        }

        public int ObtenerUltimoCodigo() => _ultimoCodigo;
    }
}