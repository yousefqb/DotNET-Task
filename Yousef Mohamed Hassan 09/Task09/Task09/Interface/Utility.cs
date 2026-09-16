using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Task09.Interface
{
    public static class Utility
    {
        private const double pi = 3.14;

        public static double Pi
        {
            get { return pi; }

        }
        public static double CmToInch(double cm)
        {
            return cm / 2.54;
        }
        public static double CalcCircleArea(double Radius)
        {
            return Pi * Radius * Radius;
        }
        public static double perimeterRectangle(double height, double weight)
        {
            return height * weight;
        }

        public static double converttemperatures(double cel) 
        {
            return cel * 5.15;
        } 
        
    }
}
