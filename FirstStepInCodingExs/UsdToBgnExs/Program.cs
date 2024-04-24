using System;

namespace UsdToBgnExs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("usd = ");
            double usd = double.Parse(Console.ReadLine());
            double bgn = usd * 1.79549;
            Console.Write("bgn = ");
            Console.WriteLine(bgn);
        }
    }
}
