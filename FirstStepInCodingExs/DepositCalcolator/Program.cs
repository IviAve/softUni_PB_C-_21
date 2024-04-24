using System;

namespace DepositCalcolator
{
    class Program   
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int periodInMonth = int.Parse(Console.ReadLine());
            double annualInterestRate = double.Parse(Console.ReadLine());

            double sum = depositSum + periodInMonth * ((depositSum * annualInterestRate/100) / 12);
            
            Console.WriteLine(sum);

        }
    }
}


//сума = депозирана сума + срок на депозита * ((депозирана сума * годишен лихвен процент ) / 12)

//1.Депозирана сума – реално число в интервала [100.00 … 10000.00]
//2.Срок на депозита(в месеци) – цяло число в интервала [1…12]
//3.Годишен лихвен процент – реално число в интервала [0.00 …100.00]
