using System;
using System.Linq;
using static Linq02.ListGenerators;
namespace Linq02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators
            // 1-

            //var Res01 = ProductList.Where((P) => P.UnitsInStock == 0);
            //foreach (var item in Res01)
            //{
            //    Console.WriteLine(item);
            //}

            // 2-

            //var Res02 = ProductList.Where((p) => p.UnitsInStock == 0 && p.UnitPrice > 3);
            //foreach (var item in Res02)
            //{
            //    Console.WriteLine(item);
            //}

            // 3-

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight",
            //                "nine" };
            //var Res01 = Arr.Where((p, i) => p.Length < i);

            //foreach (var item in Res01)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region LINQ - Element Operators 
            // 1- 

            //var Res01 = ProductList.FirstOrDefault((p)=>p.UnitsInStock==0);
            //Console.WriteLine(Res01);

            // 2-

            //var Res01 = ProductList.FirstOrDefault((p)=>p.UnitPrice>1000);
            //Console.WriteLine(Res01);

            // 3-

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Res01 = Arr.Where((P)=>P>5)
            //                  .ElementAtOrDefault(1);
            //Console.WriteLine(Res01); 
            #endregion

            #region LINQ - Aggregate Operators 
            // 1-

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Res01 = Arr.Count((p)=>p%2!=0);
            //Console.WriteLine(Res01);

            // 2-

            //var res01 = CustomerList.Select((c) => new 
            //{
            //    c.Name,
            //    OrderCount =c.Orders.Count()
            //});
            //foreach (var item in res01)
            //{
            //    Console.WriteLine(item);
            //}

            // 3-

            //var Res01 = ProductList.GroupBy(P => P.Category)
            //           .Select(g => new
            //           {
            //               Category = g.Key,
            //               ProductCount = g.Count()
            //           });
            //foreach (var item in Res01)
            //{
            //    Console.WriteLine(item);
            //}

            // 4- 

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var res01 = Arr.Aggregate((acc,num)=>acc+num);
            //Console.WriteLine(res01); 
            #endregion

            #region LINQ - Ordering Operators
            // 1-

            //var Res01 = ProductList.OrderBy((P) =>  P.ProductName);
            //foreach (var item in Res01)
            //{
            //    Console.WriteLine(item);
            //}

            // 2-

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var sortedWords = Arr.OrderBy(w => w, StringComparer.OrdinalIgnoreCase);

            //foreach (var item in sortedWords)
            //{
            //    Console.WriteLine(item);
            //}

            // 3-

            //var Res01 = ProductList.Where(p => p.UnitsInStock != 0)
            //                          .OrderByDescending(p => p.UnitsInStock);
            //foreach (var item in Res01)
            //{
            //    Console.WriteLine(item);
            //}

            // 4-

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var Res01  =Arr.OrderBy(p=>p.Length)
            //              .ThenBy(p=>p);
            //foreach (var item in Res01)
            //{
            //   Console.WriteLine(item);
            //}

            // 5-

            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var Res01 = words.OrderBy(x => x.Length)
            //                  .ThenBy(w => w, StringComparer.OrdinalIgnoreCase);

            //foreach (var item in Res01)
            //{
            //    Console.WriteLine(item);
            //}

            //6-

            //var Res01 = ProductList.OrderBy(p => p.Category)
            //                          .ThenByDescending(p=>p.UnitPrice);

            //foreach (var item in Res01)
            //{
            //    Console.WriteLine(item);
            //}

            // 7-

            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var Res01 = words.OrderBy(x => x.Length)
            //                  .ThenByDescending(w => w, StringComparer.OrdinalIgnoreCase);

            //foreach (var item in Res01)
            //{
            //    Console.WriteLine(item);
            //}

            // 8-

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var Res01 = Arr.Where(w => w[1] == 'i')
            //                .Reverse();

            //foreach (var item in Res01)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region LINQ – Transformation Operators 
            // 1- 

            //var res01 = ProductList.Select(p => p.ProductName);
            //foreach (var item in res01)
            //{
            //    Console.WriteLine(item);
            //}

            // 2-

            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var Res01 = words.Select(w => new
            //{
            //    up = w.ToUpper(),
            //    low = w.ToLower()
            //});

            //foreach (var item in Res01)
            //{
            //    Console.WriteLine(item);
            //}

            //var Res01 = ProductList.Select(p => new
            //{
            //    Name = p.ProductName,
            //    Price = p.UnitPrice
            //});
            //foreach (var item in Res01)
            //{
            //    Console.WriteLine(item);
            //}

            // 4-

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Res01 = Arr.Select((num, index) => new
            //{
            //    Number = num,
            //    InPlace = num == index
            //});
            //Console.WriteLine("Number: In-place?");
            //foreach (var item in Res01)
            //{
            //    Console.WriteLine(item);
            //}

            // 5- 

            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var res01 = numbersA.SelectMany(x => numbersB, (x,y)=> new { x, y }).Where(p=>p.x<p.y);
            //Console.WriteLine("Pairs where a < b:");
            //foreach (var pair in res01)
            //{
            //    Console.WriteLine($"{pair.x} is less than {pair.y}");
            //}

            // 6-

            //var res01 = CustomerList.SelectMany(c => c.Orders).Where(c => c.Total > 500);
            //foreach (var item in res01)
            //{
            //    Console.WriteLine(item);
            //}

            // 7-

            //var res01 = CustomerList.SelectMany(c => c.Orders).Where(o => o.OrderDate > new DateTime(1998, 1, 1)) ;
            //foreach (var item in res01)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region LINQ - Partitioning Operators 
            // 1-

            //var Res01 = CustomerList.Where((c) => c.Country == "Washington")
            //                         .SelectMany(c=>c.Orders)
            //                         .Take(3);
            //foreach (var item in Res01)
            //{
            //    Console.WriteLine(item);
            //}

            // 2-

            //var Res01 = CustomerList.Where((c) => c.Country == "Washington")
            //                         .SelectMany(c => c.Orders)
            //                         .Skip(2);
            //foreach (var item in Res01)
            //{
            //    Console.WriteLine(item);
            //}

            // 3-

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Res01 = numbers.TakeWhile((num, i) => num > 1);
            //foreach (var item in Res01)
            //{
            //    Console.WriteLine(item);
            //}

            // 4-

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Res01 = numbers.SkipWhile((num) => num%3!=0);
            //foreach (var item in Res01)
            //{
            //    Console.WriteLine(item);
            //}

            // 5-

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Res01 = numbers.SkipWhile((num,i) => num >i);
            //foreach (var item in Res01)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region LINQ - Quantifiers 
            // 2- 

            //var res01 = ProductList.GroupBy(p => p.Category)
            //            .Where(g => g.Any(p => p.UnitsInStock == 0))
            //            .SelectMany(g => g);

            //foreach (var item in res01)
            //{
            //    Console.WriteLine(item);
            //}

            // 3- 

            //var res01 = ProductList.GroupBy(p => p.Category)
            //            .Where(g => g.All(p => p.UnitsInStock != 0))
            //            .SelectMany(g => g);

            //foreach (var item in res01)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion
        }
    }
}
