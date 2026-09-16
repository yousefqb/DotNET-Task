using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task09.Interface
{
    internal class Circle : IComparable
    {
        public int Radius { get; set; }
        public string Color { get; set; }

        public Circle(int _Radius, string _Color)
        {
            Radius = _Radius;
            Color = _Color;
        }

        public int CompareTo(object obj)
        {
            Circle circle = obj as Circle;
            if (circle.Radius == Radius && circle.Color == Color)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
        public static bool operator ==(Circle left, Circle right) 
        {
            return (left.Color == right.Color && left.Radius == right.Radius);

        }
        public static bool operator !=(Circle left, Circle right)
        {
            return !(left.Color == right.Color && left.Radius == right.Radius);
        }

    }
}
