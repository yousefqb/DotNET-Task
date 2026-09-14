using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskC_08.Interface
{
    internal abstract class Shape
    {
        public abstract double GetArea();
        public void Display() 
        {
            Console.WriteLine($"this shape is {this.GetType()}");
        }

    }
    internal class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double _width, double _height)
        {
            Width = _width;
            Height = _height;
        }
        public override double GetArea()
        {
            return Width * Height;
        }
    }
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    interface IShape
    {
        double GetArea();
        void Display();
    }

    class RectangleInter : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public RectangleInter(double _width, double _height)
        {
            Width = _width;
            Height = _height;
        }

        public double GetArea() 
        { 
            return Width * Height ;
        }

        public void Display()
        {
            Console.WriteLine($"This is a Rectangle , Area: {GetArea()}");
        }
    }

    class CircleInterface : IShape
    {
        public double Radius { get; set; }

        public CircleInterface(double radius)
        {
            Radius = radius;
        }

        public double GetArea() { return Math.PI * Radius * Radius; }

        public void Display()
        {
            Console.WriteLine($"This is a Circle , Area: {GetArea()}");
        }
    }

}
