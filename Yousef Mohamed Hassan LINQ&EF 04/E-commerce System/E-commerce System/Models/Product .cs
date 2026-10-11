using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce_System.Models
{
    internal class Product
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Price { get; set; }
        public int CategoryId { get; set; }
        public Category category { get; set; }
        public List<OrderDetail> productorders { get; set; }
    }
}
