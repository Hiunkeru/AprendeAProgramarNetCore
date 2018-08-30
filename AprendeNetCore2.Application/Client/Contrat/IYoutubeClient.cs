using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendeNetCore2.Application.Client
{
    public interface IYoutubeClient
    {
        Task<T> GetChannelAsync<T>(string channerId, string APIKey);
    }
}
