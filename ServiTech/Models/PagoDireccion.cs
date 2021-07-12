using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ServiTech.Models
{
    public class PagoDireccion
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int PagoID { get; set; }
        
        [Required]
        public int CarritoID { get; set; }
        
        [Required]
        public string UserName { get; set; }
        
        [Required]
        public string Nombre { get; set; }
        
        [Required]
        public string Apellido { get; set; }
        
        [Required]
        
        public TipoDePago Tipo { get; set; }
        
        [Required]
        public string Direccion { get; set; }
        
        [Required]
        public decimal Fecha { get; set; }
    }
}
