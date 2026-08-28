using System;

namespace test04
{
    internal class Program
    {
        enum DayOfWeek
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }
        static void Main(string[] args)
        {
            #region problem01
            //int[] arr1 = new int[3] { 1, 2, 3, };
            //int[] arr2 = new int[] { 1, 2, 3, };
            //int[] arr3 = { 1, 2, 3, };
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(arr1[i]);
            //    Console.WriteLine(arr2[i]);
            //    Console.WriteLine(arr3[i]);
            //}
            //Console.WriteLine(arr3[4]); 
            #endregion

            #region problem02
            //// shallow copy   
            //int[] arr01 = { 1, 2, 3 };
            //int[] arr02 = { 4, 5, 6 };
            ////Console.WriteLine(arr01.GetHashCode());//58225482
            ////Console.WriteLine(arr02.GetHashCode());//54267293
            ////arr02 = arr01;
            ////Console.WriteLine(arr01.GetHashCode());//58225482
            ////Console.WriteLine(arr02.GetHashCode());//58225482
            ////Console.WriteLine(arr01[1]);//2
            ////Console.WriteLine(arr02[1]);//2

            //// Deep Copy
            //arr02 = (int[])arr01.Clone();
            //// Creates a new object with same data/state of original/caller object
            //// but with a distinct memory address/identity
            //// same data
            //Console.WriteLine(arr01[1]);//2
            //Console.WriteLine(arr02[1]);//2
            //// Diff address
            //Console.WriteLine(arr01.GetHashCode());
            //Console.WriteLine(arr02.GetHashCode()); 
            #endregion

            #region problem03
            //int[,] arr01 = new int[3, 3];
            //for (int i = 0; i < arr01.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Student {i + 1} ");
            //    for (int j = 0; j < arr01.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"grade of subject {j + 1}");
            //        arr01[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            ////print
            //for (int i = 0; i < arr01.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Student {i + 1} ");
            //    for (int j = 0; j < arr01.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"grade of subject {j + 1} : {arr01[i,j]}");

            //    }
            //} 
            #endregion

            #region problem04

            //int[] arr01 = { 4, 7, 6, 5 };
            //int[] arr02 = new int[4];
            //Console.WriteLine("Sorting");
            //Array.Sort(arr01);
            //for(int i = 0; i < arr01.Length; i++)
            //{
            //    Console.WriteLine(arr01[i]);
            //}
            //Console.WriteLine("REVERSE");
            //Array.Reverse(arr01);
            //for (int i = 0; i < arr01.Length; i++)
            //{
            //    Console.WriteLine(arr01[i]);
            //}
            //Console.WriteLine("INDEX OF");
            //Console.WriteLine("index of 6 : "+Array.IndexOf(arr01, 6));

            //Console.WriteLine("Copy");
            //Array.Copy(arr01, arr02, 2);
            //for (int i = 0; i < arr02.Length; i++)
            //{
            //    Console.WriteLine(arr02[i]);
            //}

            //Console.WriteLine("Clear");
            //Array.Clear(arr01,1,2);
            //for (int i = 0; i < arr01.Length; i++)
            //{
            //    Console.WriteLine(arr01[i]);
            //} 
            #endregion

            #region Problem05
            //int[] arr01 ={ 2, 3, 4 };

            //for (int i = 0; i < arr01.Length; i++)
            //{
            //   Console.WriteLine(arr01[i]); 
            //}

            //foreach (int i in arr01)
            //{
            //    Console.WriteLine(i);
            //}
            //int idx = arr01.Length-1;

            //while(idx>=0)
            //{
            //    Console.WriteLine(arr01[idx]);
            //    idx--;
            //} 
            #endregion

            #region problem06
            //int oddnum;
            //bool ODD;
            //do
            //{
            //    Console.WriteLine("Enter ODD Number : ");
            //    ODD = int.TryParse(Console.ReadLine(), out oddnum);
            //} while (oddnum < 0||!ODD||oddnum%2==0); 
            #endregion

            #region problem07
            //int[,] arr01 = { { 1, 2, 3 }, { 4, 5, 6 } }; 
            ////print
            //for (int i = 0; i < arr01.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr01.GetLength(1); j++)
            //    {
            //        Console.Write(arr01[i, j]+" ");
            //    }
            //    Console.WriteLine();
            //} 
            #endregion

            #region problem08
            //int monthNumber= int.Parse(Console.ReadLine());

            // // if-else

            // if (monthNumber == 1) Console.WriteLine("Month: January");
            // else if (monthNumber == 2) Console.WriteLine("Month: February");
            // else if (monthNumber == 3) Console.WriteLine("Month: March");
            // else if (monthNumber == 4) Console.WriteLine("Month: April");
            // else if (monthNumber == 5) Console.WriteLine("Month: May");
            // else if (monthNumber == 6) Console.WriteLine("Month: June");
            // else if (monthNumber == 7) Console.WriteLine("Month: July");
            // else if (monthNumber == 8) Console.WriteLine("Month: August");
            // else if (monthNumber == 9) Console.WriteLine("Month: September");
            // else if (monthNumber == 10) Console.WriteLine("Month: October");
            // else if (monthNumber == 11) Console.WriteLine("Month: November");
            // else if (monthNumber == 12) Console.WriteLine("Month: December");
            // else Console.WriteLine("Invalid month number Must be between 1 and 12.");

            // // switch 
            // switch (monthNumber)
            // {
            //     case 1: Console.WriteLine("Month: January"); break;
            //     case 2: Console.WriteLine("Month: February"); break;
            //     case 3: Console.WriteLine("Month: March"); break;
            //     case 4: Console.WriteLine("Month: April"); break;
            //     case 5: Console.WriteLine("Month: May"); break;
            //     case 6: Console.WriteLine("Month: June"); break;
            //     case 7: Console.WriteLine("Month: July"); break;
            //     case 8: Console.WriteLine("Month: August"); break;
            //     case 9: Console.WriteLine("Month: September"); break;
            //     case 10: Console.WriteLine("Month: October"); break;
            //     case 11: Console.WriteLine("Month: November"); break;
            //     case 12: Console.WriteLine("Month: December"); break;
            //     default: Console.WriteLine("Invalid month number! Must be between 1 and 12."); break;
            // } 
            #endregion

            #region problem09
            //int[] arr01 ={ 8,9,6,4,9 };
            ////Sorting
            //Array.Sort(arr01);
            //for (int i = 0; i < arr01.Length; i++)
            //{
            //    Console.WriteLine(arr01[i]);
            //}
            //Console.WriteLine(Array.IndexOf(arr01,9));
            //Console.WriteLine(Array.LastIndexOf(arr01, 9)); 
            #endregion

            #region problem10
            //int[] arr01 = { 3, 4, 5, 6 };
            //int sum = 0;
            //int sum2 = 0;
            //for (int i = 0; i < arr01.Length; i++)
            //{
            //    sum += arr01[i];
            //}
            //Console.WriteLine(sum);

            //foreach (int i in arr01)
            //{
            //    sum2 += i;
            //}
            //Console.WriteLine(sum2); 
            #endregion

            //part02

            #region problem01
            //int num = int.Parse(Console.ReadLine());

            //DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), num.ToString());

            //Console.WriteLine(day); 
            #endregion
            Console.ReadLine();
        }
    }
}
