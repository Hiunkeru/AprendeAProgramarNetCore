using AprendeNetCore2.Application.Unit.Tests.Stubs;
using AprendeNetCore2.DataAccess.Repository;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace AprendeNetCore2.Application.Unit.Tests.MockRepository
{
    public class PlayerRepositoryMock
    {

        public Mock<IPlayerRepository> _playerRepository { get; set; }

        public PlayerRepositoryMock()
        {
            _playerRepository = new Mock<IPlayerRepository>();
            Setup();
        }

        private void Setup()
        {
            _playerRepository.Setup((x) => x.GetPlayer(It.IsAny<string>())).ReturnsAsync(StubData.player_1);
            _playerRepository.Setup((x) => x.GetPlayer("test")).ReturnsAsync(StubData.player_2);
            _playerRepository.Setup((x) => x.GetPlayers()).ReturnsAsync(StubData.listPlayers);
        }

    }
}
