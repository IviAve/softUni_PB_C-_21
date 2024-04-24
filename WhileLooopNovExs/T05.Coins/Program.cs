using System;

namespace T05.Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());
            double convertedChange = change * 100;
            int cents = (int)convertedChange;
            int coins = 0;

            while (cents > 0)
            {
                if (cents - 200 >= 0)
                {
                    coins++;
                    cents -= 200;
                }
                else if (cents - 100 >= 0)
                {
                    coins++;
                    cents -= 100;
                }
                else if (cents - 50 >= 0)
                {
                    coins++;
                    cents -= 50;
                }
                else if (cents - 20 >= 0)
                {
                    coins++;
                    cents -= 20;
                }
                else if (cents - 10 >= 0)
                {
                    coins++;
                    cents -= 10;
                }
                else if (cents - 5 >= 0)
                {
                    coins++;
                    cents -= 5;
                }
                else if (cents - 2 >= 0)
                {
                    coins++;
                    cents -= 2;
                }
                else if (cents - 1 >= 0)
                {
                    coins++;
                    cents -= 1;
                }
            }
            Console.WriteLine(coins);
        }
    }
}

//Производителите на вендинг машини искали да направят машините си да връщат възможно най-малко монети ресто.
//Напишете програма, която приема сума - рестото, което трябва да се върне и изчислява с колко най-малко монети може да стане това.

//T05 coins 2 reshenie
//double change = double.Parse(Console.ReadLine());

//int coins = 0;

//while (change > 0)
//{
//    change = Math.Round(change, 2);

//    if (change >= 2)
//    {
//        coins++;
//        change -= 2;
//    }
//    else if (change >= 1)
//    {
//        coins++;
//        change -= 1;
//    }
//    else if (change >= 0.50)
//    {
//        coins++;
//        change -= 0.50;
//    }
//    else if (change >= 0.20)
//    {
//        coins++;
//        change -= 0.20;
//    }
//    else if (change >= 0.10)
//    {
//        coins++;
//        change -= 0.10;
//    }
//    else if (change >=0.05)
//    {
//        coins++;
//        change -= 0.05;
//    }
//    else if (change >=0.02)
//    {
//        coins++;
//        change -= 0.02;
//    }
//    else if (change >=0.01)
//    {
//        coins++;
//        change -= 0.01;
//    }
//}
//Console.WriteLine(coins);