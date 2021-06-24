using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ServiTech.Models
{

    [Table("Empleadoes")]

    public class Empleado
    {
        [DisplayName("Nombre de Usuario")]
        public string Id { get; set; }
        public string Contraseña { get; set; }
        public int IdTipoEmpleado { get; set; }

        [DisplayName("Nombre Completo")]
        public string Nombre { get; set; }

        [DisplayName("Numero de Celular")]
        public int Celular { get; set; }

        [DisplayName("Correo Electronico")]

        public string Correo { get; set; }
        public string Direccion { get; set; }
        public decimal Sueldo { get; set; }

        public virtual Tipoempleado Tipoempleado { get; set; }


    }
}
