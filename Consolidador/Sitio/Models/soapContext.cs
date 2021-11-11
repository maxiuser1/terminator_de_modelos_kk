using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Sitio.ViewModels;

namespace Sitio.Models
{
    public partial class SoapContext : DbContext
    {
        public SoapContext()
        {
        }

        public SoapContext(DbContextOptions<SoapContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Consolidacion> Consolidacion { get; set; }
        public virtual DbSet<ItemConsolidacion> ItemConsolidacion { get; set; }
        public virtual DbSet<Marcas> Marcas { get; set; }
        public virtual DbSet<Modelos> Modelos { get; set; }
        public virtual DbSet<TiposVehiculos> TiposVehiculos { get; set; }
        public virtual DbSet<Vehiculos> Vehiculos { get; set; }
        public virtual DbQuery<ItemModelo> ItemsModelo { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=Soap;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Consolidacion>(entity =>
            {
                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.NuevoNombreMarca)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NuevoNombreModelo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NuevoNombreTipoVehiculo)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ItemConsolidacion>(entity =>
            {
                entity.Property(e => e.NombreMarca)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NombreModelo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NombreTipoVehiculo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Consolidacion)
                    .WithMany(p => p.ItemConsolidacion)
                    .HasForeignKey(d => d.ConsolidacionId)
                    .HasConstraintName("FK_ItemConsolidacion_Consolidacion");
            });

            modelBuilder.Entity<Marcas>(entity =>
            {
                entity.HasKey(e => e.IdMarca)
                    .HasName("PK__Marcas__4076A8877DCDAAA2");

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.Nombre).IsUnicode(false);
            });

            modelBuilder.Entity<Modelos>(entity =>
            {
                entity.HasKey(e => e.IdModelo)
                    .HasName("PK__Modelos__CC30D30C019E3B86");

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.Nombre).IsUnicode(false);
            });

            modelBuilder.Entity<TiposVehiculos>(entity =>
            {
                entity.HasKey(e => e.IdTipoVehiculo)
                    .HasName("PK__TiposVeh__DC20741E79FD19BE");

                entity.Property(e => e.Alias).IsUnicode(false);

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.Nombre).IsUnicode(false);
            });

            modelBuilder.Entity<Vehiculos>(entity =>
            {
                entity.HasKey(e => e.Idvehiculo)
                    .HasName("PK__Vehiculo__07A855366EC0713C");

                entity.Property(e => e.Idvehiculo).HasColumnName("IDvehiculo");

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.DigitoVerificadorPatente)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.NumeroMotor).IsUnicode(false);

                entity.Property(e => e.NumeroPatente)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
