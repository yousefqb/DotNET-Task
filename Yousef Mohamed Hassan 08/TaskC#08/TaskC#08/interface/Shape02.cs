using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskC_08.Interface
{
    class Shape02 : IComparable
    {
        public string Name { get; set; }
        public double Area { get; set; }

        public Shape02(string _Name , double _Area)
        {
            Name = _Name;
            Area = _Area;
        }


        public int CompareTo(object shap)
        {
            Shape02 other = (Shape02) shap;
            if (this.Area < other.Area)
            {
                return 1;
            }
            else if(this.Area > other.Area) 
            {
                return -1;
            }
            else 
            { 
                return 0;
            }
        }
        public override string ToString()
        {
            return $" name of shabe : {Name} , area : {Area}";
        }
    }
}
