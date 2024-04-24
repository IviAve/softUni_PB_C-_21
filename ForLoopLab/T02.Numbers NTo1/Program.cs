using System;

namespace T02.Numbers_NTo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i= num; i >= 1 ;i--)
            {
               Console.WriteLine(i);
            }
        }
    }
}

//Напишете програма, която чете цяло положително число n, въведено от потребителя и печата числата от n до 1 в обратен ред.
//Въведеното число n, винаги ще бъде по-голямо от 1.