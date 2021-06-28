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








    }
}
