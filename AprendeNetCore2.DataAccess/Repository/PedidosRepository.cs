using AprendeNetCore2.DataAccess.DBModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AprendeNetCore2.DataAccess.Repository
{
    public class PedidosRepository 
    {

        private readonly NBAContext _context;

        public PedidosRepository(NBAContext context)
        {
            _context = context;
        }

        public void Add(Pedido entity)
        {
            _context.Pedidos.Add(entity);
        }

        public void Delete(Pedido entity)
        {
            _context.Pedidos.Remove(entity);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }
}
