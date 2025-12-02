using System;
using System.Collections.Generic;
using System.Text;

namespace testvetov2
{
    public class Order
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double PricePerUnit { get; set; }

        public double TotalPrice()
        {
            if (Quantity <= 0)
                throw new ArgumentException("Quantity must be positive!");

            if (PricePerUnit <= 0)
                throw new ArgumentException("Price cannot be negative!");

            return Quantity * PricePerUnit;
        }
    }
}