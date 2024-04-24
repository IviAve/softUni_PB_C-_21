using System;

namespace T08.NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;
           
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number> maxNumber)
                {
                    maxNumber = number;
                }
                if (number<minNumber)
                {
                    minNumber = number;
                }

            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
       
    }
}

//Напишете програма, която чете n на брой цели числа. Принтирайте най-голямото и най-малкото число сред въведените.