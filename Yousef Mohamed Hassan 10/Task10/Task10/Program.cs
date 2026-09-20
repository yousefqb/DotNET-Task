using System;
using Task10.classes;
using System.Linq;
using System.Collections.Generic;
namespace Task10
{
    internal class Program
    {
        static T GetDefault<T>() {  return default(T); }

        static void preform<T>(T[] arr, Func<T, T> doo)
        {
            T[] newarr = new T[arr.Length];
    
            for (int i = 0; i < arr.Length; i++) 
            { 
                arr[i] = doo(arr[i]);
            } 
        }

        static T preformnums<T>(T num1, T num2, Func<T, T,T> doo)
        {
            return doo(num1, num2);

        }
        static List<R> Tranform<T, R>(List<T> input, Func<T, R> trans)
        {
            List<R> output = new List<R>(input.Count);
            foreach (T item in input)
            {
                output.Add(trans(item));
            }
            return output;
        }
        
        static void action<T>(T[] arr, Action<T> act) 
        {
            foreach (T item in arr)
            {
                act(item);
            }
        }

        static List<T> check<T>(T[] arr, Predicate<T> act)
        {
            List<T> n = new List<T>();
            foreach (T item in arr)
            {
                if (act(item))
                {
                    n.Add(item);
                }
            }
            return n;
        }

        static void check01<T>(T[] arr, Predicate<T> act)
        {
            foreach (T item in arr)
            {
                if (act(item))
                {
                    Console.WriteLine(item);
                }
            }
            
        }

