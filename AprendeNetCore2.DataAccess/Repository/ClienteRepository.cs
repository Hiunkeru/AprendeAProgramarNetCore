using AprendeNetCore2.DataAccess.DBModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AprendeNetCore2.DataAccess.Repository
{
    public class ClienteRepository
    {

        private readonly NBAContext _context;

        public ClienteRepository(NBAContext context)
        {
            _context = context;
        }

        public void Add(Cliente entity)
        {
            _context.Clientes.Add(entity);
        }

        public void Delete(Cliente entity)
        {
            _context.Clientes.Remove(entity);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }
}
