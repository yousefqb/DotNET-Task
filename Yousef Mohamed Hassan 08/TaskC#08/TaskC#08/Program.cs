using System;
using TaskC_08.Interface;

namespace TaskC_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region problem01
            //Car car01 = new Car();
            //Bike bike01 = new Bike();
            //car01.StartEngine();
            //car01.StopEngine();
            //bike01.StartEngine();
            //bike01.StopEngine(); 
            #endregion

            #region problem02
            //Shape rect = new Rectangle(5, 10);
            //Shape circle = new Circle(7);
            //rect.Display();
            //circle.Display();

            //IShape rectInt = new RectangleInter(5, 10);
            //IShape circleInt = new CircleInterface(7);
            //rectInt.Display();
            //circleInt.Display(); 
            #endregion

            #region problem03
            //Product[] pro01 = new Product[]
            //{
            //new Product(1,250,"bmw"),
            //new Product(2,150,"marc"),
            //new Product(3,200,"odoo")
            //};
            //Array.Sort(pro01);
            //foreach (Product item in pro01)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region problem04
            ////Sallow Copy
            //Student s01 = new Student();
            //Student s02 = new Student() {Id=50,Grade=500,Name="hoi"};
            //s01 = s02;
            //Console.WriteLine(s01.GetHashCode());
            //Console.WriteLine(s02.GetHashCode());
            ////deep copy
            //s01=new Student(s02);
            //Console.WriteLine(s01.GetHashCode());
            //Console.WriteLine(s02.GetHashCode()); 
            #endregion

            #region problem05
            //IWalkable rob = new Robot();
            //rob.Walk(); 
            #endregion

            #region problem06
            //Account acc = new Account();
            //acc.Balance = 500;
            //acc.AccountId = 1;
            //acc.AccountHolder = "masr"; 
            #endregion

            #region problem07
            //Book b01 = new Book();
            //Book b02 = new Book("1 Mill");
            //Book b03 = new Book("overloading" , "horror");
            //Console.WriteLine(b01);
            //Console.WriteLine(b02);
            //Console.WriteLine(b03); 
            #endregion

            //----------------  PART 02  ------------------- 

            #region problem01
            //SquareSeries s = new SquareSeries();
            //CircleSeries c = new CircleSeries();
            //PrintTenShapes(s);
            //Console.WriteLine();
            //PrintTenShapes(c); 
            #endregion

            #region problem02
            //Shape02[] shapes = new Shape02[]
            //{
            //    new Shape02("Square",100),
            //    new Shape02("Circle",500),
            //    new Shape02("Rectangle",200)
            //};
            //foreach (Shape02 item in shapes)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
            //Array.Sort(shapes);
            //foreach (Shape02 item in shapes)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region problem03
            //Triangle t1 = new Triangle(5,10);
            //Rectangle1 r1 = new Rectangle1(5,10);
            //Console.WriteLine(t1.CalculateArea());
            //Console.WriteLine(t1.Perimeter);
            //Console.WriteLine(r1.CalculateArea());
            //Console.WriteLine(r1.Perimeter); 
            #endregion

            #region problem04
            //int[] numbers = { 64, 25, 12, 22, 11 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //SelectionSort(numbers);
            //Console.WriteLine("************");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //} 
            #endregion

        }



        public static void SelectionSort(int[] numbers)
        {
            int n = numbers.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[minIndex];
                    numbers[minIndex] = temp;
                }
            }
        }
        public static void PrintTenShapes(IShapeSeries series)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(series.CurrentShapeArea);
                series.GetNextArea();
            }
            series.ResetSeries();
        }
    }
}