        static void Main(string[] args)
        {
            #region problem01
            //Employee[] Emps =
            //{
            //    new Employee(1,"Ali",4567),
            //    new Employee(2,"Abdo",9567),
            //    new Employee(3,"Ismail",3567)
            //};
            //foreach (Employee item in Emps)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
            //SortingAlgorithm<Employee>.Sort(Emps, CompareFunctions.CompareclassAsc);
            //foreach (Employee item in Emps)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
            //SortingAlgorithm<Employee>.Sort(Emps, CompareFunctions.Compareclassdesc);
            //foreach (Employee item in Emps)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region problem02
            //var x = (int X, int Y) => X < Y;
            //int[] arr = { 2, 1,9, 8 };

            //SortingAlgorithm<int>.Sort(arr, x);
            //foreach (int item in arr)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region problem03
            //string[] str = { "joo", "no", "nope" };
            //SortingAlgorithm<string>.Sort(str,CompareFunctions.CompareLengthAsc);
            //foreach (string item in str)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region problem04
            //Func<Employee, Employee, bool> comparename = delegate (Employee x, Employee y)
            //{
            //    return x.GetName().Length < y.GetName().Length;
            //};

            //Employee[] Emps =
            //{   new Employee(3,"Ismail",3567),
            //    new Employee(1,"Ali",4567),
            //    new Employee(2,"Abdo",9567),
            //   new Employee(4,"ai",9567),
            //};
            //foreach (Employee item in Emps)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
            //SortingAlgorithm<Employee>.Sort(Emps, comparename);
            //foreach (Employee item in Emps)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
            //SortingAlgorithm<Employee>.Sort(Emps, comparename);
            //foreach (Employee item in Emps)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region problem05
            //Func<int, int, bool> compaereint = delegate (int x, int y)
            //{
            //    return x > y;
            //};

            //var compaereint01 = (int x, int y) => x > y;

            //int[] arr = { 2, 1,9, 8,5,19,15 };

            //foreach (int item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
            //SortingAlgorithm<int>.Sort(arr, compaereint01);

            //foreach (int item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
            //SortingAlgorithm<int>.Sort(arr, compaereint);

            //foreach (int item in arr)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region problem06
            //int[] arr = { 2, 1,9, 8,5,19,15 };

            //SortingAlgorithm<int>.Sort(arr, CompareFunctions.CompareAsc);
            //foreach (int item in arr)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region problem07
            //Employee[] Emps =
            //{   new Employee(3,"Ismail",3567),
            //    new Employee(1,"Ali",4567),
            //    new Employee(2,"Abdo",9567),
            //   new Employee(4,"ai",9567),
            //};
            //foreach (Employee item in Emps)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
            //SortingAlgorithm<Employee>.Sort(Emps, CompareFunctions.CompareclassAsc);

            //foreach (Employee item in Emps)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region problem08
            //Console.WriteLine(GetDefault<object>());

            #endregion        }

            #region problem09
            //Employee[] Emps =
            //{   new Employee(3,"Ismail",3567),
            //    new Employee(1,"Ali",4567),
            //    new Employee(2,"Abdo",9567),
            //   new Employee(4,"ai",9567),
            //};
            //Employee[] sortedempar;
            //sortedempar=SortingAlgorithm<Employee>.Sort(Emps,CompareFunctions.CompareclassAsc);

            //foreach (Employee item in Emps)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            //foreach (Employee item in sortedempar)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region problem10
            //var uppe =(string x)=> x.ToUpper();

            //string[] x = {"yousef","jo" };

            //foreach (var item in x)
            //{
            //    Console.WriteLine(item);
            //}

            //preform<string>(x, uppe);

            //foreach (var item in x)
            //{
            //    Console.WriteLine(item);
            //}
            //var transform = (string x) => new string(x.Reverse().ToArray());

            //preform<string>(x, transform);

            //foreach (var item in x)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region problem11
            //int x = 7;
            //int y = 3;
            //var adding = (int num1,int num2)=>num1 + num2;
            //var divison = (int num1,int num2)=>num1 / num2;
            //var multi = (int num1,int num2)=>num1 * num2;

            //Console.WriteLine(preformnums(x, y, adding));
            //Console.WriteLine(preformnums(x, y, multi));
            //Console.WriteLine(preformnums(x, y, divison)); 
            #endregion

            #region problem12
            //List<int> listint = new List<int> { 2,5,6,9,8};

            //List<string> liststring = new List<string>();

            //var inttostr = (int x)=>$"num : {x}";

            //liststring = Tranform(listint, inttostr);

            //foreach (var item in liststring)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region problem13
            //int[] numarr = { 2, 4, 5, 6 };

            //var dosquare = (int x) => x * x;

            //preform(numarr, dosquare);

            //foreach (int x in numarr)
            //{
            //    Console.WriteLine(x);
            //} 
            #endregion

            #region problem14
            //string[] names = { "jo", "yousef", "mohamed" };
            //var print = (string x) => Console.WriteLine(x);
            //action(names, print); 
            #endregion

            #region problem15
            //List<int> even = new List<int>(); 
            //int[] nums = {2,5,8,7,6,10};
            //Predicate<int> che = x => x % 2 == 0;
            //even=check(nums, che);
            //foreach (var item in even)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region problem16
            //string[] names = { "jo", "yousef", "mohamed" };

            //Predicate<string> condition = x => x == "yousef";
            //check01(names, condition); 
            #endregion

            #region problem17
            //int x = 5;
            //int y = 15;
            //var add=(int x,int y)=>x+y;
            //Console.WriteLine(preformnums(x, y, add));  
            #endregion

            #region problem18
            //string[] names = { "jo", "yousef", " mohamed"," hassan" };
            //Predicate<string> lengthCondition = str => str.Length > 3;
            //List<string> filteredstring = new List<string>();
            //filteredstring= check(names, lengthCondition);
            //foreach (var item in filteredstring)
            //{
            //    Console.WriteLine(item);  
            //} 
            #endregion

            #region problem19
            //double num1 = 20.20;
            //double num2 = 4.4;
            //var division = (double x,double y )=>x/y;
            //double sum;
            //sum =preformnums<double>(num1,num2, division);
            //Console.WriteLine(sum); 
            #endregion
        }
        static class CompareFunctions
        {
            //if (numbers[j] < (numbers[j + 1]))
            public static bool CompareDesc(int X, int Y) { return X < Y; }
           
            //if (numbers[j] > (numbers[j + 1]))
            public static bool CompareAsc(int X, int Y) { return X > Y; }
         
            //if (Employee[j] > (Eployee[j + 1]))
            public static bool CompareclassAsc<T>(T X, T Y) where T : class, IComparable<T> { return X?.CompareTo(Y) > 0; }
           
            //if (Employee[j] < (Eployee[j + 1]))
            public static bool Compareclassdesc<T>(T X, T Y) where T : class, IComparable<T>  {  return X?.CompareTo(Y) < 0; }
        
            // Compare Asc for Length
            public static bool CompareLengthAsc(string X, string Y) { return X?.Length > Y?.Length; }

            // Compare Desc for Length
            public static bool CompareLengthDesc(string X, string Y) { return X?.Length < Y?.Length; }
        }
    }
}
