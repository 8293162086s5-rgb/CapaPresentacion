using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Repositorios
{
    public class RepositorioCompraMem
    {
        private readonly List<Compra> _tabla = new List<Compra>();
        private int _ultimoCodigo = 0;

        // Listar todas las compras
        public IEnumerable<Compra> Listar() => _tabla;

        // Obtener una compra por su código
        public Compra ObtenerPorId(int codigo) => _tabla.FirstOrDefault(x => x.Codigo == codigo);

        // Insertar una nueva compra
        public void Insertar(Compra c)
        {
            c.Codigo = ++_ultimoCodigo;
            c.Total = c.Detalles.Sum(d => d.Subtotal);
            _tabla.Add(c);
        }

        // Actualizar una compra existente
        public void Actualizar(Compra c)
        {
            var idx = _tabla.FindIndex(x => x.Codigo == c.Codigo);
            if (idx >= 0)
            {
                c.Total = c.Detalles.Sum(d => d.Subtotal);
                _tabla[idx] = c;
            }
        }

        // Eliminar una compra por código
        public void Eliminar(int codigo) => _tabla.RemoveAll(x => x.Codigo == codigo);

        // Obtener el último código asignado
        public int ObtenerUltimoCodigo() => _ultimoCodigo;
    }
}
