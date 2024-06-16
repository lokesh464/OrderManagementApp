using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace OrderManagementApp
{
    public class OrderManager(OrderManagementContext context)
    {
        private readonly OrderManagementContext _context = context;

        public void PlaceOrder(int customerId, int productId, int quantity)
        {
            var product =  _context.Products.FirstOrDefault(x => x.ProductId == productId);
            var customer = _context.Users.FirstOrDefault(x=> x.UserId == customerId);

            if (customer == null || product == null)
                Console.WriteLine("Order is Invalid");

            if (product.CityId != customer.CityId)
                Console.WriteLine("Product is not available in Your city");

            if (product.Quantity < quantity)
                Console.WriteLine("quantity is Insufficient");
            
                product.Quantity -= quantity;
                var order = new Order
                {
                    CustomerId = customerId,
                    ProductId = productId,
                    Quantity = quantity,
                    OrderDate = DateTime.Now
                };

                _context.Orders.Add(order);
                _context.SaveChanges();

                Console.WriteLine("Order Placed Successfully");           

        }
    }
}
