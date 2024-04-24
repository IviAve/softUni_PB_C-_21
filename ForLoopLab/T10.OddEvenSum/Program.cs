using System;

namespace T10.OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    int num = int.Parse(Console.ReadLine());
                    evenSum += num;
                }
                else
                {
                    int num = int.Parse(Console.ReadLine());
                    oddSum += num;
                }

            }


            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evenSum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(evenSum - oddSum)}");
            }
        }
    }
}

//Да се напише програма, която чете n-на брой цели числа, подадени от потребителя и
//проверява дали сумата от числата на четни позиции е равна на сумата на числата на нечетни позиции. 
//•	Ако сумите са равни да се отпечатат два реда: "Yes" и на нов ред "Sum = " + сумата; 
//•	Ако сумите не са равни да се отпечат два реда: "No" и на нов ред "Diff = " + разликата. 
//Разликата се изчислява по абсолютна стойност. 
