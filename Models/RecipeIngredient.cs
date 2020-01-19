using System;
using System.Collections.Generic;
using System.Text;

namespace SouzaADM.Models
{
    public class RecipeIngredient
    {
        public Product Ingredient { get; set; }
        public int Quantity { get; set; }

        public RecipeIngredient(Product ingredient, int qnt)
        {
            Ingredient = ingredient;
            Quantity = qnt;
        }
    }
}
