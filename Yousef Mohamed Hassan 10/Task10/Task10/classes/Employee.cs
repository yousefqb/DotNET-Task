using System;
using System.Collections.Generic;
using System.Text;

namespace Task10.classes
{
    class Employee : IComparable<Employee>,ICloneable
    {
        private int EmpId;
        private string EmpName;
        private decimal EmpSalary;

        public string GetName()
        {
            return EmpName;
        }

        public void SetName(string value)
        {

            EmpName = value.Length < 10 ? value : value.Substring(0, 10);
        }


        public decimal Salary
        {
            get { return EmpSalary; }
            set { EmpSalary = value < 5000 ? 5000 : value; }
        }



        public decimal Bonus
        {
            get { return 0.1M * EmpSalary; }
        }
        public Employee()
        {

        }

        public Employee(int _Id, string _Name, decimal _Salary)
        {
            EmpId = _Id;
            EmpName = _Name;
            EmpSalary = _Salary;


        }

        public override string ToString()
        {
            return $"Emp Id is {EmpId}, Emp Name is {EmpName}, Salary is {EmpSalary}";
        }

        public override bool Equals(object obj)
        {
            Employee passingemp = (Employee)obj;
            return (((EmpId == passingemp?.EmpId) && (EmpName == passingemp?.EmpName) && (Salary == passingemp?.Salary)));
        }

        public int CompareTo(Employee passed)
        {
            if (Salary > passed.Salary)
                return 1;
            else if (Salary < passed.Salary)
                return -1;
            else 
            {
                if(EmpName?.Length > passed?.EmpName.Length) 
                    return 1;
                else if(EmpName?.Length < passed?.EmpName.Length)
                    return -1;
                else
                    return 0;
            }
        }
        public object Clone()
        {
            Employee newemp = new Employee();
            newemp.EmpId= EmpId ;
            newemp.EmpName=EmpName ;
            newemp.Salary=Salary ;
            return newemp;
        }
    }
}
