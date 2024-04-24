using System;

namespace T06.EasterDecoration
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfCustomers = int.Parse(Console.ReadLine());

            double totalMoneySpent = 0;

            for (int i = 0; i < numOfCustomers; i++)
            {
                int itemsCounter = 0;
                double total = 0;

                string item = Console.ReadLine();

                while (item != "Finish")
                {
                    itemsCounter++;

                    switch (item)
                    {
                        case "basket":
                            total += 1.50;
                            break;
                        case "wreath":
                            total += 3.80;
                            break;
                        case "chocolate bunny":
                            total += 7;
                            break;
                    }


                    item = Console.ReadLine();
                }

                if (itemsCounter % 2 == 0)
                {
                    total -= total * 0.20;
                }

                totalMoneySpent += total;

                Console.WriteLine($"You purchased {itemsCounter} items for {total:f2} leva.");
            }

            double average = totalMoneySpent / numOfCustomers;

            Console.WriteLine($"Average bill per client is: {average:f2} leva.");
        }
    }
}

//За великденските празници, магазин започва да продава три вида великденска украса –
//кошнички за яйца (basket), великденски венци(wreath) и шоколадови зайци (chocolate bunny).
//Вашата задача е да напишете програма, която да изчислява каква сметка трябва да плати всеки един клиент на магазина, като се има в предвид,
//че всеки клиент закупил четен брой продукти, ще получи 20% отстъпка от крайната цена. След като всички клиенти приключат с покупките,
//трябва да се отпечата средно по колко пари е похарчил всеки човек.
//Цените на продуктите са:
//•	кошничка за яйца (basket) – 1.50 лв.
//•	великденски венец(wreath) – 3.80 лв.
//•	шоколадов заек(chocolate bunny) – 7 лв.
//Вход
//От конзолата първоначално се чете един ред:
//•	Брои на клиентите в магазина – цяло число [1… 100]
//•	След това за всеки един клиент на нов ред до получаване на командата "Finish" се чете:
//o Покупката която клиента е избрал – текст ("basket", "wreath" или "chocolate bunny")
//Изход
//•	При получаване на командата "Finish" да се отпечата един ред:
//o "You purchased {броя на покупките} items for {крайната цена} leva."
//•	Накрая, след като всички клиенти приключат с покупките, да се отпечата на един ред
//o	"Average bill per client is: {средно аритметично на парите които е похарчил всеки един клиент} leva."
//Всички пари трябва да бъдат форматирани до втората цифра след десетичния знак.
