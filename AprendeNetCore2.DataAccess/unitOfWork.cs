using AprendeNetCore2.DataAccess.DBModels;
using AprendeNetCore2.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace AprendeNetCore2.DataAccess
{
    public class unitOfWork : IunitOfWork
    {

        //private PedidosRepository _pedidosRepository;
        //private ClienteRepository _clienteRepository;
        private NBAContext _context;
        private IGenericRepository<Players> _playerRepository;

        public unitOfWork(NBAContext context)
        {
            _context = context;
        }

        public IGenericRepository<Players> PlayerRepository
        {
            get
            {
                return _playerRepository = _playerRepository ?? new GenericRepository<Players>(_context);
            }
        }

        

        //public ClienteRepository ClienteRepo
        //{
        //    get
        //    {
        //        if(_clienteRepository == null)
        //        {
        //            _clienteRepository = new ClienteRepository(_context);
        //        }
        //        return _clienteRepository;
        //    }
        //}

        //public PedidosRepository PedidoRepo
        //{
        //    get
        //    {
        //        if (_pedidosRepository == null)
        //        {
        //            _pedidosRepository = new PedidosRepository(_context);
        //        }
        //        return _pedidosRepository;
        //    }
        //}

        public void Save()
        {
            _context.SaveChanges();
        }

    }
}
