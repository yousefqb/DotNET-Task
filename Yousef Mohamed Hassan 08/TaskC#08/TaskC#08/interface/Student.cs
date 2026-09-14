using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskC_08.Interface
{
    class Student
    {
        public int Id { get; set; }
        public int Grade { get; set; }
        public string Name { get; set; }

        public Student(Student ss)
        {
            Id = ss.Id;
            Name = ss.Name;
            Grade = ss.Grade;
        }
        public Student()
        {
            
        }
    }
}
