using System;

namespace T03.CoffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {

            //Вход
            //Входът се чете от конзолата и се състои от три реда:
            //•	Първи ред - напитка - текст с възможности"Espresso", "Cappuccino" или "Tea"
            //•	Втори ред - захар - текст  с възможности "Without", "Normal" или "Extra"
            //•	Трети ред - брой напитки - цяло число в интервала [1… 50]
            string drink = Console.ReadLine();
            string sugar = Console.ReadLine();
            int numOfDrinks = int.Parse(Console.ReadLine());

            double totalSum = 0;
            double priceForDrinks = 0;

            switch (drink)
            {
                case "Espresso":
                    if (sugar == "Without")
                    {
                        priceForDrinks = numOfDrinks * 0.9;

                        totalSum += priceForDrinks * 0.65;
                    }
                    else if (sugar == "Normal")
                    {
                        priceForDrinks = numOfDrinks * 1;
                        totalSum += priceForDrinks;
                    }
                    else if (sugar == "Extra")
                    {
                        priceForDrinks = numOfDrinks * 1.2;
                        totalSum += priceForDrinks;
                    }
                    if (numOfDrinks >= 5)
                    {
                        totalSum -= totalSum * 0.25;
                    }

                    break;
                case "Cappuccino":

                    if (sugar == "Without")
                    {
                        priceForDrinks = numOfDrinks * 1;
                        totalSum += priceForDrinks * 0.65;
                    }
                    else if (sugar == "Normal")
                    {
                        priceForDrinks = numOfDrinks * 1.2;
                        totalSum += priceForDrinks;
                    }
                    else if (sugar == "Extra")
                    {
                        priceForDrinks = numOfDrinks * 1.6;
                        totalSum += priceForDrinks;
                    }
                    break;
                case "Tea":

                    if (sugar == "Without")
                    {
                        priceForDrinks = numOfDrinks * 0.5;
                        totalSum += priceForDrinks * 0.65;
                    }
                    else if (sugar == "Normal")
                    {
                        priceForDrinks = numOfDrinks * 0.6;
                        totalSum += priceForDrinks;
                    }
                    else if (sugar == "Extra")
                    {
                        priceForDrinks = numOfDrinks * 0.7;
                        totalSum += priceForDrinks;
                    }
                    break;
            }
            
             if (totalSum > 15.0)
            {
                totalSum -= totalSum * 0.20;
            }

            Console.WriteLine($"You bought {numOfDrinks} cups of {drink} for {totalSum:f2} lv.");
            //            Без захар      Нормално      Допълнително захар
            //Еспресо      0.90 лв./ бр.    1 лв. / бр.    1.20 лв. / бр.
            //Капучино    1.00 лв. / бр.   1.20 лв. / бр.   1.60 лв. / бр.
            //Чай         0.50 лв. / бр.  0.60 лв. / бр.     0.70 лв. / бр.

        }
    }
}

//Напишете софтуер, който да пресмята сметката на клиент, закупил определен брой от дадена напитка от кафемашина.
//Трябва да имате предвид следните отстъпки:
//•	При избрана напитка без захар има 35% отстъпка.
//•	При избрана напитка "Espresso" и закупени поне 5 броя, има 25% отстъпка.
//•	При сума надвишава 15 лева, 20% отстъпка от крайната цена,
//Отстъпките се прилагат в реда на тяхното описване.
//Изход
//На конзолата трябва да се отпечата един ред:
//"You bought {брой напитки} cups of {напитка} for {крайна цена} lv."
//Цената да бъде форматирана до втората цифра след десетичния знак.
