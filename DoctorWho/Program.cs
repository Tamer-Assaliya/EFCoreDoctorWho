using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using DoctorWho.Db;

namespace DoctorWho
{
    class Program
    {
        private static DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();
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