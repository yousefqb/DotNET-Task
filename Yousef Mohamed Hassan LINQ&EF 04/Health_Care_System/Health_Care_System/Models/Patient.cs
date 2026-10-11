using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_Care_System.Models
{
    internal class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Appointment> PatientDoctors { get; set; }
    }
}
