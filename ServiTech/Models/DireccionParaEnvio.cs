using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ServiTech.Models
{
    [Table("DireccionesEnvios")]
    public class DireccionParaEnvio
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDireccion { get; set; }

        [Display(Name = "Nombre del destinatario")]
        public string NombreDestinatario { get; set; }

        [Display(Name = "Numero de telefono")]
        public string  NumeroTelefono { get; set; }

        public string Direccion  { get; set; }
        

    }
}
