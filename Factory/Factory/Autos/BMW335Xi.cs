using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Autos
{
    public class BMW335Xi : IAuto
    {
        public string Name {
            get 
            {
                return "BMW 335Xi";
            }
        }

        public void TurnOff()
        {
            Console.WriteLine("BMW jest wyłączone");
        }

        public void TurnOn()
        {
            Console.WriteLine("BMW jest włączone");
        }
    }
}
