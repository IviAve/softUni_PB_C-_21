using System;

namespace T04.TouristShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            string input = (Console.ReadLine());

            int totalProducts = 0;
            double totalSum = 0;
            int counter = 0;


            while (input != "Stop")
            {
                
                
                double priceForProduct = double.Parse(Console.ReadLine());
                counter++;
                if (counter % 3 == 0)
                {
                    priceForProduct = priceForProduct / 2;

                }
                if (priceForProduct>budget)
                {
                    Console.WriteLine($"You don't have enough money!");
                    Console.WriteLine($"You need {priceForProduct-budget:f2} leva!");
                    break;
                }
                else 
                {
                    budget -= priceForProduct;
                    totalSum += priceForProduct;
                }
                


                input = (Console.ReadLine());
            }
            if (input == "Stop")
            {
                Console.WriteLine($"You bought {counter} products for {totalSum:f2} leva.");
            }
        }
    }
}

//Времето се затопля и туристите започват да си правят разходки високо в планината, където все още има сняг,
//като за целта те трябва да закупят нужната туристическа екипировка.
//Вашата задача е да напишете програма, която да изчислява, стойността на екипировката,
//както и дали определения бюджет е достатъчен или не, като се знае, че в магазина има следната промоция: Всеки трети продукт е на половин цена.
//Вход
//От конзолата се чете:
//•	На първи ред – бюджетът - реално число в интервала [1.00… 100000.00]
//•	След това поредица от два реда (до получаване на команда "Stop" или при заявка за купуване на продукт, чиято стойност е по-висока от наличния бюджет) :
//o Име на продукта – текст
//o	Цена на продукта – реално число в интервала [1.00… 5000.00]
//Изход
//На конзолата да се отпечатат следните редове според случая:
//•	При получаване на командата "Stop", на един ред:
//o "You bought {брой на закупените продукти} products for {цена на покупките} leva."
//•	При заявка за покупка на продукт, чиято цена е по-висока от останалите пари, на два реда:
//o "You don't have enough money!"
//o "You need {недостигащи пари} leva!"
