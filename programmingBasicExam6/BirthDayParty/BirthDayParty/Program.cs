using System;

namespace BirthDayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double rent = double.Parse(Console.ReadLine());
            
            double priceOfCake = rent * 0.20;
            double drinks = priceOfCake * 0.55;
            double animator = rent / 3;
            double totalBudget = rent + priceOfCake + drinks + animator;

            Console.WriteLine(totalBudget);
                    

        }
    }
}
