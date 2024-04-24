using System;

namespace _03.RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse (Console.ReadLine());
            int b = int.Parse (Console.ReadLine());

            int area = a * b;

            Console.WriteLine(area);
            
        }
    }
}


//Да се напише конзолна програма, която въвежда две цели числа (страните на правоъгълника a и b) и пресмята лицето на правоъгълник с тези страни.