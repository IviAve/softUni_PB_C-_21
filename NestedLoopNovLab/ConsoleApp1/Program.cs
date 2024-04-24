using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacity = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double volume = 0;
            double moreVolume = 0;
            int count = 0;

            while (input != "End")
            {
                volume = double.Parse(input);

                if (volume >= capacity)
                {
                    break;
                    
                }
                Console.WriteLine("No more space!");
                capacity -= volume;
                count++;
                if (count %3 ==0)
                {
                    moreVolume += volume * 0.1;
                    capacity -= moreVolume;


                }
            }
            
        }
    }
}
