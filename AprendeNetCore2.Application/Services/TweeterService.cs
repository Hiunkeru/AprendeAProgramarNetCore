using AprendeNetCore2.Application.Mappers;
using AprendeNetCore2.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tweetinvi;
using Tweetinvi.Logic.DTO;
using Tweetinvi.Models;

namespace AprendeNetCore2.Application.Services
{
    public class TweeterService : ITweeterService
    {


        public TweeterService()
        {
            var credentials = Auth.SetUserCredentials("oZNfFOMEbigmXXX1CEaXPsKv8", "9Yc8DBAXXXXTqj8sBP4le6EWBtpBSmwsvcx6DSHMuC9RixjKom", "1434XXX7-Jo5XXXOKjL2U394h2T7bfDIt4AlCXfq1qGVte", "AMfXXXX5O8KxoLx70E1sf3w0iWs8HFDl1SW");
            var user = User.GetAuthenticatedUser(credentials);
        }

        public async Task<List<TweetDTO>> GetTweets(string accountName)
        {
            var user = new UserIdentifier(accountName);

            var timeLine = await TimelineAsync.GetUserTimeline(user);

            return TwitterMapper.Map(timeLine);

        }

    }



}
