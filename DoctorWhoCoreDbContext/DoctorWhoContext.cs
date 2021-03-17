using System;
using Microsoft.EntityFrameworkCore;
using DoctorWho.Db;

namespace DoctorWhoCoreDbContext
{
    public class DoctorWhoContext : DbContext
    {
        private readonly string connectionString =
        "Server=tcp:myserver-tamer.database.windows.net,1433;Initial Catalog=DoctorWhoCore;Persist Security Info=False;User ID=tamer;Password=kegsy5-mydmuj-Conxam;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public DbSet<Author> Authors { get; set; }
        public DbSet<Companion> Companions { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Enemy> Enemys { get; set; }
        public DbSet<Episode> Episodes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer(connectionString);
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EpisodeCompanion>().HasKey(e => new { e.EpisodeId, e.CompanionId });
            modelBuilder.Entity<EpisodeEnemy>().HasKey(e => new { e.EpisodeId, e.EnemyId });
        }
    }
}
