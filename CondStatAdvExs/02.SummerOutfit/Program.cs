using System;

namespace _02.SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            string outfit = "";
            string shoes = "";
            switch (time)
            {
                case "Morning":
                    if (degrees >= 10 && degrees <=18)
                    {
                        outfit = "Sweatshirt";
                        shoes = "Sneakers";
                    }
                    else if (degrees <= 24)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (degrees >= 25)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    break;
                case "Afternoon":
                    if (degrees >= 10 && degrees <= 18)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (degrees <= 24)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    else if (degrees >= 25)
                    {
                        outfit = "Swim Suit";
                        shoes = "Barefoot";
                    }
                    break;
                case "Evening":
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    break;
                   
            }
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
        }
    }
}

//Лято е с много променливо време и Виктор има нужда от вашата помощ.
//Напишете програма която спрямо времето от денонощието и градусите
//да препоръча на Виктор какви дрехи да си облече.
//Вашия приятел има различни планове за всеки етап от деня, които изискват и различен външен вид,
//тях може да видите от таблицата.
//От конзолата се четат точно два реда:
//•	Градусите - цяло число в интервала [10…42]
//•	Текст, време от денонощието - с възможности - "Morning", "Afternoon", "Evening"

