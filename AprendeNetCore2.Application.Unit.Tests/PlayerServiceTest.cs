using AprendeNetCore2.Application.Services;
using AprendeNetCore2.Application.Unit.Tests.MockRepository;
using AprendeNetCore2.DataAccess.Repository;
using AprendeNetCore2.Services.Contracts;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Threading.Tasks;

namespace AprendeNetCore2.Application.Unit.Tests
{
    [TestClass]
    public class PlayerServiceTest
    {

        private static IPlayerService _playerService;

        [ClassInitialize()]
        public static void Setup(TestContext context)
        {

            Mock<IPlayerRepository> _playerRepository = new PlayerRepositoryMock()._playerRepository;

            _playerService = new PlayerService(_playerRepository.Object);

        }

        //[TestInitialize]
        //public void Setup()
        //{


        //}


        [TestMethod]
        public async Task Dado_un_nombre_jugador_test_espero_un_id_igual_a_10()
        {

            var result = await _playerService.GetPlayer("test");

            result.Id.Should().Be(10);

        }

        [TestMethod]
        public async Task Dado_un_nombre_jugador_random_espero_un_id_igual_a_1()
        {

            var result = await _playerService.GetPlayer("Angel");

            result.Id.Should().Be(1);
        }

    }
}
