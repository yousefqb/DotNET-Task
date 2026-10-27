using MVC03.Models.Classes;

namespace MVC03.Models.VMcalsses
{
    public class deptwithstudentVM
    {
        public string deptname { get; set; } 

        public List<string> stunames { get; set; }=new List<string>();
    }
}
