using System;

namespace T01.ReadText
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Stop")
                {
                    break;
                }
                Console.WriteLine(input);
            }

        }
    }
}

//Напишете програма, която чете текст от конзолата (стринг) и го принтира, докато не получи командата "Stop".