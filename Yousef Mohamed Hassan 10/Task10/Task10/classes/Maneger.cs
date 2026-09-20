using System;
using System.Collections.Generic;
using System.Text;

namespace Task10.classes
{
    internal class Maneger : Employee , IComparable<Maneger>
    {
        public int CompareTo(Maneger passed)
        {
            if (Salary > passed.Salary)
                return 1;
            else if (Salary < passed.Salary)
                return -1;
            else
                return 0;
        }
    }
}
