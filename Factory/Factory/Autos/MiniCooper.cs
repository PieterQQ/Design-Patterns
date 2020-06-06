using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Autos
{
   public class MiniCooper:IAuto
    {
        public string Name {
            get {
                return "MiniCooper";
            }
        }

        public void TurnOff()
        {
            Console.WriteLine("MiniCooper jest wyłączone");
        }

        public void TurnOn()
        {
            Console.WriteLine("MiniCooper jest włączone");
        }
    }
}
