using System;
using System.Collections.Generic;

namespace AprendeNetCore2.DataAccess.DBModels
{
    public partial class Players
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public int? PlayerTeamId { get; set; }
        public string Position { get; set; }

        public Teams PlayerTeam { get; set; }
    }
}
