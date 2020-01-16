using System;
using System.Collections.Generic;
using System.Text;

namespace SouzaADM.Models
{
    public class Recipe
    {
        public string Name { get; set; }
        public List<RecipeItem> Ingredients { get; set; }
        public string LongDescription { get; set; }
        public string ShortDescription { get; set; }
        public double TotalPrice { get; set; }

        public Recipe(string name, List<RecipeItem> ingredients, string longDescription, string shortDescription)
        {
            Name = name;
            Ingredients = ingredients;
            LongDescription = longDescription;
            ShortDescription = shortDescription;
            TotalPrice = 0;

            foreach(RecipeItem r in ingredients)
            {
                TotalPrice += r.Ingredient.Price * r.Quantity;
            }
        }
    }
}
