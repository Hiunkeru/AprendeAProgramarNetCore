using AprendeNetCore2.DataAccess.DBModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendeNetCore2.DataAccess.Repository
{
    public class PlayerRepository : IPlayerRepository
    {

        private readonly INBAContext _dbContext;

        public PlayerRepository(INBAContext dbContext)
        {
            _dbContext = dbContext; 
        }

        public async Task<List<Players>> GetPlayers()
        {

            return await _dbContext.Players.Include(y=> y.PlayerTeam).Select(x => x).ToListAsync();
        }

        public async Task<Players> GetPlayer(string name)
        {
            return await _dbContext.Players.Where(x => x.Name == name).FirstOrDefaultAsync() ;
            
        }
    }
}
