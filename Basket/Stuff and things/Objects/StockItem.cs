using System;
using System.Collections.Generic;
using System.Text;

namespace Basket.Stuff_and_things
{
    public class StockItem
    {
        private Guid _itemID;
        private Guid _stockID;
        private int _quantity;
        private DateTime _lastOrdered;
        private DateTime _nextOrdered;

        public StockItem(Guid itemID, Guid stockID, int quantity, DateTime lastOrdered, DateTime nextOrdered)
        {
            ItemID = itemID;
            StockID = stockID;
            Quantity = quantity;
            LastOrdered = lastOrdered;
            NextOrdered = nextOrdered;
        }

        public Guid ItemID { get => _itemID; set => _itemID = value; }
        public Guid StockID { get => _stockID; set => _stockID = value; }
        public int Quantity { get => _quantity; set => _quantity = value; }
        public DateTime LastOrdered { get => _lastOrdered; set => _lastOrdered = value; }
        public DateTime NextOrdered { get => _nextOrdered; set => _nextOrdered = value; }
    }
}
