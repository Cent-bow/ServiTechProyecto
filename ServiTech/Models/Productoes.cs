using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ServiTech.Models
{
    public class Productoes
    {
        public int id { get; set; }

        [DisplayName("Nombre")]
        public string nombre { get; set; }

        [DisplayName("Categoria")]
        public string categoria { get; set; }

        [DisplayName("DESCRIPCION")]
        public string descripcion { get; set; }



        [DisplayName("PRECIO S/")]
        public double precio { get; set; }

        [DisplayName("STOCK ACTUAL")]
        public int stockActual { get; set; }

        [DisplayName("Proveedor")]
        public string proveedor { get; set; }

        [DisplayName("IMAGEN DE PRODUCTO")]
        public string Imagen { get; set; }

        

        public string CantidadDisponible { get; set; }

        public string Cantidad { get; set; }
    }
}
