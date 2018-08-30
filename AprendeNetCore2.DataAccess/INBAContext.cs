
using AprendeNetCore2.DataAccess.DBModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendeNetCore2.DataAccess
{
    public interface INBAContext 
    {
        DbSet<Players> Players { get; set; }
        DbSet<Teams> Teams { get; set; }
        DbSet<Coachs> Coachs { get; set; }
        DbSet<Pedido> Pedidos { get; set; }
        DbSet<Cliente> Clientes { get; set; }

    }
}
