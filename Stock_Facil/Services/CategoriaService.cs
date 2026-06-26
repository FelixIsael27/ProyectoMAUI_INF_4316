using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock_Facil.Models;

namespace Stock_Facil.Services
{
    public class CategoriaService
    {
        private readonly List<Categoria> categorias = new();

        public List<Categoria> ObtenerTodos()
        {
            return categorias;
        }

        public void Agregar(Categoria categoria)
        {
            categoria.ID = categorias.Count + 1;
            categorias.Add(categoria);
        }
    }
}
