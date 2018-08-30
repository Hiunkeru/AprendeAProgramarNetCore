using System;
using System.Collections.Generic;
using System.Text;

namespace AprendeNetCore2.Application.SOLID.L
{
    public  class Coche2016 : Coche2015
    {

        public override int Velocidad()
        {
            return 200;
        }

    }

    public class Coche2017 : Coche2015
    {

        public override int Velocidad()
        {
            return 220;
        }

        public void ejemplo()
        {
            Coche2015 coche1 = new Coche2016();
            var v = coche1.Velocidad();

            Coche2015 coche2 = new Coche2017();
            var v2 = coche2.Velocidad();
        }

    }
}
