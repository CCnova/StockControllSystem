using System;
using System.Collections.Generic;
using System.Text;

namespace SouzaADM.Models
{
    public class Stock
    {
        public List<StockItem> Itens { get; set; }
        public List<RecipeItem> Recipes { get; set; } 
        public Stock()
        {
            Itens = new List<StockItem>();
            Recipes = new List<RecipeItem>();
        }

        public bool AddItem(Product prod)
        {
            foreach(StockItem s in Itens)
            {
                if(s.Product.Name == prod.Name)
                {
                    s.Quantity = s.Quantity + 1;
                    return true;
                }
            }

            StockItem newStockItem = new StockItem(prod);

            Itens.Add(newStockItem);
            return true;
        }

        public bool AddItem(Product prod, int qnt)
        {
            foreach (StockItem s in Itens)
            {
                if (s.Product.Name == prod.Name)
                {
                    s.Quantity = s.Quantity + qnt;
                    return true;
                }
            }

            StockItem newStockItem = new StockItem(prod, qnt);

            Itens.Add(newStockItem);
            return true;
        }

        public double CalculateTotalPrice()
        {
            double totalPrice = 0;

            foreach(StockItem s in Itens)
            {
                totalPrice += s.Product.Price * s.Quantity;
            }

            return totalPrice;
        }
    }
}
