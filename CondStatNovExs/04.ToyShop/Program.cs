using System;

namespace _04.ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Петя има магазин за детски играчки. Тя получава голяма поръчка, която трябва да изпълни.
            //С парите, които ще спечели иска да отиде на екскурзия. 
            //Цени на играчките:
            const double puzzlePrice = 2.60;
            const double talkingDollPrice = 3;
            const double bearPrice = 4.10;
            const double minionPrice = 8.20;
            const double truckPrice = 2;

           double excursionPrice = double.Parse(Console.ReadLine());
            int puzzlesPc = int.Parse(Console.ReadLine());
            int talkingDollsPc = int.Parse(Console.ReadLine());
            int bearsPc = int.Parse(Console.ReadLine());
            int minionsPc = int.Parse(Console.ReadLine());
            int trucksPc = int.Parse(Console.ReadLine());

            double sum = puzzlesPc * puzzlePrice + talkingDollsPc * talkingDollPrice + bearsPc * bearPrice 
                + minionsPc * minionPrice + trucksPc * truckPrice;

            double totalPc = puzzlesPc + talkingDollsPc + bearsPc + minionsPc + trucksPc;

            if (totalPc >= 50)
            {
                sum = sum * 0.75;
            }
            double rent = sum * 0.10;

            double totalSum = sum - rent;
            double difference = Math.Abs(totalSum - excursionPrice);

            if (totalSum >= excursionPrice)
            {
                Console.WriteLine($"Yes! {difference:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {difference:f2} lv needed.");    
            }
        }   

    }
}

//Ако поръчаните играчки са 50 или повече магазинът прави отстъпка 25% от общата цена.
//От спечелените пари Петя трябва да даде 10% за наема на магазина. Да се пресметне дали парите ще ѝ стигнат да отиде на екскурзия.
//Изход
//На конзолата се отпечатва:
//•	Ако парите са достатъчни се отпечатва:
//o "Yes! {оставащите пари} lv left."
//•	Ако парите НЕ са достатъчни се отпечатва:
//o "Not enough money! {недостигащите пари} lv needed."

//Резултатът трябва да се форматира до втория знак след десетичната запетая.
