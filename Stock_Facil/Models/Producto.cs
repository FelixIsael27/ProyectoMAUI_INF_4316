using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Facil.Models
{
    public class Producto
    {
        public int ID { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Codigo { get; set; } = string.Empty;

        public string Categoria { get; set; } = string.Empty;

        public decimal Precio { get; set; }

        public int Cantidad { get; set; }

        public string Descripcion { get; set; } = string.Empty;
    }
}
