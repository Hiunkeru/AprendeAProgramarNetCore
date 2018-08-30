using System;
using System.Collections.Generic;

namespace AprendeNetCore2.DataAccess.DBModelsUpdate
{
    public partial class Empresas
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }

        public string Ejemplo { get; set;}
    }
}
