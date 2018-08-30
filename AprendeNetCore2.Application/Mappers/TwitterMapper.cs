using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tweetinvi.Logic;
using Tweetinvi.Logic.DTO;
using Tweetinvi.Models;

namespace AprendeNetCore2.Application.Mappers
{
    public static class TwitterMapper
    {

        public static List<TweetDTO> Map(IEnumerable<ITweet> tweets)
        {
            List<TweetDTO> lstTweets = new List<TweetDTO>();

            foreach (var tweet in tweets)
            {
                lstTweets.Add(new TweetDTO
                {
                    FullText = tweet.FullText
                });
            }

            return lstTweets;


        }

    }
}
