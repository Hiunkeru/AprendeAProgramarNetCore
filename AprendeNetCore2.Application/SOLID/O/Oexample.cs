using System;
using System.Collections.Generic;
using System.Text;

namespace AprendeNetCore2.Application.SOLID.O
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Usuario
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Vendedor
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class PortalAcceso
    {
        public bool UserPuedeAcceder(Usuario user)
        {

            return true;
        }

        public bool AdminPuedeAcceder(Cliente user)
        {
            return true;
        }

        public bool VendedorPuedeAcceder(Vendedor user)
        {
            return true;
        }
    }
}
