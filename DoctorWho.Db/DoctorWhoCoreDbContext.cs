using System;
using Microsoft.EntityFrameworkCore;

namespace DoctorWho.Db
{
    public class DoctorWhoCoreDbContext : DbContext
    {
        private readonly string connectionString =
        "Server=tcp:myserver-tamer.database.windows.net,1433;Initial Catalog=DoctorWhoCore;Persist Security Info=False;User ID=tamer;Password=kegsy5-mydmuj-Conxam;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public DbSet<Author> Authors { get; set; }
        public DbSet<Companion> Companions { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Enemy> Enemys { get; set; }
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<ViewEpisodes> ViewEpisodes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer(connectionString);
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EpisodeCompanion>().HasKey(e => new { e.EpisodeId, e.CompanionId });
            modelBuilder.Entity<EpisodeEnemy>().HasKey(e => new { e.EpisodeId, e.EnemyId });
            modelBuilder.Entity<ViewEpisodes>().HasNoKey().ToView("viewEpisodes");
            modelBuilder.Entity<Author>().HasData(
                new Author { AuthorId = 1, AuthorName = "tamer" },
                new Author { AuthorId = 2, AuthorName = "Fadi" },
                new Author { AuthorId = 3, AuthorName = "Mohannad" },
                new Author { AuthorId = 4, AuthorName = "Mohammed" },
                new Author { AuthorId = 5, AuthorName = "Ayman" }
            );
            modelBuilder.Entity<Companion>().HasData(
                new Companion { CompanionId = 5, CompanionName = "Samer", WhoPlayed = "Khalid" },
                new Companion { CompanionId = 1, CompanionName = "Emad", WhoPlayed = "Omar" },
                new Companion { CompanionId = 2, CompanionName = "Sameer", WhoPlayed = "Ward" },
                new Companion { CompanionId = 3, CompanionName = "Leen", WhoPlayed = "Roa" },
                new Companion { CompanionId = 4, CompanionName = "Naheel", WhoPlayed = "Sali" }
            );
            modelBuilder.Entity<Doctor>().HasData(
                new Doctor { DoctorId = 1, DoctorNumber = 0834676823, DoctorName = "John", BirthDate = new DateTime(19980601), FirstEpisodeDate = new DateTime(19980602), LastEpisodeDate = new DateTime(20120601) },
                new Doctor { DoctorId = 2, DoctorNumber = 0511385412, DoctorName = "Majd", BirthDate = new DateTime(18981201), FirstEpisodeDate = new DateTime(19981211), LastEpisodeDate = new DateTime(19990511) },
                new Doctor { DoctorId = 3, DoctorNumber = 0589135733, DoctorName = "Alaa", BirthDate = new DateTime(20000506), FirstEpisodeDate = new DateTime(20070706), LastEpisodeDate = new DateTime(20150113) },
                new Doctor { DoctorId = 4, DoctorNumber = 0399178240, DoctorName = "Nihad", BirthDate = new DateTime(19900714), FirstEpisodeDate = new DateTime(19950216), LastEpisodeDate = new DateTime(19970809) },
                new Doctor { DoctorId = 5, DoctorNumber = 0388528561, DoctorName = "Ali", BirthDate = new DateTime(19830417), FirstEpisodeDate = new DateTime(19880815), LastEpisodeDate = new DateTime(19980205) }
            );
            modelBuilder.Entity<Enemy>().HasData(
                new Enemy { EnemyId = 1, EnemyName = "Suha", Description = "an evil one" },
                new Enemy { EnemyId = 2, EnemyName = "Jameel", Description = "a cute one" },
                new Enemy { EnemyId = 3, EnemyName = "Jamal", Description = "the wildest" },
                new Enemy { EnemyId = 4, EnemyName = "Areen", Description = "Unexpected one" },
                new Enemy { EnemyId = 5, EnemyName = "Yazan", Description = "As the fire" }
            );
            modelBuilder.Entity<Episode>().HasData(
                new Episode { EpisodeId = 1, SeriesNumber = 432, EpisodeNumber = 565, EpisodeType = "Action", Title = "Fast & Furios", EpisodeDate = new DateTime(20210414), Notes = "best car drifting", AuthorId = 2, DoctorId = 2 },
                new Episode { EpisodeId = 2, SeriesNumber = 433, EpisodeNumber = 112, EpisodeType = "Fancy", Title = "The Game", EpisodeDate = new DateTime(20150502), Notes = "back to worldwide war 2", AuthorId = 4, DoctorId = 3 },
                new Episode { EpisodeId = 3, SeriesNumber = 766, EpisodeNumber = 629, EpisodeType = "Funny", Title = "GOT", EpisodeDate = new DateTime(20131204), Notes = "loved by people", AuthorId = 5, DoctorId = 1 },
                new Episode { EpisodeId = 4, SeriesNumber = 551, EpisodeNumber = 257, EpisodeType = "Thriller", Title = "Prison Break", EpisodeDate = new DateTime(20001123), Notes = "An exciting one", AuthorId = 1, DoctorId = 2 },
                new Episode { EpisodeId = 5, SeriesNumber = 984, EpisodeNumber = 391, EpisodeType = "Mystrey", Title = "You", EpisodeDate = new DateTime(20180512), Notes = "psychopath lover", AuthorId = 1, DoctorId = 3 }
            );
            modelBuilder.Entity<EpisodeEnemy>().HasData(
                new EpisodeEnemy { EpisodeId = 3, EnemyId = 4 },
                new EpisodeEnemy { EpisodeId = 1, EnemyId = 1 },
                new EpisodeEnemy { EpisodeId = 5, EnemyId = 2 },
                new EpisodeEnemy { EpisodeId = 1, EnemyId = 3 },
                new EpisodeEnemy { EpisodeId = 4, EnemyId = 3 }
            );
            modelBuilder.Entity<EpisodeCompanion>().HasData(
                new EpisodeCompanion { EpisodeId = 2, CompanionId = 5 },
                new EpisodeCompanion { EpisodeId = 3, CompanionId = 1 },
                new EpisodeCompanion { EpisodeId = 5, CompanionId = 2 },
                new EpisodeCompanion { EpisodeId = 1, CompanionId = 3 },
                new EpisodeCompanion { EpisodeId = 4, CompanionId = 3 }
            );
        }
    }
}
