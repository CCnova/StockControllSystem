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
        public Stock Stock { get; set; }

        public AppController()
        {
            AppView = new AppView();
            Stock = new Stock();

            while(true)
            {
                GetUserInput();
            }
        }

        public void GetUserInput()
        {
            char command = AppView.GetCommand();

            if(command == 'A')
            {
                string newProdName = AppView.GetProductName();
                char newProdType = AppView.GetProductType();
                double newProdPrice = AppView.GetProductPrice();
                int newProdQuantity = AppView.GetProductQuantity();

                if(newProdType == 'E')
                {
                    EquipProduct newProd = new EquipProduct(newProdName, newProdPrice);
                    Stock.AddItem(newProd, newProdQuantity);
                }

                else
                {
                    FoodProduct newProd = new FoodProduct(newProdName, newProdPrice);
                    Stock.AddItem(newProd, newProdQuantity);
                }
            } else if(command == 'L')
            {
                AppView.ListStock(Stock);
            } else if(command == 'S')
            {
                System.Environment.Exit(1);
            }
        }
        public void GetStockInformation()
        {
            AppView.ListStock(Stock);
        }
    }
}
