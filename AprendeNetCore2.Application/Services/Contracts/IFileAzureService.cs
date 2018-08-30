using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendeNetCore2.Services.Contracts
{
    public interface IFileAzureService
    {

       Task<string> GetText();

    }
}
