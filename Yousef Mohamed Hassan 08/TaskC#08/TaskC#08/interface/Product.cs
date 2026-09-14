using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskC_08.Interface
{
    internal class Product : IComparable
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }

        public Product()
        {
            
        }
        public Product(int _id , int _price , string _name)
        {
            Id = _id;
            Price = _price;
            Name = _name;
        }

        public int CompareTo(object pro) 
        {
            Product other = (Product)pro;
            if(this.Price<other.Price)
                return 1;
            else if(this.Price>other.Price)
                return -1;
            else
                return 0;
        }

        public override string ToString()
        {
            return ($"the ID : {Id} , the name {Name} , the price {Price} ");
        }

    }
}
