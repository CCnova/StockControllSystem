using System;

namespace SouzaADM.Views
{
    public class UpdateStockItemView : IUpdateStockItemView
    {
        public string GetCommand()
        {
            Console.WriteLine("\nGostaria de Incrementar a quantidade(I), Subtrair da quantidade(S) ou Atualizar a quantidade(A)?");
            string userInput = Console.ReadLine().ToUpper();

            return userInput;
        }

        public int GetQuantity()
        {
            int userInput = Int32.Parse(Console.ReadLine());

            return userInput;
        }

        public int GetIncrementalQuantity()
        {
            Console.WriteLine("\nDigite a quantidade a ser adicionada:");

            return GetQuantity();
        }

        public int GetDecrementalQuantity()
        {
            Console.WriteLine("\nDigite a quantidade a ser subtraida:");

            return GetQuantity();
        }

        public int GetUpdateQuantity()
        {
            Console.WriteLine("\nDigite a nova quantidade:");

            return GetQuantity();
        }
    }
}