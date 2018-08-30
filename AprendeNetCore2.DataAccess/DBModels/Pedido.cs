using System;
using System.Collections.Generic;

namespace AprendeNetCore2.DataAccess.DBModels
{
    public partial class Pedido
    {
        public Pedido()
        {
            Coachs = new HashSet<Coachs>();
            Players = new HashSet<Players>();
        }

        public int Id { get; set; }
        public string TeamName { get; set; }

        public ICollection<Coachs> Coachs { get; set; }
        public ICollection<Players> Players { get; set; }
    }
}
