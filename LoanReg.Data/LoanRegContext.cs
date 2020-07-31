using LoanReg.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanReg.Data
{
    public class LoanRegContext : DbContext
    {
        public LoanRegContext(DbContextOptions<LoanRegContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Pagos> Pagos { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Solicitud> Solicitudes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasMany(r => r.Empleados)
                .WithOne(e => e.Role)
                .HasForeignKey(e => e.RoleId);

            modelBuilder.Entity<Cliente>().HasMany(c => c.Solicitudes)
                .WithOne(s => s.Cliente)
                .HasForeignKey(s => s.ClienteId);

            //modelBuilder.Entity<Solicitud>()
            //    .HasOne(s => s.Prestamo)
            //    .WithOne(p => p.Solicitud)
            //    .HasForeignKey<Prestamo>(p => p.SolicitudId);

        }


    }
}
