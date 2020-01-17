using SouzaADM.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SouzaADM.Views
{
    public class AppView : IAppView
    {
        public string GetCommand()
        {
            string command = " ";
            
            while(command != "A" && command != "R" && command != "AR" && command != "RR" && command != "L" && command != "LR" && command != "S")
            {
                Console.WriteLine("\nAdicionar item(A), Remover Item(R), Adicionar Receita(AR), Remover Receita(RR), Listar Estoque de Itens(L), Listar Receitas(LR), Sair(S):");
                command = Console.ReadLine().ToUpper();
            }

            return command;
        }

        public string GetProductName()
        {
            Console.WriteLine("\nEscreva o nome do novo produto: ");
            string newProdName = Console.ReadLine().ToUpper();

            return newProdName;
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
        public void ListStock(Stock s)
        {
            foreach(StockItem item in s.Itens)
            {
                Console.WriteLine("\nNome: " + item.Product.Name + "   Quantidade: " + item.Quantity + "    Preco por Un/Kg: " + item.Product.Price);
            }

            Console.WriteLine("\nValor Total do Estoque: " + s.CalculateTotalPrice() + " reais");
        }
    }
}
