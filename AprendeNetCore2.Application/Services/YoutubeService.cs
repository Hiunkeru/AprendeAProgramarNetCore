using AprendeNetCore2.Application.Client;
using AprendeNetCore2.Application.Models;
using AprendeNetCore2.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendeNetCore2.Application.Services
{
    public class YoutubeService : IYoutubeService
    {

        private IYoutubeClient _youtubeClient;

        public YoutubeService(IYoutubeClient youtubeClient)
        {
            _youtubeClient = youtubeClient;
        }

        public async Task<Youtube> GetChannelInfo(string channelInfo)
        {

            var APIKey = "AIzaXXXXX-rZv-ZMIZZZZZnlIbabY";

            return await _youtubeClient.GetChannelAsync<Youtube>(channelInfo, APIKey);

        }

    }
}
