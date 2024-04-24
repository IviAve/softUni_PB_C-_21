using System;

namespace T02.FamilyTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вход
            //От конзолата се четат 4 реда:
            //•	Бюджетът, с който разполагат – реално число в интервала [1.00 … 10000.00]
            //•	Брой нощувки – цяло число в интервала [0 … 1000]
            //•	Цена за нощувка – реално число в интервала [1.00 … 500.00]
            //•	Процент за допълнителни разходи – цяло число в интервала [0 … 100]

            double budget = double.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double nightPrice = double.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());

            if (nights > 7)
            {
                nightPrice = nightPrice * 0.95;
            }

            double totalNightPrice = nights * nightPrice;
            double additionalCosts = budget * (percent / 100.0);

            double totalPrice = totalNightPrice + additionalCosts;
            if (totalPrice > budget)
            {
                double moneyNeed = totalPrice - budget;
                Console.WriteLine($"{moneyNeed:F2} leva needed.");
            }
            else
            {
                double moneyLeft = budget - totalPrice;
                Console.WriteLine($"Ivanovi will be left with {moneyLeft:F2} leva after vacation.");
            }
        }
    }
}

//Семейство Иванови планират семейната си почивка. Вашата задача е да напишете програма,
//която да изчислява дали предвидения от тях бюджет ще им стигне, като знаете колко нощувки са планирали,
//каква е цената за нощувка и колко процента от бюджета са предвидили за допълнителни разходи.
//Трябва да се има предвид, че ако броят на нощувките е по-голям от 7, цената за нощувка се намаля с 5%.
//Изход
//Отпечатването на конзолата зависи от резултата:
//•	Ако сумата е достатъчна:
//o "Ivanovi will be left with {останали пари след почивката} leva after vacation."
//•	Ако НЕ е достигната сумата:
//o "{парите нужни до достигане на целта} leva needed."
//Сума трябва да се форматира до втората цифра след десетичния знак.
