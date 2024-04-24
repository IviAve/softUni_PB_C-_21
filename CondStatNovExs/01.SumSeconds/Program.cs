using System;

namespace _01.SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            int sum = firstTime + secondTime + thirdTime;

            int minutes = sum / 60;
            int seconds = sum % 60;

            Console.WriteLine($"{minutes}:{seconds:d2}");
        }
    }
}

//Трима спортни състезатели финишират за някакъв брой секунди (между 1 и 50).
//Да се напише програма, която чете времената на състезателите в секунди,
//въведени от потребителя и пресмята сумарното им време във формат "минути:секунди".
//Секундите да се изведат с водеща нула (2  "02", 7  "07", 35  "35"). 