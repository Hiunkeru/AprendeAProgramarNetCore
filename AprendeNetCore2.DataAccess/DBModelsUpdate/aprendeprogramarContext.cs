using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AprendeNetCore2.DataAccess.DBModelsUpdate
{
    public partial class aprendeprogramarContext : DbContext
    {
        public virtual DbSet<Empresas> Empresas { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=tcp:aprendeprogramar.database.windows.net,1433;Initial Catalog=aprendeprogramar;Persist Security Info=False;User ID=aprende;Password=eb97af51-9550-4cd4-87ed-a9eae95a6967;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empresas>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.City).HasColumnType("ntext");

                entity.Property(e => e.Name).HasColumnType("ntext");

                entity.Property(e => e.PostalCode).HasColumnType("ntext");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.Surname).HasColumnType("ntext");
            });
        }
    }
}
