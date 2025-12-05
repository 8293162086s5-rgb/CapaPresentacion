using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Repositorios
{
    public interface IRepositorioVenta
    {
        IEnumerable<Venta> Listar();
        // Aquí luego puedes agregar Insertar, Eliminar, etc.
    }
}
