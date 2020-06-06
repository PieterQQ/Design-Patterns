using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Autos
{
   public  class AudiTT:IAuto
    {
        public string Name {
            get {
                return "Audi TT";
            }
        }

        public void TurnOff()
        {
            Console.WriteLine("Audi jest wyłączone");
        }

        public void TurnOn()
        {
            Console.WriteLine("Audi jest włączone");
        }
    }
}
