using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ServiTech.Models
{
    public class ProductoItem
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DisplayName("Nombre")]
        public string nombre { get; set; }

        [DisplayName("DESCRIPCION")]
        public string descripcion { get; set; }

        [DisplayName("PRECIO S/")]
        public double precio { get; set; }

        [DisplayName("CANTIDAD")]
        public int cantidad { get; set; }

        [DisplayName("SUBTOTAL")]
        public double subtotal
        {
            get { return precio * cantidad; }
        }

        public string Imagen { get; set; }
    }
}

