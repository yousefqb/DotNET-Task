using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using static LINQ_01.ListGenerators;
namespace LINQ_01
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            #region Part 1
            //var y = 5;
            //var x = 5.5;
            //var z = true;
            //var g =new[] { 5, 6, 4, 2 };
            //Console.WriteLine(y.GetType().Name);
            //Console.WriteLine(x.GetType());
            //Console.WriteLine(z.GetType());
            //Console.WriteLine(g.GetType());

            //int y02 = 5;
            //double x02 = 5.5;
            //bool z02 = true;
            //int[] g02 = new[] { 5, 6, 4, 2 };
            //Console.WriteLine(y02.GetType().Name);
            //Console.WriteLine(x02.GetType());
            //Console.WriteLine(z02.GetType());
            //Console.WriteLine(g02.GetType());

            ///*
            //  Why is the result exactly the same at compile time?

            //  1. Type Inference: 'var' in C# is strongly typed, not dynamic. 
            //     The compiler inspects the right-hand side assignment at compile time 
            //     and infers the exact type.

            //  2. Identical IL Code: During compilation, the compiler replaces 'var' 
            //     with the explicit type name. Therefore, the resulting Intermediate 
            //     Language (IL) for both versions is 100% identical.

            //  3. Zero Performance Impact: Using 'var' has no performance or memory 
            //     overhead at runtime compared to explicit typing.
            // */ 
            #endregion

            #region Part 2

            //// 3-
            //var product01 = new { name = "airbods" , price = 500 ,quantity =10 };

            //Console.WriteLine(product01);

            //// 4-
            //var students = new[]
            //{
            //    new {name = "yousef", Grade = 100},
            //    new  {name = "mohaemd", Grade =90 },
            //    new  {name = "Hassan", Grade =80 }
            //};
            //foreach (var item in students)
            //{
            //    Console.WriteLine(item);
            //}

            //// 5- Bonus

            //var order = new { name = "airbods", price = 500, customer= new { name ="yousef" , city = "giza" } };

            //Console.WriteLine(order); 
            #endregion

            #region Part 3
            // 6- 

            //string text01 = "yousef";
            //string text02 = "LOL";
            //string text03 = "mohamed";
            //Console.WriteLine(text01.IsPalindrome());
            //Console.WriteLine(text02.IsPalindrome());
            //Console.WriteLine(text03.IsPalindrome());

            // 7-

            //int num01 = 5;
            //int num02 = 6;
            //int num03 = 7;
            //Console.WriteLine(num01.IsPrime());
            //Console.WriteLine(num02.IsPrime());
            //Console.WriteLine(num03.IsPrime());

            // 8- Bonus

            //int[] arr = { 1, 2, 3, 4, 5 };
            //Console.WriteLine(arr.Sum()); 
            #endregion

            #region Part 4

            // 9- 

            //List<string> emloyees = new List<string>() {"Yousef","mohamed","Hassan" };
            //foreach (string item in emloyees)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            ////adding
            //emloyees.Add("Faraj");
            //emloyees.Add("noop");
            //foreach (string item in emloyees)
            //{
            //    Console.Write(item+" ");
            //}
            //Console.WriteLine();
            ////removing
            //emloyees.Remove("noop");
            //foreach (string item in emloyees)
            //{
            //    Console.Write(item+" ");
            //}
            //Console.WriteLine();
            //string searchname = "mohamed";
            //string searchname02 = "hii";
            //search
            //foreach (string item in emloyees)
            //{
            //    if(searchname==item)
            //        Console.WriteLine("mohamed is here");
            //    if (searchname02 == item)
            //        Console.WriteLine("hi is here");
            //}

            // 10- 


            //List<Employee> employees= new List<Employee>() 
            //{
            //    new Employee(){Name="yousef",Salary=5000 },
            //    new Employee(){Name="Mohamed",Salary=6660 },
            //    new Employee(){Name="Hassan",Salary=8888 },
            //};
            //foreach (var item in employees)
            //{
            //    if (item.Salary > 6000)
            //        Console.WriteLine(item);
            //} 
            #endregion



        }
    }
}
