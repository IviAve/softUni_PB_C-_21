using System;

namespace T07.MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int minNum =int.MaxValue;

            while (num != "Stop")
            {
                int currentNum = int.Parse(num);

                if (minNum > currentNum)
                {
                    minNum = currentNum;
                }
                num = Console.ReadLine();
            }
            Console.WriteLine(minNum);



        }



    }
}

//Напишете програма, която до получаване на командата "Stop", чете цели числа, въведени от потребителя и намира най-малкото измежду тях.
//Въвежда се по едно число на ред. 