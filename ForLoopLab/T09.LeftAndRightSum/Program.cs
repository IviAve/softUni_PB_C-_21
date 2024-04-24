using System;

namespace T09.LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double leftSum = 0;
            double rightSum = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                leftSum += num;
            }
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                rightSum += num;
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
            }
        }
    }
}

//Да се напише програма, която чете 2*n-на брой цели числа, подадени от потребителя,
//и проверява дали сумата на първите n числа (лява сума) е равна на сумата на вторите n числа (дясна сума).
//При равенство печата " Yes, sum = " + сумата; иначе печата " No, diff = " + разликата.
//Разликата се изчислява като положително число (по абсолютна стойност). 