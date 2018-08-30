using AprendeNetCore2.Application.Models;
using AprendeNetCore2.DataAccess.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendeNetCore2.Services.Contracts
{
    public interface IPlayerService
    {

        string GetName();

        Task<List<Players>> GetPlayers();

        Task<Players> GetPlayer(string name);

    }
}
