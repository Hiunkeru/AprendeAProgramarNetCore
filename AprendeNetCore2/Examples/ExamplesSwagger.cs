using AprendeNetCore2.Application.Models;
using AprendeNetCore2.Controllers;
using Swashbuckle.AspNetCore.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendeNetCore2.Examples
{
    public class ExamplesSwagger : IExamplesProvider<RequestExample>
    {
        public RequestExample GetExamples()
        {
            return new RequestExample()
            {

                Age = 23,
                Name = "Ejemplo",
                Surname = "Apellido Ejemplo"

            };
        }
    }

    public class ExamplesResponseSwagger : IExamplesProvider<Player>
    {
        public Player GetExamples()
        {
            return new Player()
            {

                Age = 23,
                Name = "Ejemplo",
                Id = 2,
                PlayerTeam = new Team() { Id = 1, TeamName = "Bulls" },
                Position = "Alero"

            };
        }
    }

    public class ExamplesResponseListPlayersSwagger : IExamplesProvider<IEnumerable<Player>>
    {
        public IEnumerable<Player> GetExamples()
        {

            var list = new List<Player>();


            var player1 = new Player()
            {

                Age = 23,
                Name = "Ejemplo",
                Id = 2,
                PlayerTeam = new Team() { Id = 1, TeamName = "Bulls" },
                Position = "Alero"

            };

            var player2 = new Player()
            {

                Age = 28,
                Name = "Ejemplo2",
                Id = 3,
                PlayerTeam = new Team() { Id = 2, TeamName = "Bulls2" },
                Position = "Alero2"

            };

            list.Add(player1);
            list.Add(player2);

            return list;
        }
    }


    public class ExamplesSwaggerManual : IExamplesProvider
    {
        public Object GetExamples()
        {
            return new RequestExample()
            {

                Age = 23,
                Name = "Ejemplo",
                Surname = "Apellido Ejemplo"

            };
        }
    }
}
