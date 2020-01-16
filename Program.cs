using SouzaADM.Controllers;
using System;

namespace SouzaADM
{
    class Program
    {
        public static AppController _appController { get; set; }

        static void Main(string[] args)
        {
            _appController = new AppController();
            
        }
    }
}
