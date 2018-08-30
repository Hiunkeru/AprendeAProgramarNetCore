using FluentAssertions;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace AprendeNetCore.Integration.Tests
{
    [TestClass]
    public class Given_ValuesController
    {

        private readonly TestServer _server;
        private readonly HttpClient _client;

        public Given_ValuesController()
        {
            _server = new TestServer(WebHost.CreateDefaultBuilder().UseStartup<Startup>());
            _client = _server.CreateClient();
        }

        [TestMethod]
        public async Task Given_Id_Expect_players_names_should_not_null()
        {

            //Arrange
            var response = await _client.GetAsync("/api/values/playersIAResult");

            //Assert
            Assert.IsTrue((int)response.StatusCode == 200);

            //FluentAssertions
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [TestMethod]
        public async Task Given_Id_Expect_players_names_should_bad_request()
        {

            //Arrange
            var response = await _client.GetAsync("/api/values/playersIAResult2");

            //FluentAssertions
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }

    }
}
