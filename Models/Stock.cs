using System;
using System.Collections.Generic;
using System.Text;

namespace SouzaADM.Models
{
    public class Stock
    {
        public List<StockItem> Itens { get; set; }
        public List<Recipe> Recipes { get; set; } 
        public Stock()
        {
            Itens = new List<StockItem>();
            Recipes = new List<Recipe>();
        }

        public void AddRecipe(Recipe rec)
        {
            this.Recipes.Add(rec);
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

        public bool CheckIfProductExists(string prodName)
        {
            foreach(StockItem item in Itens)
            {
                if(item.Product.Name == prodName)
                {
                    return true;
                }
            }

            return false;
        }

        public bool CheckIfRecipeExists(string recipeName)
        {
            foreach(Recipe rec in Recipes)
            {
                if(rec.Name == recipeName)
                {
                    return true;
                }
            }

            return false;
        }

        public StockItem GetStockItemByName(string itemName)
        {
            foreach(StockItem item in Itens)
            {
                if(item.Product.Name == itemName)
                {
                    return item;
                }
            }

            return null;
        }

        public void IncreaseQuantity(string prodName, int qnt)
        {
            foreach(StockItem item in Itens)
            {
                if(item.Product.Name == prodName)
                {
                    item.Quantity += qnt;
                }
            }
        }

        public void DecreaseQuantity(string prodName, int qnt)
        {
            foreach(StockItem item in Itens)
            {
                if(item.Product.Name == prodName)
                {
                    if(item.Quantity < qnt)
                    {
                        item.Quantity = 0;
                        return;
                    }

                    item.Quantity -= qnt;
                }
            }
        }

        public void DelProdByName(string prodName)
        {
            for(int i = 0; i < Itens.Count; i++)
            {
                if(Itens[i].Product.Name == prodName)
                {
                    Itens.RemoveAt(i);
                }
            }
        }
    }
}
