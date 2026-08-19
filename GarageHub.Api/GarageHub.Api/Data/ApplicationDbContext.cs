using GarageHub.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace GarageHub.Api.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Lugar> Lugares { get; set; }
        public DbSet<Estadia> Estadias { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Vehiculo>(entity =>
            {
                entity.HasIndex(v => v.Patente).IsUnique();
                entity.Property(v => v.Patente).HasMaxLength(15);
                entity.Property(v => v.Marca).HasMaxLength(50);
                entity.Property(v => v.Modelo).HasMaxLength(50);
            });

            modelBuilder.Entity<Lugar>(entity =>
            {
                entity.HasIndex(l => l.Codigo).IsUnique();
                entity.Property(l => l.Codigo).HasMaxLength(10);
            });
        }

    }
}
