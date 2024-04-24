using System;

namespace _10.WeatherForecastPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            double degrees = double.Parse(Console.ReadLine());

            if (degrees >=26.00 && degrees<= 35.00)
            {
                Console.WriteLine("Hot");
            }
            else if (degrees >= 20.1 && degrees<= 25.9)
            {
                Console.WriteLine("Warm");
            }  
            else if (degrees >= 15.00 && degrees<= 20.00)
            {
                Console.WriteLine("Mild");
            }   
            else if (degrees >= 12.00 && degrees<= 14.9)
            {
                Console.WriteLine("Cool");
            }   
            else if (degrees >= 5.00 && degrees<= 11.9)
            {
                Console.WriteLine("Cold");
            }
            else
            {
                Console.WriteLine("unknown");
            }
            




        }
    }
}

//10.Прогноза за времето – част 2
//Напишете програма, която при въведени градуси (реално число) принтира какво е времето, като имате предвид следната таблица:
//Градуси Време
//26.00 - 35.00	Hot
//20.1 - 25.9	Warm
//15.00 - 20.00	Mild
//12.00 - 14.9	Cool
//5.00 - 11.9	Cold
//Ако се въведат градуси, различни от посочените в таблицата, да се отпечата "unknown".
