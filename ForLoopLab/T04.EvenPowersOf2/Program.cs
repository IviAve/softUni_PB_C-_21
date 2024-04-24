using System;

namespace T04.EvenPowersOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int power = 0; power <= n; power +=2)
            {
                Console.WriteLine(Math.Pow(2,power));
            }
        }
    }
}

//Да се напише програма, която чете число n, въведено от потребителя, и печата четните степени на 2 ≤ 2n: 20, 22, 24, 26, …, 2n. 