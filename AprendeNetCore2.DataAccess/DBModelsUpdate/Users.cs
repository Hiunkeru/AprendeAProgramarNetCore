using System;
using System.Collections.Generic;

namespace AprendeNetCore2.DataAccess.DBModelsUpdate
{
    public partial class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Age { get; set; }
        public string City { get; set; }
    }
}
