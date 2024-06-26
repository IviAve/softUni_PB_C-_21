﻿using System;

namespace Т_03.EasterTrip
{
    class Program
    {
        static void Main(string[] args)
        {

            //Вход
            //Входът се чете от конзолата и се състои от три реда:
            //•	Първи ред - дестинация - текст с възможности"France", "Italy" или "Germany"
            //•	Втори ред - дати, през които си е резервирала екскурзията - текст  с възможности "21-23",
            //"24-27" или "28-31"
            //•	Трети ред - брой нощувки - цяло число в интервала [1… 100]

            string destination = (Console.ReadLine());
            string dates = (Console.ReadLine());
            int numNights = int.Parse(Console.ReadLine());

            double pricePerNight = 0;

            if (destination == "France")
            {
                switch (dates)
                {
                    case "21-23":
                        pricePerNight = 30;
                        break;
                    case "24-27":
                        pricePerNight = 35;
                        break;
                    case "28-31":
                        pricePerNight = 40;
                        break;

                }
            }
            else if (destination == "Italy")
            {
                switch (dates)
                {
                    case "21-23":
                        pricePerNight = 28;
                        break;
                    case "24-27":
                        pricePerNight = 32;
                        break;
                    case "28-31":
                        pricePerNight = 39;
                        break;

                }
            }
            else if (destination == "Germany")
            {
                switch (dates)
                {
                    case "21-23":
                        pricePerNight = 32;
                        break;
                    case "24-27":
                        pricePerNight = 37;
                        break;
                    case "28-31":
                        pricePerNight = 43;
                        break;

                }
            }
            double totalPrice = pricePerNight * numNights;
            Console.WriteLine($"Easter trip to {destination} : {totalPrice:f2} leva.");

            //      Дестинация  21 - 23 март  24 - 27 март  28 - 31 март
            //       Франция       30 лв.        35 лв.      40 лв.
            //       Италия       28 лв.      32 лв.          39 лв.
            //      Германия      32 лв.       37 лв.        43 лв.

        }
    }
}


//Екскурзията е до Германия и е резервирала на 24-27 март => цена за нощувката = 37 лв.
//Общ разход = 5 нощувки * 37 лв. = 185 лв.

//По време на Великденските празници, Деси иска да отиде на почивка.
//В таблицата са показани кои са дестинациите и каква е цената за нощувка спрямо датите,
//през които си е резервирала екскурзията. 
//Напишете програма, която изчислява колко ще струва екскурзията на Деси, като знаете дестинацията,
//на която иска да отиде, кога си е резервирала екскурзията и за колко нощувки ще е в дадената страна.
//Изход
//На конзолата трябва да се отпечата един ред:
//"Easter trip to {дестинация} : {разходи за екскурзията} leva."
//Разходите за екскурзията да бъдат форматирани до втората цифра след десетичния знак.
