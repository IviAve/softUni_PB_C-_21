using System;

namespace _03.CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            

            
            double C = double.Parse(Console.ReadLine());
            double F = C * 1.8000 + 32.00;
            
            Console.WriteLine($"{F:f2}");

        }
    }
}

//Напишете програма, която чете градуси по скалата на Целзий (°C) и ги преобразува до градуси по скалата на Фаренхайт (°F).
//Потърсете в Интернет подходяща формула, с която да извършите изчисленията.
//Форматирате изхода до втория знак след десетичната запетая. 
