using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ServiTech.Models
{
    [Table("Carritos")]
    public class CarritoModelo
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string UserName{ get; set; }

        public string ProductoName { get; set; }

        public int ProductoId { get; set; }

        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }

        public decimal Subtotal { get { return PrecioUnitario * Cantidad; } }

        public decimal Total { get; set; }

       
        



    }
}
