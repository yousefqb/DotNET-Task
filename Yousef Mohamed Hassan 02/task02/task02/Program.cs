using System;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;

namespace task02
{
    class Person
    {
        public string Name;
        public int age;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region problem01
            //int x = 10;
            //int y = 20;
            ///* sum x + y
            //       10 +20 = 30
            //*/
            //int sum = x + y; // 20 + 10 = 30
            //Console.WriteLine(sum); 
            #endregion

            #region problem02

            ///* 
            //     int x = "10";   
            //     Console.WriteLine(x + y);   
            //     1- 'int' can only be used with numbers, and this is a string.
            //     2- Variable 'y' is not defined, you have to declare and initialize it.
            //     3- C# is case-sensitive, so the letter C in Console must be uppercase.
            //*/
            //int x = 10;
            //int y = 20;
            //Console.WriteLine(x + y); 
            #endregion

            #region problem03
            //string FullName = "Yousef Mohamed Hassan";
            //int Age = 20;
            //double Salary = 35000.55;
            //bool IsStudent = true; 
            #endregion

            #region problem04
            //Person person1 = new Person();
            //    person1.Name = "yousef";
            //    person1.age = 20;
            //Person person2 = new Person();
            //    person2.Name = "mohamed";
            //    person2.age = 30;
            //Console.WriteLine(person1.Name+person1.age); // output: yousef 20
            //Console.WriteLine(person2.Name + person2.age);// output: mohamed 30
            //person1 = person2;
            //person1.Name = "btnjan";
            //Console.WriteLine(person2.Name); // btnjan 
            #endregion

            #region problem05
            //int x = 15;
            //int y = 4;
            //Console.WriteLine("sum : " + (x + y) );
            //Console.WriteLine("Defference : " + (x - y));
            //Console.WriteLine("Product : " + (x * y));
            //Console.WriteLine("Division : " + (x / y));
            //Console.WriteLine("Reminder : " + (x % y)); 
            #endregion

            #region problem06
            //int x = int.Parse(Console.ReadLine());
            //if (x > 10 && x % 2 == 0)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("false");
            //} 
            #endregion

            #region problem07
            //double x = double.Parse(Console.ReadLine());
            //int y;
            //y = (int)x;
            //Console.WriteLine(x);
            //Console.WriteLine(y); 
            #endregion

            #region problem08
            //int age = int.Parse(Console.ReadLine());
            //if(age > 0)
            //{
            //    Console.WriteLine("valid");
            //}
            //else
            //{
            //    Console.WriteLine("not valid");
            //} 
            #endregion

            //int x = 10;
            //Console.WriteLine(x++);//10
            //Console.WriteLine(++x);//12
        }
    }
}
