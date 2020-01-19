using System;

namespace SouzaADM.Views
{
    public interface IUpdateStockItemView
    {
        public string GetCommand();
        public int GetIncrementalQuantity();
        public int GetDecrementalQuantity();

        public int GetUpdateQuantity();
    }
}