using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AprendeNetCore2.Services;
using AprendeNetCore2.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using AprendeNetCore2.Application.Models;

namespace AprendeNetCore2.Controllers
{


    //[Authorize]
    [Route("api/[controller]")]
    public class YoutubeController : Controller
    {

        private readonly IYoutubeService _youtubeService;

        public YoutubeController(IYoutubeService youtubeService)
        {
            _youtubeService = youtubeService;
        }


        [HttpGet]      
        public async Task<Youtube> GetChannelInfo(string idChannel)
        {

            return await _youtubeService.GetChannelInfo(idChannel);
        }

        
    }
}
