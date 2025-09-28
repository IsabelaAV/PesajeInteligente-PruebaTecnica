using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Models;

namespace PruebaTecnica.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Empresa> Empresas { get; set; }

        // Crear la tabla Empresa en la base de datos (singular)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empresa>().ToTable("Empresa");
        }

        // Sobrescribir el método SaveChanges para actualizar las fechas de creación y modificación
        public override int SaveChanges()
        {
            var entries = ChangeTracker.Entries<Empresa>();

            foreach (var entry in entries)
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.FechaCreacion = DateTime.Now;
                    entry.Entity.FechaModificacion = DateTime.Now;
                }
                else if (entry.State == EntityState.Modified)
                {
                    entry.Entity.FechaModificacion = DateTime.Now;
                }
            }

            return base.SaveChanges();
        }
    }
}
