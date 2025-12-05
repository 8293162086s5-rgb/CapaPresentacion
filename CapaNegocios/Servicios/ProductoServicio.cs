using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Entidades;
using CapaDatos.Repositorios;

namespace CapaNegocios.Servicios
{
    public class ProductoServicio
    {
        private readonly RepositorioProductoMem _repo;

        public ProductoServicio(RepositorioProductoMem repo)
        {
            _repo = repo;
        }

        public IEnumerable<Producto> Listar() => _repo.Listar();
        public Producto ObtenerPorId(int codigo) => _repo.ObtenerPorId(codigo);
        public void Insertar(Producto p) => _repo.Insertar(p);
        public void Actualizar(Producto p) => _repo.Actualizar(p);
        public void Eliminar(int codigo) => _repo.Eliminar(codigo);
    }
}
