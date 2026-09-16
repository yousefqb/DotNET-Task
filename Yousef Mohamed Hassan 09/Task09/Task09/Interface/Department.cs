using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task09.Interface
{
    internal class Department
    {
        public int DepID { get; set; }
        public string DepName { get; set; }

        public Department()
        {
            DepID = 0;
            DepName = "nothing";
        }
        public Department(int _DepID, string _DepName)
        {
            DepID= _DepID;
            DepName = _DepName;
        }
        public override bool Equals(object obj)
        {
            Department dep = obj as Department;
            return (DepID==dep.DepID&& DepName==dep.DepName);
        }


    }
}
