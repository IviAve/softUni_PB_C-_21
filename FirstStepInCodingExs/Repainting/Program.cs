using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse (Console.ReadLine());
            int paint = int.Parse (Console.ReadLine());
            int diluent = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double costsNylon = (nylon + 2) * 1.50;
            double costsPaint = (paint + 0.10 * paint )* 14.50;
            double costsDiluent = diluent * 5;
            double bags = 0.40;

            double totalCosts = costsNylon + costsPaint + costsDiluent + bags;
            double costsMasters = (totalCosts * 0.30) * hours;

            double totalSum = totalCosts + costsMasters;

            Console.WriteLine(totalSum);

        }
    }
}
