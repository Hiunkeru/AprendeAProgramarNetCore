using AprendeNetCore2.DataAccess.DBModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AprendeNetCore2.DataAccess.Unit.Tests
{
    public class AddDataContext
    {

        public static NBAContext _context;

        public static void PrepareContext()
        {

            var options = new DbContextOptionsBuilder<NBAContext>().UseInMemoryDatabase(databaseName: "nbaDB").Options;

            _context = new NBAContext(options);

            PreparePlayers();

            _context.SaveChanges();
        }

        private static void PreparePlayers()
        {
            _context.Add(new Players()
            {
                Age = 21,
                Name = "Michael",
                PlayerTeam = new Teams()
                {
                    TeamName = "Chicago",
                    Id = 1
                },
                Position = "Alero"           
            });
        }

    }
}
