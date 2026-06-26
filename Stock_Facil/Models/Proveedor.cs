using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Facil.Models
{
    public class Proveedor
    {
        public int ID { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Telefono { get; set; } = string.Empty;

        public string Correo { get; set; } = string.Empty;
    }
}
