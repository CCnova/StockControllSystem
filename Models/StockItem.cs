using System;
using System.Collections.Generic;
using System.Text;

namespace SouzaADM.Models
{
    public class StockItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public StockItem(Product product, int qnt)
        {
            Product = product;
            Quantity = qnt;
        }

        public StockItem(Product product)
        {
            Product = product;
            Quantity = 1;
        }
    }
}
