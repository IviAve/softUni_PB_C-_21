using System;

namespace T06.OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());

            double sum = 0.0;
            //При събиране, изваждане и умножение на конзолата трябва да се отпечатат резултата и дали той е четен или нечетен.
            //При обикновеното деление – резултата. При модулното деление – остатъка.
            switch (symbol)
            {
                case '+':
                    sum = num1 + num2;
                    if (sum % 2 == 0)
                    {
                        Console.WriteLine($"{num1} + {num2} = {sum} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} + {num2} = {sum} - odd");
                    }
                    
                    break;
                case '-':
                    sum = num1 - num2;
                    if (sum % 2 == 0)
                    {
                        Console.WriteLine($"{num1} - {num2} = {sum} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} - {num2} = {sum} - odd");
                    }
                    break;
                case '*':
                    sum = num1 * num2;
                    if (sum % 2 == 0)
                    {
                        Console.WriteLine($"{num1} * {num2} = {sum} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} * {num2} = {sum} - odd");
                    }
                    break;
                case '/':
                    
                    if (num2 != 0)
                    {
                        sum = (double)num1 / num2;
                        Console.WriteLine($"{num1} / {num2} = {sum:f2}");
                    }
                    else
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    break;
                case '%':
                    if (num2 != 0)
                    {
                        sum = num1 % num2;
                        Console.WriteLine($"{num1} % {num2} = {sum}");
                    }
                    else
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    break;
            }
        }

    }
}

//Напишете програма, която чете две цели числа (N1 и N2) и оператор, с който да се извърши дадена математическа операция с тях.
//Възможните операции са: Събиране(+), Изваждане(-), Умножение(*), Деление(/) и Модулно деление(%).
//Трябва да се има предвид, че делителят може да е равен на 0(нула), а на нула не се дели.
//В този случай трябва да се отпечата специално съобщениe.
//Изход
//Да се отпечата на конзолата един ред:
//•	Ако операцията е деление:
//o "{N1} / {N2} = {резултат}" – резултатът е форматиран до вторият знак след дес.запетая
//•	Ако операцията е модулно деление: 
//o "{N1} % {N2} = {остатък}"
//•	В случай на деление с 0 (нула): 
//o "Cannot divide {N1} by zero"

