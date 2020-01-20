using SouzaADM.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SouzaADM.Views
{
    public class AppView : IAppView
    {

        public void ShowMessage(string msg)
        {
            Console.WriteLine("\n" + msg);
        }
        public string GetCommand()
        {
            string command = " ";
            
            while(command != "A" && command != "R" && command != "AR" && command != "RR" && command != "L" && command != "LR" && command != "S" && command != "AQ")
            {
                Console.WriteLine("\nAdicionar item(A), Remover Item(R), Atualizar Quantidade de Item(AQ) Adicionar Receita(AR), Remover Receita(RR), Listar Estoque de Itens(L), Listar Receitas(LR), Sair(S):");
                command = Console.ReadLine().ToUpper();
            }

            return command;
        }

        public string GetProductName()
        {
            Console.WriteLine("\nEscreva o nome do produto: ");
            string newProdName = Console.ReadLine().ToUpper();

            return newProdName;
        }

        public string GetRecipeName()
        {
            Console.WriteLine("\nEscreva o nome da receita: ");
            string newRecipeName = Console.ReadLine().ToUpper();

            return newRecipeName;
        }

        public char GetProductType()
        {
            Console.WriteLine("\nDigite o tipo do produto: E(Equipamento), C(Comida)");
            char prodType = char.ToUpper(Console.ReadKey().KeyChar);

            return prodType;
        }

        public double GetProductPrice()
        {
            Console.WriteLine("\nDigite o preco do produto por kg (Comida)/Un (Equipamento)");
            double prodPrice = Double.Parse(Console.ReadLine());

            return prodPrice;
        }

        public int GetProductQuantity()
        {
            Console.WriteLine("\nDigite a quantidade do produto: ");
            int prodQuantity = Int32.Parse(Console.ReadLine());

            return prodQuantity;
        }
        public void ListStockItens(Stock s)
        {
            foreach(StockItem item in s.Itens)
            {
                Console.WriteLine("\nNome: " + item.Product.Name + "   Quantidade: " + item.Quantity + "    Preco por Un/Kg: " + item.Product.Price);
            }

            Console.WriteLine("\nValor Total do Estoque: " + s.CalculateTotalPrice() + " reais");
        }

        public void ListStockRecipes(Stock s)
        {
            Console.WriteLine("\nReceitas: ");
            
            foreach(Recipe recipe in s.Recipes)
            {
                string recipeDescription = " ";
                recipeDescription += "\nNome: ";
                recipeDescription += recipe.Name;
                recipeDescription += "\nIngredientes: ";

                foreach(RecipeIngredient recIngr in recipe.Ingredients)
                {
                    recipeDescription += ". " + recIngr.Ingredient.Name + "   Quantidade: " + recIngr.Quantity + "\n";
                }


                Console.WriteLine(recipeDescription);
            }
        }

        public string GetIngredientName()
        {
            Console.WriteLine("\nDigite o nome do ingrediente ou 'sair' para finalizar:");

            string ingredientName = Console.ReadLine().ToUpper();

            return ingredientName;
        }

        public string GetIngredientQuantity()
        {
            Console.WriteLine("\nDigite a quantidade do ingrediente: ");
            string ingredientQuantity = Console.ReadLine().ToUpper();

            return ingredientQuantity;
        }

        public string GetRecipeLongDescription()
        {
            Console.WriteLine("\nDigite uma descricao detalhada da receita:");
            string description = Console.ReadLine();

            return description;
        }

        public string GetRecipeShortDescription()
        {
            Console.WriteLine("Digite uma descricao abreviada da receita:");
            string description = Console.ReadLine();

            return description;
        }
    }
}
