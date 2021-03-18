using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using DoctorWho.Db;

namespace DoctorWho
{
    class Program
    {
        private static DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();

        static void Main(string[] args)
        {
            //*All tested successfully*//

            //procedure
            _context.Database.ExecuteSqlRaw($"Exec dbo.spSummariseEpisodes");
            //view and functions within it
            var viewResult = _context.ViewEpisodes.ToList();
            Console.WriteLine($"count= {viewResult.Count}");
            viewResult.ForEach(r => Console.WriteLine(r.AuthorName));
            //Add element
            AuthorRepository authorRepository = new AuthorRepository();
            authorRepository.CreatAuthor("Waleed");
            //Update element
            CompanionRepository companionRepository = new CompanionRepository();
            companionRepository.UpdateCompanion(1, "Saad", "Saeed");
            //List elements
            DoctorRepository doctorRepository = new DoctorRepository();
            List<Doctor> doctors = doctorRepository.GetAllDoctors();
            doctors.ForEach(doctor => Console.WriteLine($"DoctorId={doctor.DoctorId}, DoctorName={doctor.DoctorName}"));
            //Add related elements
            EpisodeCompanionRepository episodeCompanionRepository = new EpisodeCompanionRepository();
            episodeCompanionRepository.AddCompanionToEpisode(4, 4);

            //*All tested successfully*//
        }
    }
}