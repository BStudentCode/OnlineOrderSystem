using System;
using System.Collections.Generic;
using System.Text;

namespace Basket.Stuff_and_things
{
    public class StockManager
    {
        public List<StockItem> cachedStockItems;

        private Boolean GetStock()
        {
            /* DB LOGIC IN HERE, CONSTRUCT STOCKITEM FROM VALUES EG:
               foreach result in STOCK table -> new StockItem() tempItem; tempItem.setLastOrdered; tempItem.setQuantity; etc etc etc...*/

            //if successful return true
            //if failed:
            return false;
        }


        private int CheckQuantity(Guid itemID)
        {
            /* check cached list for itemID foreachloop */
            return 0; //placeholder
        }

        private StockItem GetItem(Guid itemID)
        {
            /* check cached list for itemID foreach loop */
            return cachedStockItems.Find(stockItem);
        }
    }
}
