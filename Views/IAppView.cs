using SouzaADM.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SouzaADM.Views
{
    public interface IAppView
    {
        public string GetCommand();
        public void ListStock(Stock s);
        public string GetProductName();
        public char GetProductType();
        public double GetProductPrice();
        public int GetProductQuantity();
    }
}
