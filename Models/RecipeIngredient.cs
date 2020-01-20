using System;
using System.Collections.Generic;
using System.Text;

namespace SouzaADM.Models
{
    public class RecipeIngredient
    {
        public Product Ingredient { get; set; }
        public string Quantity { get; set; }

        public RecipeIngredient(Product ingredient, string qnt)
        {
            Ingredient = ingredient;
            Quantity = qnt;
        }
    }
}
