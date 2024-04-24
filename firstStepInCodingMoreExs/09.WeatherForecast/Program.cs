using System;

namespace _09.WeatherForecast
{
    class Program
    {
        static void Main(string[] args)
        {
            string time = Console.ReadLine();

            if (time == "sunny")
            {
                Console.WriteLine("It's warm outside!");

            }
            else
            {
                Console.WriteLine("It's cold outside!");
            }
        }
    }
}

//Напишете програма, която познава дали е топло или студено навън. От конзолата се чете един ред – текст, който подсказва какво е времето.
//При въвеждане на "sunny" трябва да се отпечата "It's warm outside!".
//Във всички останали случаи трябва да се отпечата "It's cold outside!". 