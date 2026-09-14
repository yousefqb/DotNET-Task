using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskC_08.Interface
{
    class Robot : IWalkable
    {
        void IWalkable.Walk()
        {
            Console.WriteLine("the robot is walk");
        }
    }
}
