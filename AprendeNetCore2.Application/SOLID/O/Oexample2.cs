using System;
using System.Collections.Generic;
using System.Text;

namespace AprendeNetCore2.Application.SOLID.O2
{
    public class UsuarioBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Cliente : UsuarioBase
    {

    }

    public class Usuario : UsuarioBase
    {

    }

    public class Vendedor : UsuarioBase
    {

    }


    public class PortalAcceso
    {
        public bool UserAcceder(UsuarioBase user)
        {

            return true;
        }


    }
}
