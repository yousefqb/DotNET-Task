using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
        internal class Parent
        {
            private int x;

            private int y;

            public Parent(int _x, int _y)
            {
                x = _x;
                y = _y;
            }

            public int X
            {
                get { return x; }
                set { x = value; }
            }

            public int Y
            {
                get { return y; }
                set { y = value; }
            }

            public virtual int Product()
            {
            return (x*y);
            }
           public int sum()
           {
            return y * x ;
           }

        public override string ToString()
        {
           return $"x : {x} , Y : {y}";
        }

    }
        internal class Child : Parent
        {
            private int z;

            public Child(int _x, int _y, int _z) : base(_x, _y)
            {
                z = _z;
            }

            public int Z
            {
                get { return z; }
                set { z = value; }
            }

            public override string ToString()
            {
                 return $" x : {X} , Y : {Y} , Z : {z}  ";
            }

        public override int Product()
        {
            return X*Y*z;
        }

        public new int sum()
        {
            return X * Y * z;
        }






        }
    


}
