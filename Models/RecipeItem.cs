using System;
using System.Collections.Generic;
using System.Text;

namespace SouzaADM.Models
{
    public class RecipeItem
    {
        public Product Ingredient { get; set; }
        public int Quantity { get; set; }

        public RecipeItem(Product ingredient, int qnt)
        {
            Ingredient = ingredient;
            Quantity = qnt;
        }
    }
}
