using System;
using System.Collections.Generic;
using System.Text;

namespace AprendeNetCore2.DataAccess
{
    public interface IGenericRepository<T> where T : class
    {
        T Get(long id);
        IEnumerable<T> GetAll();
        void Create(T newDataObject);
        void Update(T changedDataObject);
        void Delete(long id);
    }
}