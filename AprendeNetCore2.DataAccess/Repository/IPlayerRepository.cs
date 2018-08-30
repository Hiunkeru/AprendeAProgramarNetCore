using AprendeNetCore2.DataAccess.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendeNetCore2.DataAccess.Repository
{
    public interface IPlayerRepository
    {
       Task<List<Players>> GetPlayers();

       Task<Players> GetPlayer(string name);
    }
}
