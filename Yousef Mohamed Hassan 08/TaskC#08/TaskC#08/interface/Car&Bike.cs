using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskC_08.Interface
{
    internal class Car : IVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("engine is strat");
        }

        public void StopEngine()
        {
            Console.WriteLine("engine is stop");
        }
    }
    internal class Bike : IVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("engine is strat");
        }

        public void StopEngine()
        {
            Console.WriteLine("engine is stop");
        }
    }
}
