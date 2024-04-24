using System;

namespace T07.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;
                
            }
            Console.WriteLine(sum);
        }
    }
}

//Да се напише програма, която чете n-на брой цели числа, въведени от потребителя и ги сумира.
//•	От първия ред на входа се въвежда броят числа n.
//•	От следващите n реда се въвежда по едно цяло число.
//Програмата трябва да прочете числата, да ги сумира и да отпечата сумата им. 
