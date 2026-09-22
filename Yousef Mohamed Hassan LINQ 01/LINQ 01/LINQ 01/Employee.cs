using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_01
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }

        public override string ToString()
        {
            return$"Name : {Name} , Salary : {Salary} ";
        }

    }
}
