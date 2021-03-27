using System;
using System.Collections.Generic;
using System.Text;

namespace Basket
{
    public class Basket
    {
        private Guid _basketID;
        private Guid _customerID;
        private Guid _orderID;

        public Basket(Guid customerID, Guid orderID)
        {
            BasketID = Guid.NewGuid();
            CustomerID = customerID;
            OrderID = orderID;
        }

        public Guid BasketID { get => _basketID; set => _basketID = value; }
        public Guid CustomerID { get => _customerID; set => _customerID = value; }
        public Guid OrderID { get => _orderID; set => _orderID = value; }
    }
}
