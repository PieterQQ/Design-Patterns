using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Autos
{
    public class NullCar : IAuto
    {
        public string Name {
            get {
                return string.Empty;
            }
        }

        public void TurnOff()
        {
            
        }

        public void TurnOn()
        {
         
        }
    }
}
