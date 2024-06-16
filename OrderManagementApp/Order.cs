using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementApp
{
    public class Order
    {
        public int OrderId { get; set; }
        [ForeignKey("user")]
        public int CustomerId { get; set; }
        public User user { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product product { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }

    }
}
