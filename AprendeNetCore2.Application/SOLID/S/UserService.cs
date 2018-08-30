using System;
using System.Collections.Generic;
using System.Text;

namespace AprendeNetCore2.Application.SOLID.S
{
    public class UserService
    {

        PedidosService _pedidosService;

        public UserService(PedidosService pedidosService)
        {
            _pedidosService = pedidosService;
        }

        public void GetNombre()
        {

        }


        private int GetNumeroPedidosUsuario(int userid)
        {
            return _pedidosService.GetNumeroPedidos(userid);
        }


    }
}
