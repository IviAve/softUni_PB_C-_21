using System;

namespace T04.Sequence2kAnd1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = 1;

            while (k<= n)
            {
                Console.WriteLine(k);
                k = 2 *k +1;
            }
        }
    }
}

//Напишете програма, която чете число n, въведено от потребителя,
//и отпечатва всички числа ≤ n от редицата: 1, 3, 7, 15, 31, ….
//Всяко следващо число се изчислява като умножим предишното с 2 и добавим 1.