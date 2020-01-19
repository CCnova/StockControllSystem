using SouzaADM.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SouzaADM.Views
{
    public interface IAppView
    {
        public void ShowMessage(string msg);
        public string GetCommand();
        public void ListStockItens(Stock s);
        public void ListStockRecipes(Stock s);
        public string GetProductName();
        public string GetRecipeName();
        public char GetProductType();
        public double GetProductPrice();
        public int GetProductQuantity();
        public List<RecipeIngredient> GetRecipeIngredients();
    }
}
