using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Autos
{
    public interface IAuto
    {
         string Name { get;}
        void TurnOn();
        void TurnOff();

    }
   
}
