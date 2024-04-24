using System;

namespace _04.VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double N = double.Parse(Console.ReadLine());
            double M = double.Parse(Console.ReadLine());
            int kgVegetables = int.Parse(Console.ReadLine());
            int kgFruits = int.Parse(Console.ReadLine());

            double earningInBgn = kgVegetables * N + kgFruits * M;
            double earningInEuro = earningInBgn / 1.94;

            Console.WriteLine($"{earningInEuro:f2}");

        }
    }
}

//Градинар продавал реколтата от градината си на зеленчуковата борса. Продава зеленчуци за N лева на килограм и плодове за M лева за килограм.
//Напишете програма, която да пресмята приходите от реколтата в евро ( ако приемем, че едно евро е равно на 1.94лв).
//Изход
//Да се отпечата на конзолата едно число: приходите от всички плодове и зеленчуци в евро.
//Резултата да се форматира до втория знак след десетичния разделител.
