using System;
using System.Collections.Generic;

namespace Bankomat
{
    class Program
    {
        static void Main(string[] args)
        {
            int cashToExchange = 888;
            MoneyChanger moneyChanger = new MoneyChanger();
                       
            var moneyAmount = moneyChanger.MoneyEncounter(cashToExchange);
            Console.WriteLine("$ to release: "+ cashToExchange);
            foreach (var item in moneyAmount)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }
        }
    }
}
