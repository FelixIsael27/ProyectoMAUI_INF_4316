using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock_Facil.Models;

namespace Stock_Facil.Services
{
    public class ProductoService
    {
        private readonly List<Producto> productos = new();

        public List<Producto> ObtenerTodos()
        {
            return productos;
        }

        public void Agregar(Producto producto)
        {
            producto.ID = productos.Count + 1;
            productos.Add(producto);
        }
    }
}
