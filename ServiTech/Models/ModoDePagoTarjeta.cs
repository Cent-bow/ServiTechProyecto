using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ServiTech.Models
{

    [Table("PagoConTarjeta")]
    public class ModoDePagoTarjeta
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTarjeta { get; set; }


        [Display(Name= "Tarjetas aceptadas")]
        public string TarjetasAceptadas { get; set; }

        [Display(Name= "Nombre del titular")]
        public string NombreTitular { get; set; }

        [Display(Name= "Numero de tarjeta")]
        public string NumeroTarjeta { get; set; }

        [Display(Name= "Fecha de expiracion")]
        public DateTime? FechaExpiracion { get; set; }

        [Display(Name= "Codigo de seguridad")]
        public string CodigoSeguridad { get; set; }


    }
}
