using SouzaADM.Controllers;
using SouzaADM.Views;
using SouzaADM.Models;
using System;

namespace SouzaADM
{
    class Program
    {
        public static AppController _appController { get; set; }

        static void Main(string[] args)
        {
            _appController = new AppController(new AppView(), new UpdateStockItemView(), new Stock());
            
        }
    }
}
