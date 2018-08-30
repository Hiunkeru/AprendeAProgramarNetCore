using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tweetinvi.Logic.DTO;

namespace AprendeNetCore2.Services.Contracts
{
    public interface ITweeterService
    {
        Task<List<TweetDTO>> GetTweets(string accountName);
    }
}
