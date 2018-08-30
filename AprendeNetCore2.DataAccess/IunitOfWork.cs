using AprendeNetCore2.DataAccess.DBModels;
using AprendeNetCore2.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace AprendeNetCore2.DataAccess
{
    public interface IunitOfWork
    {
        IGenericRepository<Players> PlayerRepository { get; }
        void Save();

    }
}
