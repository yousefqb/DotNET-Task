using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskC_08.Interface
{
   internal abstract class GeometricShape
   {
        public double Dimen01 { get; set; }
        public double Dimen02 { get; set; }

        public GeometricShape(double _dim1, double _dim2)
        {
            Dimen01 = _dim1;
            Dimen02= _dim2;
        }
        public abstract double CalculateArea();

        public abstract double Perimeter { get; }


    }
    internal class Triangle : GeometricShape
    {
        public Triangle(double _dim1, double _dim2) : base(_dim1, _dim2) { }

        public override double CalculateArea()
        {
            return 0.5 * Dimen01 * Dimen02;
        }

        public override double Perimeter { get { return Dimen01 * Dimen02; } }
    }
    internal class Rectangle1 : GeometricShape
    {
        public Rectangle1(double _dim1, double _dim2) : base(_dim1, _dim2) { }
        public override double CalculateArea()
        {
            return Dimen01 * Dimen02;
        }

        public override double Perimeter { get { return 2* (Dimen01 + Dimen02); } }
    }

}
