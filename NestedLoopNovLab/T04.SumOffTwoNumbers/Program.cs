using System;

namespace T04.SumOffTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int combinationCouter = 0;

            for (int a = start; a <= end; a++)
            {
                for (int b = start; b <=end; b++)
                {
                    combinationCouter++;
                    int sum = a + b;

                    if (sum==magicNum)
                    {
                        Console.WriteLine($"Combination N:{combinationCouter} ({a} + {b} = {magicNum})");
                        return;
                    }
                }

            }
            Console.WriteLine($"{combinationCouter} combinations - neither equals {magicNum}");
        }
    }
}


//Напишете програма която проверява всички възможни комбинации от двойка числа в интервала от две дадени числа
//. На изхода се отпечатва, коя поред е комбинацията чиито сбор от числата е равен на дадено магическо число.
//Ако няма нито една комбинация отговаряща на условието се отпечатва съобщение, че не е намерено.
//Вход
//Входът се чете от конзолата и се състои от три реда:
//•	Първи ред – начало на интервала – цяло число в интервала [1...999]
//•	Втори ред – край на интервала – цяло число в интервала [по-голямо от първото число...1000]
//•	Трети ред – магическото число – цяло число в интервала [1...10000]
//Изход
//На конзолата трябва да се отпечата един ред, според резултата:
//•	Ако е намерена комбинация чиито сбор на числата е равен на магическото число
//o	"Combination N:{пореден номер} ({първото число} + {второ число} = {магическото число})"
//•	Ако не е намерена комбинация отговаряща на условието
//o	"{броят на всички комбинации} combinations - neither equals {магическото число}"
