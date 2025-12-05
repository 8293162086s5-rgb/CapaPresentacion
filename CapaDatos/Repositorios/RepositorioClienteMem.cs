using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Repositorios
{
    public class RepositorioClienteMem
    {
        private readonly List<Cliente> _tabla = new List<Cliente>();
        private int _ultimoCodigo = 0;

        public IEnumerable<Cliente> Listar() => _tabla;

        public Cliente ObtenerPorId(int codigo) => _tabla.FirstOrDefault(x => x.Codigo == codigo);

        public void Insertar(Cliente c)
        {
            c.Codigo = ++_ultimoCodigo;
            _tabla.Add(c);
        }

        public void Actualizar(Cliente c)
        {
            var idx = _tabla.FindIndex(x => x.Codigo == c.Codigo);
            if (idx >= 0) _tabla[idx] = c;
        }

        public void Eliminar(int codigo) => _tabla.RemoveAll(x => x.Codigo == codigo);

        public int ObtenerUltimoCodigo() => _ultimoCodigo;
    }
}
