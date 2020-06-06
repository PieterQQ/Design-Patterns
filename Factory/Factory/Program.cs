using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Autos;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = string.Empty;
            if(args.Length>0)
             name = args[0];
            AutoFactory factory = new AutoFactory();
            IAuto car = factory.GetAuto(name);
            //IAuto car = GetCar(name);
            car.TurnOn();
            car.TurnOff();
            Console.ReadKey();
        }
        //rozwiązanie z przykladu 1 -złe
        //static IAuto GetCar(string carName)
        //{
        //    switch (carName)
        //    {
        //        case "bmw":
        //            return new BMW335Xi();
        //        case "mini":
        //            return new MiniCooper();
        //        case "Audi":
        //            return new AudiTT();
        //        default:
        //            return new NullCar();
        //            break;
        //    }
        //}
    }
}
