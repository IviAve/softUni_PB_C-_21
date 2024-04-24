using System;

namespace _04.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PRICE_FISHBOAT_IN_SPRING = 3000;
            const double PRICE_FISHBOAT_IN_SUMMER_AND_AUTUMN = 4200;
            const double PRICE_FISHBOAT_IN_WINTER = 2600;

            //Вход
            //От конзолата се четат точно три реда.
            //•	Бюджет на групата – цяло число в интервала [1…8000]
            //•	Сезон –  текст: "Spring", "Summer", "Autumn", "Winter"
            //•	Брой рибари – цяло число в интервала [4…18]
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numOfFishermans = int.Parse(Console.ReadLine());

            double totalPrice = 0.0;

            switch (season)
            {
                case "Spring":
                    totalPrice = PRICE_FISHBOAT_IN_SPRING;
                    break;
                case "Summer":
                case "Autumn":
                    totalPrice = PRICE_FISHBOAT_IN_SUMMER_AND_AUTUMN;
                    break;
                case "Winter":
                    totalPrice = PRICE_FISHBOAT_IN_WINTER;
                    break;
            }
            if (numOfFishermans <= 6)
            {
                totalPrice -= totalPrice * 0.10;
            }
            else if (numOfFishermans >=7 && numOfFishermans <=11)
            {
                totalPrice -= totalPrice * 0.15;
            }
            else if (numOfFishermans >= 12)
            {
                totalPrice -= totalPrice * 0.25;
            }
            if (numOfFishermans % 2==0 && season != "Autumn")
            {
                totalPrice -= totalPrice * 0.05;
            }
            double difference = budget - totalPrice;

            Console.WriteLine(budget >= totalPrice ? $"Yes! You have {difference:f2} leva left." :
                $"Not enough money! You need {(totalPrice - budget):f2} leva.");
        }
    }
}

//Тони и приятели много обичали да ходят за риба, те са толкова запалени по риболова, че решават да отидат на риболов с кораб.
//Цената за наема на кораба зависи от сезона и броя рибари.
//В зависимост от броя си групата ползва отстъпка:
//•	Ако групата е до 6 човека включително  –  отстъпка от 10%.
//•	Ако групата е от 7 до 11 човека включително  –  отстъпка от 15%.
//•	Ако групата е от 12 нагоре  –  отстъпка от 25%. 
//Рибарите ползват допълнително 5% отстъпка, ако са четен брой освен ако не е есен - тогава нямат допълнителна отстъпка,
//която се начислява след като се приспадне отстъпката по горните критерии.
//Напишете програма, която да пресмята дали рибарите ще съберат достатъчно пари. 
//Изход
//Да се отпечата на конзолата един ред:
//•	Ако бюджетът е достатъчен:
//"Yes! You have {останалите пари} leva left."
//•	Ако бюджетът НЕ Е достатъчен:
//"Not enough money! You need {сумата, която не достига} leva."
//Сумите трябва да са форматирани с точност до два знака след десетичната запетая.
