using System;

namespace _12.TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());

            double percent = 0;

            if (town == "Sofia")
            {
                if (volume >=0 && volume <=500)
                {
                    percent = 0.05;
                }
                else if (volume > 500 && volume <= 1000)
                {
                    percent = 0.07;
                }
                else if (volume > 1000 && volume <= 10000)
                {
                    percent = 0.08;
                }
                else if (volume > 10000)
                {
                    percent = 0.12;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town == "Varna")
            {
               // Varna       4.5 % 7.5 % 10 % 13 %
                if (volume >= 0 && volume <= 500)
                {
                    percent = 0.045;
                }
                else if (volume > 500 && volume <= 1000)
                {
                    percent = 0.075;
                }
                else if (volume > 1000 && volume <= 10000)
                {
                    percent = 0.10;
                }
                else if (volume > 10000)
                {
                    percent = 0.13;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town == "Plovdiv")
            {
              //  5.5 % 8 % 12 % 14.5 %
                if (volume >= 0 && volume <= 500)
                {
                    percent = 0.055;
                }
                else if (volume > 500 && volume <= 1000)
                {
                    percent = 0.08;
                }
                else if (volume > 1000 && volume <= 10000)
                {
                    percent = 0.12;
                }
                else if (volume > 10000)
                {
                    percent = 0.145;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");

            }
            double tradeCommission = volume * percent;
            if (tradeCommission != 0)
            {
                Console.WriteLine($"{tradeCommission:f2}");
            }
//            Град    (0 ≤ s ≤ 500) |(500 < s ≤ 1 000) (1 000 < s ≤ 10 000)  (s > 10 000)
//            Sofia       5 %              7 %                8 %                12 %
//            Varna       4.5 %            7.5 %              10 %               13 %
//            Plovdiv     5.5 %            8 %                12 %               14.5 %

        }
    }
}

//Фирма дава следните комисионни на търговците си според града, в който работят и обема на продажбите:
//Напишете конзолна програма, която чете име на град (стринг) и обем на продажби (реално число) , въведени от потребителя,
//и изчислява и извежда размера на търговската комисионна според горната таблица.
//Резултатът да се изведе форматиран до 2 цифри след десетичната точка.
//При невалиден град или обем на продажбите (отрицателно число) да се отпечата "error". 