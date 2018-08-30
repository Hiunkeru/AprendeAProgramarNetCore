using AprendeNetCore2.DataAccess.Repository;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace AprendeNetCore2.DataAccess.Unit.Tests
{
    [TestClass]
    public class PlayerTestRepository
    {

        private static IPlayerRepository _playerRepository;


        [ClassInitialize()]
        public static void Setup(TestContext context)
        {
            _playerRepository = new PlayerRepository(AddDataContext._context);
        }


        [TestMethod]
        public async Task TestMethod1()
        {

            var result = await _playerRepository.GetPlayer("Michael");

            result.Should().NotBeNull();

        }

        [TestMethod]
        public async Task TestMethod2()
        {

            var result = await _playerRepository.GetPlayer("Jose");

            result.Should().BeNull();

        }
    }
}
