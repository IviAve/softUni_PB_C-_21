using System;

namespace T05.AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double balance = 0.0;
            while (input != "NoMoreMoney")
            {
                double amount = double.Parse(input);
                 if (amount < 0)
                {
                    
                    Console.WriteLine($"Invalid operation!");
                    break;
                }
                else if (amount > 0)
                {
                    balance += amount;
                    Console.WriteLine($"Increase: {amount:F2}");
                    input = Console.ReadLine();
                }
                


            }
            Console.WriteLine($"Total: {balance:F2}");
        }
    }
}

//Напишете програма, която пресмята колко общо пари има в сметката,
//след като направите определен брой вноски.
//На всеки ред ще получавате сумата, която трябва да внесете в сметката,
//до получаване на команда "NoMoreMoney" .
//При всяка получена сума на конзолата трябва да се извежда "Increase: " + сумата и тя да се прибавя в сметката.
//Ако получите число по-малко от 0 на конзолата трябва да се изведе "Invalid operation!" и програмата да приключи.
//Когато програмата приключи трябва да се принтира "Total: " + общата сума в сметката
//форматирана до втория знак след десетичната запетая. 