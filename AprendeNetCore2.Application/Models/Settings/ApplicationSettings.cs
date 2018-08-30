using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendeNetCore2.Application.Models.Settings
{
    public class ApplicationSettings
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Address Address { get; set; }
        public AppSettings Settings { get; set; }
    }

    
}
