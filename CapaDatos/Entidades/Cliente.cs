using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entidades
{
    public class Cliente
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string TipoCliente { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
    }
}
