using AprendeNetCore2.DataAccess.DBModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendeNetCore2.DataAccess
{
    public class NBAContext : DbContext ,INBAContext
    {

        public NBAContext(DbContextOptions<NBAContext> options) : base(options)
        {

        }

        public DbSet<Players> Players { get; set; }
        public DbSet<Teams> Teams { get; set; }
        public DbSet<Coachs> Coachs { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
