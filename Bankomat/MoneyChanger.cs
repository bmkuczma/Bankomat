using System;
using System.Collections.Generic;
using System.Text;

namespace Bankomat
{
    public class MoneyChanger
    {
        public Dictionary<int, int> MoneyEncounter(int moneyAmount)
        {
            int money = moneyAmount;
            int increment = 0;
            var encounter = new Dictionary<int, int>();
            while (money > 0)
            {
                while (money >= 200)
                {
                    money -= 200;
                    encounter.Add(increment, 200);
                    increment++;
                }
                while (money >= 100)
                {
                    money -= 100;
                    encounter.Add(increment, 100);
                    increment++;
                }
                while (money >= 50)
                {
                    money -= 50;
                    encounter.Add(increment, 50);
                    increment++;
                }
                while (money >= 20)
                {
                    money -= 20;
                    encounter.Add(increment, 20);
                    increment++;
                }
                while (money >= 10)
                {
                    money -= 10;
                    encounter.Add(increment, 10);
                    increment++;
                }
                while (money >= 5)
                {
                    money -= 5;
                    encounter.Add(increment, 5);
                    increment++;
                } while (money >= 2)
                {
                    money -= 2;
                    encounter.Add(increment, 2);
                    increment++;
                } while (money >= 1)
                {
                    money -= 1;
                    encounter.Add(increment, 1);
                    increment++;
                }

            }
            return encounter;
        }
    }
}

