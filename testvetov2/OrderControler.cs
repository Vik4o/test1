using System;
using System.Collections.Generic;
using System.Text;

namespace testvetov2
{
    public class OrderControler
    {
        public List<Order> orders = new List<Order>();
        public OrderView view = new OrderView();

        public void AddOrder(Order order)
        {
            orders.Add(order);
        }

        public double CalculateTotalRevenue()
        {
            double total = 0;
            foreach (var order in orders)
            {
                total += order.TotalPrice();
            }
            return total;
        }

        public void DisplayOrders()
        {
            foreach (var order in orders)
            {
                view.DisplayOrderDetails(order);
            }
            view.DisplayTotalRevenue(CalculateTotalRevenue());
        }

        public void Run()
        {
            var order = new Order { ProductName = "Laptop", Quantity = 2, PricePerUnit = 1000 };
        }
    }
}
