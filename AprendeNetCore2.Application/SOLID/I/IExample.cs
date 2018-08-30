using System;
using System.Collections.Generic;
using System.Text;

namespace AprendeNetCore2.Application.SOLID.I
{
    interface ICaracteristica
    {
        void PuedeRodar();
        void PuedeVolar();
        void PuedeNadar();
    }

    class Coche : ICaracteristica
    {
        public void PuedeRodar()
        {

        }

        public void PuedeVolar()
        {
            throw new Exception("No No");
        }

        public void PuedeNadar()
        {
            throw new Exception("No NO");
        }
    }

    class Avion : ICaracteristica
    {
        public void PuedeRodar()
        {
            throw new Exception("No NO");
        }

        public void PuedeVolar()
        {
           
        }

        public void PuedeNadar()
        {
            throw new Exception("No NO");
        }
    }

    class Barco : ICaracteristica
    {
        public void PuedeRodar()
        {
            throw new Exception("No NO");
        }

        public void PuedeVolar()
        {
            throw new Exception("No No");
        }

        public void PuedeNadar()
        {
            
        }
    }
}
