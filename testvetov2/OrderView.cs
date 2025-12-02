using System;
using System.Collections.Generic;
using System.Text;

namespace testvetov2
{
    public class OrderView
    {
        public void DisplayOrderDetails(Order order)
        {
            Console.WriteLine($"Product: {order.ProductName}, Quantity: {order.Quantity}, Total: {order.TotalPrice()}");
        }   

        public void DisplayTotalRevenue(double totalRevenue)
        {
            Console.WriteLine($"Total revenue: {totalRevenue}");
        }
    }
}
