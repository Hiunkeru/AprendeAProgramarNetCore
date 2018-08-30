using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AprendeNetCore2.Services;
using AprendeNetCore2.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Tweetinvi.Logic.DTO;

namespace AprendeNetCore2.Controllers
{


    //[Authorize]
    [Route("api/[controller]")]
    public class TweeterController : Controller
    {

        private readonly ITweeterService _tweeterService;

        public TweeterController(ITweeterService tweeterService)
        {
            _tweeterService = tweeterService;
        }


        [HttpGet]      
        public async Task<List<TweetDTO>> GetTweets(string accountname)
        {

            return await _tweeterService.GetTweets(accountname);


        }

        
    }
}
