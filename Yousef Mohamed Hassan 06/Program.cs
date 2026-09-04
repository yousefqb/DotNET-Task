using System;

namespace ConsoleApp3
{
    //*******problem01***********
    public struct point
    {
        public int x { get; set; }
        public int y { get; set; }
        public override string ToString() {return $" x : {x} , y : {y}  ";}
    }

    //********problem02**********
    public class TypeA {
        public int H;
        internal int G;
        private int f;
        public void F(int f) {this.f = f;} }

    //*******problem03************
    public struct Employee
    {
        private int empid;
        private string name;
        public int salary { get; set; }

        public void setname(string _name)
        {
            name = _name;
        }
        public string getname()
        {
           return name ;
        }

        public int Empid 
        { 
            get { return empid; } 
            set { empid = value; }
        }
    }

    //********problem04***********
    public struct point04
    {
        private int x;
        private int y;

        public point04(int _x)
        {
            x= _x;
            y = 0;
        }
        public point04(int _x,int _y)
        {
            x = _x;
            y = _y;
        }

        public override string ToString() { return $" x : {x} , y : {y}  "; }
    }

    //********problem05***********

    public struct point05
    {
        public int x {get;set;}
        public int y { get; set;}
        public override string ToString() { return $" x : {x} , y : {y}  "; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region problem01
            //point p1 = new point();
            //p1.x = 6;
            //p1.y = 7;
            //Console.WriteLine(p1); 
            #endregion

            #region problem02
            //TypeA Aa = new TypeA();
            //Aa.G = 5;
            //Aa.H = 6;
            //Aa.F(7); 
            #endregion

            #region problem03
            //Employee emp01 = new Employee();
            //emp01.salary = 10;
            //emp01.setname("yousef");
            //emp01.Empid = 1;
            //Console.WriteLine($"emp id : {emp01.Empid} name : {emp01.getname()} salary : {emp01.salary} "); 
            #endregion

            #region problem04
            //point04 poin = new point04(5);
            //point04 poin2 = new point04(7,7);
            //Console.WriteLine(poin);
            //Console.WriteLine(poin2);
            #endregion

            #region problem05
            //point05 po = new point05();
            //po.x = 1;
            //po.y = 2;
            //Console.WriteLine(po); 
            #endregion


        }
    }
}
