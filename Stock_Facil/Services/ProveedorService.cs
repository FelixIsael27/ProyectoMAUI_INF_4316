using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock_Facil.Models;

namespace Stock_Facil.Services
{
    public class ProveedorService
    {
        public List<Proveedor> ObtenerTodos()
        {
            return proveedores;
        }

        public void Agregar(Proveedor proveedor)
        {
            proveedor.ID = proveedores.Count + 1;
            proveedores.Add(proveedor);
        }
    }
}
