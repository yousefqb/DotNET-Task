using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task09.Interface
{
    internal class Employee
    {
        private int EmpId;
        private string EmpName;
        private decimal EmpSalary;

        public Department DepartmentEmp { get; set; }
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

        public int Age { get; set; }

        public decimal Bonus
        {
            get { return 0.1M * EmpSalary; }
        }
        public Employee()
        {
            
        }

        public Employee(int _Id, string _Name, decimal _Salary, int _age ,Department department)
        {
            EmpId = _Id;
            EmpName = _Name;
            EmpSalary = _Salary;
            Age = _age;
            DepartmentEmp = department;
        }

        public override string ToString()
        {
            return $"Emp Id is {EmpId}, Emp Name is {EmpName}, Salary is {EmpSalary}, Age is {Age}";
        }

        public override bool Equals(object obj)
        {
            Employee passingemp = (Employee)obj;
            return (((EmpId == passingemp?.EmpId) && (EmpName == passingemp?.EmpName) && (Age == passingemp?.Age) && (Salary == passingemp?.Salary))||(passingemp.DepartmentEmp.Equals(DepartmentEmp)));
        }
    }
}
