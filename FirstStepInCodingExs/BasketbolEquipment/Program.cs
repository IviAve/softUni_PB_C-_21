using System;

namespace BasketbolEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearTax = int.Parse(Console.ReadLine());

            double sneakers = yearTax - (yearTax * 0.40);
            double equipment = sneakers - (sneakers * 0.20);
            double ball = equipment / 4;
            double accessories = ball / 5;

            double expenses = yearTax + sneakers + equipment
                + ball + accessories;



            Console.WriteLine(expenses);

        }
    }
}
