using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce_System.Models
{
    internal class OrderDetail
    {
        
        public int Quantity { get; set; }
        public int orderId { get; set; }
        public int productId { get; set; }
        public Order order { get; set; }
        public Product product { get; set; }
    }
}
