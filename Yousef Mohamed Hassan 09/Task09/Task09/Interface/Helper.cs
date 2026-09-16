using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task09.Interface
{
    internal class Helper
    {
        public static T Max<T>(T va1,T val2) where T : IComparable<T>
        {
            if (va1.CompareTo(val2)>0) return va1;
            else return val2;
        }

    }
}
