using System;
using System.Collections.Generic;
using System.Text;

namespace SouzaADM.Models
{
    public class Recipe
    {
        public string Name { get; set; }
        public List<RecipeIngredient> Ingredients { get; set; }
        public string LongDescription { get; set; }
        public string ShortDescription { get; set; }


        public Recipe(string name, List<RecipeIngredient> ingredients, string longDescription, string shortDescription)
        {
            Name = name;
            Ingredients = ingredients;
            LongDescription = longDescription;
            ShortDescription = shortDescription;
        }
    }
}
