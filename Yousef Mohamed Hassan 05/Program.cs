using System;
using System.Runtime.Versioning;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region problem01
            // int x,y;
            //try
            // {
            //     Console.WriteLine("Enter Num 1 : ");
            //     x = int.Parse(Console.ReadLine());
            //     Console.WriteLine("Enter Num 2 : ");
            //     y= int.Parse(Console.ReadLine());
            //     Console.WriteLine($"the final result is :{x/y} ");
            // }
            // catch(DivideByZeroException ex)
            // {
            //     Console.WriteLine("cannot divide by zero");
            // }
            // finally
            // {
            //     Console.WriteLine("Operation complete");
            // } 
            #endregion

            #region problem02
            //TestDefensiveCode();
            #endregion

            #region roblem03
            //int? XX = 10;
            //int YY;
            //if (XX != null)
            //{
            //    YY = (int)XX;
            //}
            //else
            //{
            //    YY = 0;
            //}
            //if (XX.HasValue)
            //{
            //    YY = XX.Value;
            //}
            //else
            //{
            //    YY = 0;
            //}

            //int YY01 = XX.HasValue ? XX.Value : 0;

            //int YY02 = XX ?? 0; 
            #endregion

            #region problem04
            //int[] arr = { 1, 2, 3, 4, 5 };
            //try
            //{
            //    arr[5] = 10;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //} 
            #endregion

            #region problem05
            //int[,] arr = new int[3, 3];
            //int sum=0;
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    Console.WriteLine($"enter element in row number {i + 1}");
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        do
            //        {
            //            Console.WriteLine($"enter the {j + 1} element : ");
            //        } while (!int.TryParse(Console.ReadLine(), out arr[i, j]) || arr[i, j] < 0);
            //    }
            //}
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{

            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        sum += arr[i, j];
            //        Console.Write(arr[i, j] + " ");

            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine(sum);
            #endregion

            #region problem06
            //int[][] arr = new int[3][];
            //int numofelements;
            //int row = 0;
            //while (row < arr.GetLength(0))
            //{

            //    do
            //    {
            //        Console.WriteLine($"enter how many positive elemnt you want to add to row number {row + 1}");
            //    } while (!int.TryParse(Console.ReadLine(), out numofelements) || numofelements < 1);
            //    arr[row] = new int[numofelements];
            //    Console.WriteLine("enter the elements : ");
            //    for (int i = 0; i < numofelements; i++)
            //    {
            //        do
            //        {
            //            Console.WriteLine($"enter the postitive elements number {i + 1} : ");
            //        } while (!int.TryParse(Console.ReadLine(), out arr[row][i]) || arr[row][i] < 1);
            //    }
            //    row++;
            //}
            //foreach (int[] rows in arr)
            //{
            //    foreach (int item in rows)
            //    {
            //        Console.Write(item + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region problem07
            //#nullable enable
            //            string? str =null!;
            //            str=Console.ReadLine();
            //            Console.WriteLine("welcome "); 
            #endregion

            #region problem08
            //int x = 5;
            //object b1 =new object();
            //b1 = x;
            //Console.WriteLine(b1);
            //object e1 = "10";
            //x = int.Parse((string)e1);
            //Console.WriteLine(x); 
            #endregion

            #region problem09
            //int sum, product;
            //SumAndMultiply(2,3,out sum,out product);
            //Console.WriteLine(sum +"  "+ product ); 
            #endregion

            #region problem10
            //print("yousef", 7);
            //print(x:3,str:"yousef"); 
            #endregion

            #region problem11
            //int[]? arr = null;
            //int x = arr?.Length ?? 0; 
            #endregion

            #region problem12
            //    Console.Write("Enter a day of the week: ");
            //    string? day = Console.ReadLine();

            //    int? dayNumber = day?.Trim().ToLower() switch
            //    {
            //        "monday" => 1,
            //        "tuesday" => 2,
            //        "wednesday" => 3,
            //        "thursday" => 4,
            //        "friday" => 5,
            //        "saturday" => 6,
            //        "sunday" => 7,
            //        _ => null
            //    };
            //    if (dayNumber.HasValue)
            //        Console.WriteLine($"{day} is day number {dayNumber}.");
            //    else
            //        Console.WriteLine("Please enter a valid day of the week.");
            //} 
            #endregion

            #region problem13
            //Console.WriteLine(Sumarray(5,5,5,5,3,3,3,1));  
            //int[] arr = { 1, 2, 3, 4, 5 };
            //Console.WriteLine(Sumarray(arr));
            #endregion

            //********************  PART 2  ***********************

            #region problem01
            //int x;
            //do
            //{
            //    Console.WriteLine("enter positive number you want to print for it : ");
            //}
            //while (!int.TryParse(Console.ReadLine(),out x)||x<2);
            //Printtonum(x); 
            #endregion

            #region problem02
            //Console.WriteLine("enter the number you wnat the multiplication for it :  ");
            //int x = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine(x*i);
            //} 
            #endregion

            #region problem03
            //Console.WriteLine("enter the number you wnat the even numbers before it :  ");
            //int x = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= x; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //} 
            #endregion

            #region problem04
            //int basenum = int.Parse(Console.ReadLine());
            //int powernum = int.Parse(Console.ReadLine());
            //Console.WriteLine(Math.Pow(basenum, powernum));
            #endregion

            #region problem05
            //string str = Console.ReadLine();
            //for (int i = str.Length-1; i >= 0; i--)
            //{
            //    Console.WriteLine(str[i]);
            //} 
            #endregion

            #region problem06
            //int num =int.Parse(Console.ReadLine());
            //int reversed = 0;
            //while (num > 0) 
            //{
            //    reversed = reversed * 10;
            //    reversed = reversed+ (num % 10);
            //    num =num/10;
            //}
            //Console.WriteLine(reversed); 
            #endregion

            #region problem07
            //Console.Write("Enter array size: ");
            //int n = int.Parse(Console.ReadLine()!);

            //int[] arr = new int[n];
            //Console.WriteLine("Enter array elements:");

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Element [{i}]: ");
            //    arr[i] = int.Parse(Console.ReadLine()!);
            //}

            //int maxDistance = -1;
            //int bestValue = 0;

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = i + 1; j < n; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            int distance = j - i - 1;
            //            if (distance > maxDistance)
            //            {
            //                maxDistance = distance;
            //                bestValue = arr[i];
            //            }
            //        }
            //    }
            //} 
            #endregion

            #region problem08
            //Console.Write("Enter a sentence: ");
            //string sentence = Console.ReadLine()!;

            //string[] words = sentence.Split(' ');
            //Array.Reverse(words);

            //Console.WriteLine(string.Join(" ", words)); 
            #endregion


        }
        public static void TestDefensiveCode()
        {
            int X, Y;
            do
            {
                Console.WriteLine("Enter first Number : ");
            }
            while (!int.TryParse(Console.ReadLine(), out X) || X < 0);
            do
            {
                Console.WriteLine("Enter Second Number : ");
            }
            while (!int.TryParse(Console.ReadLine(), out Y) || Y <= 1);

            Console.WriteLine(X / Y);
        }
        public static void SumAndMultiply(int x, int y, out int sum, out int product)
        {
            sum = x + y;
            product = x * y; ;
        }

        public static void Print(string str, int x = 5)
        {
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(str);
            }
        }
        public static int Sumarray(params int[] x)
        {
            int sum = 0;
            foreach (int item in x)
            {
                sum += item;
            }
            return sum;
        }

        public static void Printtonum(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}