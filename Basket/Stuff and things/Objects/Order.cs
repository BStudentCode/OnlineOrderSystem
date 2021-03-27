using System;
using System.Collections.Generic;
using System.Text;

namespace Basket.Stuff_and_things.Objects
{
    public class Order
    {
        private Guid _orderID;
        private Guid _customerID;
        private double _totalPrice;
        private bool _isProcessed;

        public Order(Guid orderID, Guid customerID, double totalPrice, bool isProcessed)
        {
            OrderID = orderID;
            CustomerID = customerID;
            TotalPrice = totalPrice;
            IsProcessed = isProcessed;

        }

        public Guid OrderID { get => _orderID; set => _orderID = value; }
        public Guid CustomerID { get => _customerID; set => _customerID = value; }
        public double TotalPrice { get => _totalPrice; set => _totalPrice = value; }
        public bool IsProcessed { get => _isProcessed; set => _isProcessed = value; }
    }
}
