using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using RegistroDeOrdenes.Entidades;

namespace RegistroDeOrdenes.DAL
{
    public class Contexto : DbContext
    {

        public DbSet<Rol> Rol { get; set; }
        public DbSet<Permisos> Permisos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = DATA\CitiesControl.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Permisos>().HasData(new Permisos
            {
                PermisoId = 1,
                Nombre = "Permiso para estudios",
                Descripcion = "Permiso para que el trabajador pueda estudiar"
            });
            modelBuilder.Entity<Permisos>().HasData(new Permisos
            { 
                PermisoId = 2,
                Nombre = "Permiso por Vacaiones",
                Descripcion = "Permiso para que el trabajador descanse"
            });
            modelBuilder.Entity<Permisos>().HasData(new Permisos
            {
                PermisoId = 3,
                Nombre = "Permiso de emergencia",
                Descripcion = "Permiso para que el trbajador salga en caso de emergencia"
            });
            modelBuilder.Entity<Permisos>().HasData(new Permisos
            {
                PermisoId = 4,
                Nombre = "Permiso de salud",
                Descripcion = "Permiso para que el trabajador visite a medico en caso de enfermedad"
            });
        }
    }
}
