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
        public int Cantidad { get; set; }
        public int PrecioUnitario { get; set; }


    }
}
