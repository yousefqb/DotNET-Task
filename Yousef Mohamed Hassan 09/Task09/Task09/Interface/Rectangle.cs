using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task09.Interface
{
    internal struct Rectangle
    {
        public int Lenght { get; set; }
        public int Width { get; set; }

        public Rectangle(int _Lenght,int _Width)
        {
            Lenght = _Lenght;
            Width = _Width;
            
        }
        public void Swap(ref Rectangle other)
        {
            int Temp;
            Temp = Width;
            Width = other.Width;
            other.Width = Temp;
            Temp = Lenght;
            Lenght=other.Lenght;
            other.Lenght = Temp;
        }
        public override string ToString()
        {
            return $"Lenght : {Lenght} ,  Widht : {Width}";
        }
    }
}
