using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MartialArtsClub.Data.Models;


namespace MartialArtsClub.Data.Respository
{
    class TimetableDBContext : DbContext
    {
        public TimetableDBContext()
        {
        }

        public TimetableDBContext(DbContextOptions<TimetableDBContext> options)
            : base(options)
        {
        }

        public DbSet<Timetable> Classes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MSSQLLocalDB;Trusted_Connection=True;");
        }

        public void Initialise()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

    }
}
