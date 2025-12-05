using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Repositorios
{
    public class RepositorioProveedorMem
    {
        private readonly List<Proveedor> _tabla = new List<Proveedor>();
        private int _ultimoCodigo = 0;

        public IEnumerable<Proveedor> Listar() => _tabla;
        public Proveedor ObtenerPorId(int codigo) => _tabla.FirstOrDefault(x => x.Codigo == codigo);
        public void Insertar(Proveedor p)
        {
            p.Codigo = ++_ultimoCodigo;
            _tabla.Add(p);
        }
        public void Actualizar(Proveedor p)
        {
            var idx = _tabla.FindIndex(x => x.Codigo == p.Codigo);
            if (idx >= 0) _tabla[idx] = p;
        }
        public void Eliminar(int codigo) => _tabla.RemoveAll(x => x.Codigo == codigo);
        public int ObtenerUltimoCodigo() => _ultimoCodigo;
    }
}

