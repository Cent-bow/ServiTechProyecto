using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiTech.Models
{
    public class ProductoIndexViewModel
    {
        public TipoProducto? TipoProducto { get; set; }

        public ProductoCategoria? productoCategoria { get; set; }

        public string Nombres { get; set; }
    }
}
