
using AprendeNetCore2.DataAccess;
using AprendeNetCore2.DataAccess.DBModels;
using AprendeNetCore2.DataAccess.Repository;
using AprendeNetCore2.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendeNetCore2.Application.Services
{
    public class PlayerService : IPlayerService
    {

        private IPlayerRepository _playerRepository;
        private IunitOfWork _unitOfWork;

        public PlayerService(IPlayerRepository playerRepo, IunitOfWork unitOfWork)
        {
            _playerRepository = playerRepo;
            _unitOfWork = unitOfWork;
        }

        public string GetName()
        {
            return "Michael Jordan";
        }

        public async Task<List<Players>> GetPlayers()
        {

            _unitOfWork.PlayerRepository.GetAll();
            _unitOfWork.Save();

            return await _playerRepository.GetPlayers();
        }

        public async Task<Players> GetPlayer(string name)
        {
            return await _playerRepository.GetPlayer(name);
        }
    }
}
