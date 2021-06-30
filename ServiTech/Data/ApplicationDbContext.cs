using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ServiTech.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiTech.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Empleado> Empleadoes { get; set; }

        public virtual DbSet<Tipoempleado> TipoEmpleadoes { get; set; }

        public virtual DbSet<DireccionParaEnvio> DireccionesEnvios { get; set; }

        public virtual DbSet<ModoDePagoTarjeta> PagoConTarjeta { get; set; }

       //El Dbcontext es lo que realmente me conecta el sql con el visual,
       //cuando creo las tablas aqui las envio con el add-migration y el update-database,
      //pero solo con el Dbset especifico que de la clase Tipo empleado por ejemplo,
     //quiero que aparezca la tabla tipoempleadoes en sql. Y desde alla puedo manejarla tambien.







    }
}
