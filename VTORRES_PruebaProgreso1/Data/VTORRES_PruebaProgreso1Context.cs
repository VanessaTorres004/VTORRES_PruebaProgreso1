using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VTORRES_PruebaProgreso1.Models;

namespace VTORRES_PruebaProgreso1.Data
{
    public class VTORRES_PruebaProgreso1Context : DbContext
    {
        public VTORRES_PruebaProgreso1Context (DbContextOptions<VTORRES_PruebaProgreso1Context> options)
            : base(options)
        {
        }

        public DbSet<VTORRES_PruebaProgreso1.Models.Celular> Celular { get; set; } = default!;
        public DbSet<VTORRES_PruebaProgreso1.Models.Torres> Torres { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuración para la entidad Torres
            modelBuilder.Entity<Torres>(entity =>
            {
                entity.HasKey(e => e.Id); // Definir la clave primaria
                entity.HasIndex(e => e.Cedula).IsUnique(); // Definir Cedula como único

                entity.Property(e => e.Cedula)
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.Salario)
                    .HasPrecision(18, 2); // Configurar precisión del salario

                // Otras configuraciones que necesites
            });

            // Configuración para la entidad Celular
            modelBuilder.Entity<Celular>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasMaxLength(100);
                entity.Property(e => e.Precio)
                    .HasPrecision(18, 2);
                entity.Property(e => e.year)
                    .HasMaxLength(4); // Suponiendo que el año es un número de 4 dígitos
            });
        }
    }
}
    

