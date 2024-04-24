using System;

namespace _01Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pricePremiere = 12.00;
            const double priceNormal = 7.50;
            const double priceDiscount = 5.00;

            string typeProjection = Console.ReadLine();
            int numR = int.Parse(Console.ReadLine());
            int numC = int.Parse(Console.ReadLine());

            double totalPrice = 0;
            switch (typeProjection)
            {
                case "Premiere":
                    totalPrice = numC * numR * pricePremiere;
                    break;
                case "Normal":
                    totalPrice = numC * numR * priceNormal;
                    break;
                case "Discount":
                    totalPrice = numC * numR * priceDiscount;
                    break;
            }
            Console.WriteLine($"{totalPrice:f2} leva");

        }
    }
}

//В една кинозала столовете са наредени в правоъгълна форма в r реда и c колони. Има три вида прожекции с билети на различни цени:
//•	Premiere – премиерна прожекция, на цена 12.00 лева.
//•	Normal – стандартна прожекция, на цена 7.50 лева.
//•	Discount – прожекция за деца, ученици и студенти на намалена цена от 5.00 лева.
//Напишете програма, която чете тип прожекция (стринг), брой редове и брой колони в залата (цели числа),
//въведени от потребителя, и изчислява общите приходи от билети при пълна зала.
//Резултатът да се отпечата във формат като в примерите по-долу, с 2 знака след десетичната точка.  
