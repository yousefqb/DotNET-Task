using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskC_08.Interface
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        
        public Book(string _Title, string _Author)
        {
            Title= _Title;
            Author= _Author;
        }
        public Book(string _Title):this(_Title,"unknown"){}
        public Book() : this("unknown", "unknown"){}

        public override string ToString()
        {
            return ($"the title is : {Title} , the author : {Author}");
        }
    }
}
