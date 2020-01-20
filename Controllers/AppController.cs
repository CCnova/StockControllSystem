using SouzaADM.Models;
using SouzaADM.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace SouzaADM.Controllers
{
    public class AppController
    {
        public IAppView AppView { get; set; }
        public IUpdateStockItemView UpdateStockItemVIew { get; set; }
        public Stock Stock { get; set; }

        public AppController(IAppView appView, IUpdateStockItemView updateStockItemView, Stock stock)
        {
            AppView = appView;
            UpdateStockItemVIew = updateStockItemView;
            Stock = stock;

            while(true)
            {
                GetUserInput();
            }
        }

        public void GetUserInput()
        {
            string command = AppView.GetCommand();

            if(command == "A")
            {
                string newProdName = AppView.GetProductName();
                int newProdQuantity = 0;
                if(Stock.CheckIfProductExists(newProdName))
                {
                    Console.WriteLine("Produto ja existe no estoque!");
                    newProdQuantity = AppView.GetProductQuantity();
                    Stock.IncreaseQuantity(newProdName, newProdQuantity);
                } else
                {
                    char newProdType = AppView.GetProductType();
                    double newProdPrice = AppView.GetProductPrice();
                    newProdQuantity = AppView.GetProductQuantity();

                    if (newProdType == 'E')
                    {
                        EquipProduct newProd = new EquipProduct(newProdName, newProdPrice);
                        Stock.AddItem(newProd, newProdQuantity);
                    }

                    else
                    {
                        FoodProduct newProd = new FoodProduct(newProdName, newProdPrice);
                        Stock.AddItem(newProd, newProdQuantity);
                    }
                }   
            } else if(command == "L")
            {
                AppView.ListStockItens(Stock);
            } else if(command == "S")
            {
                System.Environment.Exit(1);
            } else if(command == "R")
            {
                string delProdName = AppView.GetProductName();

                if(Stock.CheckIfProductExists(delProdName))
                {
                    Stock.DelProdByName(delProdName);
                    Console.WriteLine("\nProduto deletado do estoque com sucesso!");
                } else
                {
                    AppView.ShowMessage("Produto nao existe no estoque");
                }
            } else if(command == "AQ")
            {
                string prodName = AppView.GetProductName();

                if(!Stock.CheckIfProductExists(prodName))
                {
                    Console.WriteLine("Produto nao existe no estoque");
                    return;
                }

                string userCommand = UpdateStockItemVIew.GetCommand();
                if(userCommand == "I")
                {
                    Stock.IncreaseQuantity(prodName, UpdateStockItemVIew.GetIncrementalQuantity());

                } else if(userCommand == "S")
                {
                    Stock.DecreaseQuantity(prodName, UpdateStockItemVIew.GetDecrementalQuantity());
                } else
                {
                    Stock.GetStockItemByName(prodName).Quantity = UpdateStockItemVIew.GetUpdateQuantity();
                }

                AppView.ShowMessage("Quantidade atualizada com sucesso");
            } else if(command == "LR")
            {
                AppView.ListStockRecipes(Stock);
            } else if(command == "AR")
            {
                string newRecipeName = AppView.GetRecipeName();
                if(Stock.CheckIfRecipeExists(newRecipeName))
                {
                    AppView.ShowMessage("Receita ja existe!");
                    return;
                } else
                {
                    List<RecipeIngredient> ingredients = new List<RecipeIngredient>();
                    string newIngredientName = " ";
                    while(true)
                    {
                        newIngredientName = AppView.GetIngredientName();
                        if(newIngredientName == "SAIR") { break; }

                        StockItem auxItem = Stock.GetStockItemByName(newIngredientName);

                        string newIngredientQuantity = AppView.GetIngredientQuantity();

                        ingredients.Add(new RecipeIngredient(auxItem.Product, newIngredientQuantity));
                    }

                    string newRecipeLongDescription = AppView.GetRecipeLongDescription();

                    string newRecipeShortDescription = AppView.GetRecipeShortDescription();

                    Recipe newRecipe = new Recipe(newRecipeName, ingredients, newRecipeLongDescription, newRecipeShortDescription);

                    Stock.AddRecipe(newRecipe);

                    Console.WriteLine("Receita adicionada ao estoque!");
                }
            }
        }
    }
}
