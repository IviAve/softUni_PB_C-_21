using System;

namespace T02.HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxNum = int.MinValue;
             int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                if (num > maxNum)
                {
                    maxNum = num;
                }
            }
            int diff = sum - maxNum;

            if (diff == maxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(maxNum - diff)}");
            }

        }
    }
}

//Да се напише програма, която чете n-на брой цели числа, въведени от потребителя,
//и проверява дали сред тях съществува число, което е равно на сумата на всички останали. 
//•	Ако има такъв елемент печата "Yes" и на нов ред "Sum = "  + неговата стойност
//•	Ако няма такъв елемент печата "No" и на нов ред "Diff = " + разликата между най-големия елемент и сумата на останалите (по абсолютна стойност)
