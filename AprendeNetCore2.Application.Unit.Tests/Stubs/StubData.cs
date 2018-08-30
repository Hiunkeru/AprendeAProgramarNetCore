using AprendeNetCore2.DataAccess.DBModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AprendeNetCore2.Application.Unit.Tests.Stubs
{
    public static class StubData
    {

        public static Players player_1 = new Players()
        {
            Age = 21,
            Id = 1,
            Name = "Michael",
            PlayerTeam = new Teams() { Id = 1, TeamName = "Chicago bulls" },
            PlayerTeamId = 1,
            Position = "Alero"
        };

        public static Players player_2 = new Players()
        {
            Age = 25,
            Id = 10,
            Name = "Jose",
            PlayerTeam = new Teams() { Id = 1, TeamName = "Nets" },
            PlayerTeamId = 1,
            Position = "Pivot"
        };

        public static List<Players> listPlayers = new List<Players>(new Players[] { player_1, player_2 });

    }
}
