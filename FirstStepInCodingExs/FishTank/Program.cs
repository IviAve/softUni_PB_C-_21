using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double volume = length * width * height;
            double volumeInLitres = volume / 1000;

            double litresWater = volumeInLitres * (1 - percent / 100.0);

            Console.WriteLine(litresWater);

        }
    }
}
