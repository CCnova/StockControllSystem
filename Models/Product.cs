using System;
using System.Collections.Generic;
using System.Text;

namespace SouzaADM.Models
{
    public abstract class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Product(string prodName, double price)
        {
            Name = prodName;
            Price = price;
        }
    }
}
