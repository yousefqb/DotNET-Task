using System;
using System.Runtime.CompilerServices;
using Task09.Interface;

namespace Task09
{
    internal class Program
    {

        enum Weekdays
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday
        }

        enum Grades : short
        {
            f=1,
            e,
            d,
            c,
            b,
            a
        }

        enum Gender :byte 
        {
            male ,
            female
        }
        enum Gender1
        {
            male,
            female
        }
        static void Main(string[] args)
        {
            #region problem01
            //foreach (Weekdays we in Enum.GetValues(typeof(Weekdays)))
            //{
            //    Console.WriteLine(we + " = " + (int)we);
            //} 
            #endregion

            #region problem02
            //foreach(Grades gra in Enum.GetValues(typeof(Grades)))
            //{
            //    Console.WriteLine($"{gra} = {(int)gra}");
            //} 
            #endregion

            #region problem03
            //Person p01 = new Person();
            //Console.WriteLine(p01);
            //Person p02 = new Person(5, "yousef", "Full stack",5000);
            //Console.WriteLine(p02);
            #endregion

            #region problem04
            //Child c01 = new Child();
            //Console.WriteLine(c01); 
            #endregion

            #region problem05
            //Console.WriteLine(Utility.perimeterRectangle(5,2));
            #endregion

            #region problem06
            //ComplexNumber c01=new ComplexNumber() {Real=5,Imag=2 };
            //ComplexNumber c02 = new ComplexNumber() { Real = 10, Imag = 20 };
            //Console.WriteLine(c01);
            //Console.WriteLine(c02);
            //ComplexNumber c03 = c01 * c02;
            //Console.WriteLine(c03); 
            #endregion

            #region problem07
            //Console.WriteLine(sizeof(Gender));
            //Console.WriteLine(sizeof(Gender1)); 
            #endregion

            #region problem08
            //Console.WriteLine(Utility.converttemperatures(5));
            #endregion

            #region problem09
            //Employee[] employees = new Employee[]
            //{
            //    new Employee(5,"yousef" ,10000,20),
            //    new Employee(6,"joo" ,5000,35),
            //    new Employee(7,"mostafa" ,2000,30),
            //    new Employee(8,"mohamed" ,9000,25)
            //};
            //Employee searchemp = new Employee(6,"joo",5000,35);
            //int isFound = Helper2<Employee>.SearchArray(employees, searchemp);
            //Console.WriteLine(isFound); 
            #endregion

            #region problem10
            //Console.WriteLine(Helper.Max(5, 7)); 
            //Console.WriteLine(Helper.Max(5.8, 7.6));
            //Console.WriteLine(Helper.Max("hi", "hii")); 
            #endregion

            #region problem11
            //int[] array = { 1, 2, 3, 4, 2 };
            //Helper2<int>.ReplaceArray(array, 2, 10);
            //foreach (int item in array)
            //{
            //    Console.Write(item + " ");
            //}
            //string[] name = { "JOO", "yousef" };
            //Helper2<string>.ReplaceArray(name, "JOO", "OH NOOOO");
            //foreach (string item in name)
            //{
            //    Console.Write(item + " ");
            //}
            #endregion

            #region problem12
            //Rectangle R01 = new Rectangle(5,5);
            //Rectangle R02 = new Rectangle(10,10);
            //Console.WriteLine(R01);
            //Console.WriteLine(R02);
            //R01.Swap(ref R02);
            //Console.WriteLine(R01);
            //Console.WriteLine(R02); 
            #endregion

            #region problem13
            //Employee[] employees = new Employee[]
            //{
            //    new Employee(5,"yousef" ,10000,20,new Department(5,"it")),
            //    new Employee(6,"joo" ,5000,35,new Department()),
            //    new Employee(7,"mostafa" ,2000,30,new Department(6,"NETWORk")),
            //    new Employee(8,"mohamed" ,9000,25,new Department(7,"HR"))
            //};
            //Employee targetEmployee = new Employee()
            //{
            //    DepartmentEmp = new Department(6, "NETWORk")
            //};
            //Console.WriteLine(Helper2<Employee>.SearchArray(employees, targetEmployee)); 
            #endregion

            #region problem14
            //Circle c01 = new Circle(5,"red");
            //Circle c02 = new Circle(10, "blue");
            //Console.WriteLine(c01.CompareTo(c02));
            //Console.WriteLine(c01==c02); 
            #endregion

            //************************* PART 02 ****************************

            #region problem01
            //int[] arr = { 1, 2, 3, 4, 5 };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //int[] upda =ReversingArray(arr);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(upda[i]);
            //} 
            #endregion

            #region problem02
            //CustomStack<int> intStack = new CustomStack<int>();
            //intStack.Push(10);
            //intStack.Push(20);
            //intStack.Push(30);

            //Console.WriteLine($"Top element (Peek): {intStack.Peek()}"); 
            //Console.WriteLine($"Popped: {intStack.Pop()}");     
            //Console.WriteLine($"New Top element: {intStack.Peek()}"); 

            //CustomStack<string> stringStack = new CustomStack<string>();
            //stringStack.Push("C#");
            //stringStack.Push(".NET");

            //Console.WriteLine($"Popped string: {stringStack.Pop()}"); 
            #endregion

            #region problem03
            //int[] arr = { 1, 2, 3, 4, 5 };
            //SwapArray(arr, 0, 4);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //} 
            #endregion

            #region problem04
            //int[] arr = { 1, 2, 3, 4, 5 };
            //int maxnum= Max(arr);
            //Console.WriteLine(maxnum); 
            #endregion

        }

        public static T[] ReversingArray<T>(T[] array) 
        {
            int size = array.Length-1;
            T[] newarr = new T[array.Length];
            for (int i = 0; i <array.Length; i++) 
            {
                newarr[i] = array[size];
                size--;
            }
            return newarr;
        }

        public static void SwapArray<T>(T[] array, int index1, int index2) 
        {
            T Temp = array[index1];
            array[index1] = array[index2];
            array[index2] = Temp;
        }

        public static T Max<T>(T[] array) where T : IComparable<T>
        {
            T Max=array[0];
            foreach (T item in array)
            {
                if (Max.CompareTo(item)<0)
                {
                    Max = item;
                }
            }
            return Max;
        }
    }
}
