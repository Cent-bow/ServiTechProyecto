using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ServiTech.Models
{

    [Table("TipoEmpleadoes")]
    public class Tipoempleado
    {
        public int Id { get; set; }

        [DisplayName("Cargo en la Empresa")]
        public string Descripcion { get; set; }
        public Nullable<decimal> Sueldo { get; set; }
    }
}
