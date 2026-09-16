using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task09.Interface
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Department { get; set; }
        public virtual int Salary { get; set; }

        public Person()
        {
            Id=0; Name = "unknown";Department = "unknown"; Salary = 0;
        }
        public Person(int _id,string _Nmae , string _dep,int _salary)
        {
            Id=_id; Name=_Nmae; Department=_dep;Salary = _salary;
        }

        public override string ToString()
        {
            return $" ID = {Id} , Name : {Name} , Department : {Department} , Salary : {Salary} ";
        }
     
    }
    internal class Child : Person
    {
        public Child() : base() 
        {
            Salary = 1000;
        }
        public sealed override int Salary { get => base.Salary; set => base.Salary = value; }
        public void DisplaySalary()
        {
            Console.WriteLine(" Salary = "+Salary);
        }
    }

}
