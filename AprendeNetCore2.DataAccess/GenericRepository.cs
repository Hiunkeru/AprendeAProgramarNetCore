using System;
using System.Collections.Generic;
using System.Text;

namespace AprendeNetCore2.DataAccess
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected NBAContext context;
        public GenericRepository(NBAContext ctx) => context = ctx;
        public virtual T Get(long id) { return context.Set<T>().Find(id); }
        public virtual IEnumerable<T> GetAll() { return context.Set<T>(); }

        public virtual void Create(T newDataObject) { context.Add<T>(newDataObject); }
        public virtual void Delete(long id) { context.Remove<T>(Get(id)); }
        public virtual void Update(T changedDataObject) { context.Update<T>(changedDataObject);}
    }
 }
