using System;
using System.Collections.Generic;
using System.Text;

namespace AprendeNetCore2.Application.SOLID.I2
{
    interface IPuedeRodar
    {
        void Puederodar();
    }

    interface IPuedeVolar
    {
        void PuedeVolar();
    }

    interface IPuedenadar
    {
        void Puedenadar();
    }

    class Coche : IPuedeRodar
    {
        public void Puederodar()
        {

        }
    }

    class Barco : IPuedenadar
    {
        public void Puedenadar()
        {

        }
    }

    class Avion : IPuedeVolar
    {
        public void PuedeVolar()
        {

        }
    
    }

    class HidroAvion : IPuedeVolar, IPuedenadar
    {

        public void Puedenadar()
        {

        }

        public void PuedeVolar()
        {

        }
    }
}
