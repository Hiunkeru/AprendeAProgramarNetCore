using System;
using System.Collections.Generic;

namespace AprendeNetCore2.DataAccess.DBModels
{
    public partial class Coachs
    {
        public int Id { get; set; }
        public int? CoachTeamId { get; set; }
        public string Name { get; set; }

        public Teams CoachTeam { get; set; }
    }
}
