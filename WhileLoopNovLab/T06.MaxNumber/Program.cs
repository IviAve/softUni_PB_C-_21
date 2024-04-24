using System;

namespace T06.MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = (Console.ReadLine());
            int highNum = int.MinValue;

            while (n != "Stop")
            {
                

                int currentNum = int.Parse(n);
                
                if (highNum<currentNum)
                {
                    highNum = currentNum;
                    

                }
                n = Console.ReadLine();
            }
            Console.WriteLine(highNum);
        }
    }
}

//Напишете програма, която до получаване на командата "Stop", чете цели числа,
//въведени от потребителя и намира най-голямото измежду тях.
//Въвежда се по едно число на ред. 