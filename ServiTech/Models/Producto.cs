using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ServiTech.Models
{
    [Table("Productos")]
    public class Producto
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
      
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public decimal Precio { get; set; }

        public string Cantidad { get; set; }

        public string Imagen { get; set; }

        public string Marca { get; set; }

        [Display(Name = "Tipo de Producto")]
        public TipoProducto Tipo { get; set; }

        [Display(Name = "Categoria de Producto")]

        public ProductoCategoria Categoria { get; set; }

        [Display(Name = "Fecha de registro")]
        public DateTime? FechaRegistro { get; set; }

        [Display(Name = "Fecha Activo")]
        public DateTime? FechaActivo { get; set; }

        [Display(Name = "Color del producto")]
        public string Color { get; set; }


        [Display(Name = "Stock del producto")]
        public int Stock { get; set; }








    }
}
