using System;
using Microsoft.EntityFrameworkCore;

namespace AprendeNetCore2.DataAccess.DBModels
{
    public partial class AprendeDBFirstContext : DbContext
    {
        public virtual DbSet<Coachs> Coachs { get; set; }
        public virtual DbSet<Players> Players { get; set; }
        public virtual DbSet<Teams> Teams { get; set; }


        public AprendeDBFirstContext(DbContextOptions<AprendeDBFirstContext> options) : base(options)
        {

        }

        //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //        {
        //            if (!optionsBuilder.IsConfigured)
        //            {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //                optionsBuilder.UseSqlServer(@"Server=tcp:aprendeprogramar.database.windows.net,1433;Initial Catalog=AprendeDBFirst;Persist Security Info=False;User ID=aprende;Password=4prendePr0gr4m4R;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        //            }
        //        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Coachs>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.CoachTeam)
                    .WithMany(p => p.Coachs)
                    .HasForeignKey(d => d.CoachTeamId);
            });

            modelBuilder.Entity<Players>(entity =>
            {
                entity.HasOne(d => d.PlayerTeam)
                    .WithMany(p => p.Players)
                    .HasForeignKey(d => d.PlayerTeamId);
            });
        }
    }
}
