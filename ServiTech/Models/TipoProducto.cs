using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ServiTech.Models
{

    public enum TipoProducto
    {
        Celular,
        Television,
        Mouse,
        Teclado,
        Silla,
        Cargadores,

        [Display (Name ="Computadoras de escritorio") ]
        ComputadorasdeEscritorio,
        Laptop,
        Monitor,
        Auriculares,
        Bocinas,

        [Display(Name = "Computadota de juego")]

        ComputadorasdeJuego,
        Reloj

    }
}
