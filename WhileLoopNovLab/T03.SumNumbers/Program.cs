using System;

namespace T03.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            while (sum<num)
            {
                int currentNum = int.Parse(Console.ReadLine());

                sum += currentNum;
            }
            Console.WriteLine(sum);
        }
    }
}

//Напишете програма, която чете цяло число от конзолата и на всеки следващ ред цели числа,
//докато тяхната сума стане по-голяма или равна на първоначалното число.
//След приключване да се отпечата сумата на въведените числа.