using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AprendeNetCore2.Services;
using AprendeNetCore2.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using AprendeNetCore2.Application.Models;
using AprendeNetCore2.DataAccess.DBModels;
using Microsoft.Extensions.Caching.Memory;
using AprendeNetCore2.DataAccess;
using Swashbuckle.AspNetCore.Examples;
using AprendeNetCore2.Examples;
using Swashbuckle.AspNetCore.Annotations;

namespace AprendeNetCore2.Controllers
{

    public class RequestExample
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }

    [Route("api/[controller]")]
    public class ValuesController : Controller
    {

        private readonly IPlayerService _playerService;
        private readonly IMemoryCache _memoryCache;
        private readonly unitOfWork _unitOfWork;
        private readonly NBAContext _context;

        public ValuesController(IPlayerService playerService, IMemoryCache memoryCache, NBAContext _context)
        {

            unitOfWork _unitOfWork = new unitOfWork(_context);

            _playerService = playerService;
            _memoryCache = memoryCache;
        }


        [HttpGet]
        public IActionResult Add(string idproducto)
        {

            //_unitOfWork.ClienteRepo.Add(new Cliente());
            //_unitOfWork.PedidoRepo.Add(new Pedido());

            _unitOfWork.Save();

            return Ok();
        }

        //// GET api/values
        ///// <summary>
        ///// Get por idproducto
        ///// </summary>
        ///// <param name="idproducto"></param>
        ///// <returns></returns>
        //[HttpGet]      
        //public IEnumerable<string> Get(string idproducto)
        //{            

        //    return new string[] { "value1", "value2" };
        //}

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {

            MemoryCacheEntryOptions cacheExpirationOptions = new MemoryCacheEntryOptions();
            cacheExpirationOptions.AbsoluteExpiration = DateTime.Now.AddMinutes(30);
            cacheExpirationOptions.Priority = CacheItemPriority.Normal;

            //return _memoryCache.GetOrCreate("xxx", cacheEntry => {
            //    return _playerService.GetName();
            //});

            var prueba = _playerService.GetPlayers();

            return _playerService.GetName();
        }


        // GET api/values/5
        [HttpGet("players")]
        public async Task<IEnumerable<Players>> GetPlayers()
        {
            return await _playerService.GetPlayers();
        }

        // GET api/values/5
        [HttpGet("players2")]
        public async Task<IEnumerable<Players>> GetPlayers2()
        {
            return await _playerService.GetPlayers();
        }

        // GET api/values/5
        [HttpGet("players3")]
        public async Task<IEnumerable<Players>> GetPlayers3()
        {
            return await _playerService.GetPlayers();
        }

        /// <summary>
        /// Este metodo devuelve Jugadores
        /// </summary>
        /// <returns>Lista de Players</returns>
        /// <remarks>Informacion ampliada de jugadores de baloncesteo jajajsakjskajskajskenbenbenbrnebneb</remarks>
        /// <response code="200">Todo correcto</response>
        /// <response code="400">bad gatwate</response>
        [HttpGet("playersIAResult")]
        //[Produces("application/json",Type = typeof(Task<IEnumerable<Player>>))]
        [SwaggerResponse(200, "The list of players", typeof(IEnumerable<Player>))]
        public IActionResult GetPlayersIAResultult()
        {

            List<Player> players = new List<Player>();
            players.Add(new Player()
            {
                Age = 11,
                Id = 1,
                Name = "Michael Jordan",
                PlayerTeam = null,
                Position = "qasasa"
            });

            return Ok(players);
        }

        /// <summary>
        /// Este metodo devuelve Jugadores
        /// </summary>
        /// <returns>Lista de Players</returns>
        /// <remarks>Informacion ampliada de jugadores de baloncesteo jajajsakjskajskajskenbenbenbrnebneb</remarks>
        /// <response code="200">Todo correcto</response>
        /// <response code="400">bad gatwate</response>
        [HttpGet("playersIAResult2")]
        [Produces("application/json", Type = typeof(Task<IEnumerable<Player>>))]
        public IActionResult GetPlayersIAResultult2(string id)
        {

            if (string.IsNullOrEmpty(id))
            {
                return BadRequest();
            }

            List<Player> players = new List<Player>();
            players.Add(new Player()
            {
                Age = 11,
                Id = 1,
                Name = "Michael Jordan",
                PlayerTeam = null,
                Position = "qasasa"
            });

            return Ok(players);
        }

        /// <summary>
        /// Post de request
        /// </summary>
        /// <param name="value"></param>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }


        [HttpPost("example")]
        [SwaggerRequestExample(typeof(RequestExample),typeof(ExamplesSwaggerManual))]
        public void PostExample([FromBody]RequestExample request)
        {

        }

        [HttpPost("example2")]
        //[SwaggerRequestExample(typeof(RequestExample),typeof(ExamplesSwagger))]
        public void PostExample2([FromBody]RequestExample request)
        {

        }
    }
}
