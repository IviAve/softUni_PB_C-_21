using System;

namespace T03.Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int validCombCount = 0;

            for (int x1 = 0; x1 <= n; x1++)
            {
                for (int x2 = 0; x2 <= n; x2++)
                {
                    for (int x3 = 0; x3 <=n; x3++)
                    {
                        if (x1 + x2 + x3 == n)
                        {
                            validCombCount++;
                        }
                    }


                }
            }
            Console.WriteLine(validCombCount);
        }
        
    }
}

//Напишете програма, която изчислява колко решения в естествените числа (включително и нулата) има уравнението:
//x1 + x2 + x3 = n
//Числото n е цяло число и се въвежда от конзолата. 
