using System;

namespace T09.SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PRICE_FOR_ROOM = 18;
            const double PRICE_FOR_APARTMENT = 25;
            const double PRICE_FOR_PREZIDENT_APARTMENT = 35;
            //Вход
            //Входът се чете от конзолата и се състои от три реда:
            //•	Първи ред - дни за престой - цяло число в интервала [0...365]
            //•	Втори ред - вид помещение - "room for one person", "apartment" или "president apartment"
            //•	Трети ред - оценка - "positive"  или "negative"

            int dayOfStay = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string rating = Console.ReadLine();

            double nights = dayOfStay - 1;
            double totalPrice = 0;

            switch (typeOfRoom)
            {
                case "room for one person":
                    totalPrice = nights * PRICE_FOR_ROOM;
                    break;
                case "apartment":
                    totalPrice = nights * PRICE_FOR_APARTMENT;
                    if (dayOfStay <10)
                    {
                        totalPrice -= totalPrice * 0.30;
                    }
                    else if (dayOfStay >= 10 && dayOfStay <=15)
                    {
                        totalPrice -= totalPrice * 0.35;
                    }
                    else
                    {
                        totalPrice -= totalPrice * 0.50;
                    }
                    break;
                case "president apartment":
                    totalPrice = nights * PRICE_FOR_PREZIDENT_APARTMENT;
                    if (dayOfStay < 10)
                    {
                        totalPrice -= totalPrice * 0.10;
                    }
                    else if (dayOfStay >=10 && dayOfStay <= 15)
                    {
                        totalPrice -= totalPrice * 0.15;
                    }
                    else
                    {
                        totalPrice -= totalPrice * 0.20;
                    }
                    break;
            }
            switch (rating)
            {
                case "positive":
                    totalPrice += totalPrice * 0.25;
                    break;
                case "negative":
                    totalPrice -= totalPrice * 0.10;
                    break;
            }
            Console.WriteLine($"{totalPrice:f2}");

        }
    }
}

//Атанас решава да прекара отпуската си в Банско и да кара ски. Преди да отиде обаче,
//трябва да резервира хотел и да изчисли колко ще му струва престоя. Налични са следните видове помещения, със следните цени за престой:
//	"room for one person" – 18.00 лв за нощувка
//	"apartment" – 25.00 лв за нощувка 
//	"president apartment" – 35.00 лв за нощувка
//Според броят на дните, в които ще остане в хотела (пример: 11 дни = 10 нощувки) и видът на помещението, което ще избере, той може да ползва различно намаление. 
//Намаленията са както следва:
//вид помещение	         по-малко от 10 дни	    между 10 и 15 дни	     повече от 15 дни
//room for one person	    не ползва намаление	   не ползва намаление	   не ползва намаление
//apartment	            30% от крайната цена	35% от крайната цена	50% от крайната цена
//president apartment	   10% от крайната цена	   15% от крайната цена	    20% от крайната цена

//След престоя, оценката на Атанас за услугите на хотела може да е позитивна (positive) или негативна(negative) .
//Ако оценката му е позитивна, към цената с вече приспаднатото намаление Атанас добавя 25% от нея.
//Ако оценката му е негативна приспада от цената 10%.
//Изход
//На конзолата трябва да се отпечата един ред:
//•	Цената за престоят му в хотела, форматирана до втория знак след десетичната запетая.
