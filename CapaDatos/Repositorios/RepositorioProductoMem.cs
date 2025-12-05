using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Repositorios
{
    public class RepositorioProductoMem
    {
        private readonly List<Producto> _tabla = new List<Producto>();
        private int _ultimoCodigo = 0;

        public IEnumerable<Producto> Listar() => _tabla;

        public Producto ObtenerPorId(int codigo) => _tabla.FirstOrDefault(x => x.Codigo == codigo);

        public void Insertar(Producto p)
        {
            p.Codigo = ++_ultimoCodigo;
            p.StockActual = p.StockInicial;
            _tabla.Add(p);
        }

        public void Actualizar(Producto p)
        {
            var idx = _tabla.FindIndex(x => x.Codigo == p.Codigo);
            if (idx >= 0) _tabla[idx] = p;
        }

        public void Eliminar(int codigo) => _tabla.RemoveAll(x => x.Codigo == codigo);

        public int ObtenerUltimoCodigo() => _ultimoCodigo;
    }
}

