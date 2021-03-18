using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using DoctorWho.Db;

namespace DoctorWho
{
    class Program
    {
        private static DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();

        public void CreatCompanion(string name, string whoPlayed)
        {
            var companion = new Companion() { CompanionName = name, WhoPlayed = whoPlayed };
            _context.Companions.Add(companion);
            _context.SaveChanges();
        }

        public void UpdateCompanion(int id, string name, string whoPlayed)
        {
            var companion = _context.Find<Companion>(id);
            companion.CompanionName = name;
            companion.WhoPlayed = whoPlayed;
            _context.SaveChanges();
        }

        public void DeleteCompanion(int id)
        {
            var companion = _context.Find<Companion>(id);
            _context.Remove<Companion>(companion);
        }

        public void CreatEnemy(string name, string description)
        {
            var enemy = new Enemy() { EnemyName = name, Description = description };
            _context.Enemys.Add(enemy);
            _context.SaveChanges();
        }

        public void UpdateEnemy(int id, string name, string description)
        {
            var enemy = _context.Find<Enemy>(id);
            enemy.EnemyName = name;
            enemy.Description = description;
            _context.SaveChanges();
        }

        public void DeleteEnemy(int id)
        {
            var enemy = _context.Find<Enemy>(id);
            _context.Remove<Enemy>(enemy);
            _context.SaveChanges();
        }

        public void CreatDoctor(string name, int number, DateTime birthDate, DateTime firstEpisodeDate, DateTime lastEpisodeDate)
        {
            var doctor = new Doctor() { DoctorName = name, DoctorNumber = number, BirthDate = birthDate, FirstEpisodeDate = firstEpisodeDate, LastEpisodeDate = lastEpisodeDate };
            _context.Doctors.Add(doctor);
            _context.SaveChanges();
        }

        public void UpdateDoctor(int id, string name, int number, DateTime birthDate, DateTime firstEpisodeDate, DateTime lastEpisodeDate)
        {
            var doctor = _context.Find<Doctor>(id);
            doctor.DoctorName = name;
            doctor.DoctorNumber = number;
            doctor.BirthDate = birthDate;
            doctor.FirstEpisodeDate = firstEpisodeDate;
            doctor.LastEpisodeDate = lastEpisodeDate;
            _context.SaveChanges();
        }

        public void DeleteDoctor(int id)
        {
            var doctor = _context.Find<Doctor>(id);
            _context.Remove<Doctor>(doctor);
            _context.SaveChanges();
        }

        public void CreatAuthor(string name)
        {
            var author = new Author() { AuthorName = name };
            _context.Add<Author>(author);
            _context.SaveChanges();
        }

        public void UpdateAuthor(int id, string name)
        {
            var author = _context.Find<Author>(id);
            author.AuthorName = name;
            _context.SaveChanges();
        }

        public void DeleteAuthor(int id)
        {
            var author = _context.Find<Author>(id);
            _context.Remove<Author>(author);
            _context.SaveChanges();
        }

        public void CreatEpisode(int seriesNumber, int episodeNumber, string episodeType, string title, DateTime episodeDate, int? authorId, int? doctorId, string notes)
        {
            var episode = new Episode()
            {
                AuthorId = authorId,
                DoctorId = doctorId,
                EpisodeDate = episodeDate,
                EpisodeNumber = episodeNumber,
                EpisodeType = episodeType,
                Notes = notes,
                SeriesNumber = seriesNumber,
                Title = title
            };
            _context.Add<Episode>(episode);
            _context.SaveChanges();
        }

        public void UpdateEpisode(int id, int seriesNumber, int episodeNumber, string episodeType, string title, DateTime episodeDate, int? authorId, int? doctorId, string notes)
        {
            var episode = _context.Find<Episode>(id);
            episode.AuthorId = authorId;
            episode.DoctorId = doctorId;
            episode.EpisodeDate = episodeDate;
            episode.EpisodeNumber = episodeNumber;
            episode.EpisodeType = episodeType;
            episode.Notes = notes;
            episode.SeriesNumber = seriesNumber;
            episode.Title = title;
            _context.SaveChanges();
        }

        public void DeleteEpisode(int id)
        {
            var episode = _context.Find<Episode>(id);
            _context.Remove<Episode>(episode);
            _context.SaveChanges();
        }

        public void AddEnemyToEpisode(int enemyId, int episodeId)
        {
            var episodeEnemy = new EpisodeEnemy() { EnemyId = enemyId, EpisodeId = episodeId };
            _context.Add<EpisodeEnemy>(episodeEnemy);
            _context.SaveChanges();
        }

        public void AddCompanionToEpisode(int companionId, int episodeId)
        {
            var episodeCompanion = new EpisodeCompanion() { CompanionId = companionId, EpisodeId = episodeId };
            _context.Add<EpisodeCompanion>(episodeCompanion);
            _context.SaveChanges();
        }

        public List<Doctor> GetAllDoctors()
        {
            var doctors = _context.Doctors.FromSqlRaw("SELECT * FROM Doctors").ToList();
            return doctors;
        }

        public Enemy GetEnemyById(int id)
        {
            var enemy = _context.Enemys.Find(id);
            return enemy;
        }

        public Companion GetCompanionById(int id)
        {
            var companion = _context.Companions.Find(id);
            return companion;
        }

        static void Main(string[] args)
        {
            //procedure
            _context.Database.ExecuteSqlRaw($"Exec dbo.spSummariseEpisodes");
            //view and functions within it
            var viewResult = _context.ViewEpisodes.ToList();
            Console.WriteLine($"count= {viewResult.Count}");
            viewResult.ForEach(r => Console.WriteLine(r.AuthorName));
        }
    }
}