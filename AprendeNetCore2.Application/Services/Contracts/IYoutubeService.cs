
using AprendeNetCore2.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendeNetCore2.Services.Contracts
{
    public interface IYoutubeService
    {
        Task<Youtube>GetChannelInfo(string channelInfo);
    }
}
