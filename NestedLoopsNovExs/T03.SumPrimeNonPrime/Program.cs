using System;

namespace T03.SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int sumOfPrimeNum = 0;
            int sumOfNonPrimeNum = 0;

            while (command != "stop")
            {
                int num = int.Parse(command);

                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    int count = 0;

                    for (int i = 1; i <= num; i++)
                    {
                        if (num%i == 0)
                        {
                            count++;
                        }
                    }
                    if (count == 2)
                    {
                        sumOfPrimeNum += num;
                    }
                    else
                    {
                        sumOfNonPrimeNum += num;
                    }
                }
                command = Console.ReadLine();

            }
            Console.WriteLine($"Sum of all prime numbers is: {sumOfPrimeNum}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumOfNonPrimeNum}");
        }
    }
}

//Напишете програма, която чете от конзолата цели числа в диапазона, докато не се получи команда "stop".
//Да се намери сумата на всички въведени прости и сумата на всички въведени непрости числа.
//Тъй като по дефиниция от математиката отрицателните числа не могат да бъдат прости,
//ако на входа се подаде отрицателно число да се изведе следното съобщение "Number is negative.".
//В този случай въведено число се игнорира и не се прибавя към нито една от двете суми,
//а програмата продължава своето изпълнение, очаквайки въвеждане на следващо число. 
//На изхода да се отпечатат на два реда двете намерени суми в следния формат:
//•	"Sum of all prime numbers is: {prime numbers sum}"
//•	"Sum of all non prime numbers is: {nonprime numbers sum}"
//Първото въведено число е 3. То е просто и го прибавяме съм сумата на простите числа.
//Следващото число е 9. То не е просто и го прибавяме към сумата на непростите числа. 
//Числото 0 не е просто число и го прибавяме към сумата на непростите числа. Сумата става 9+0=9.
//Следващите две числа са 7 и 19. Те са прости и всяко едно от тях го прибавяме към сумата на простите числа. 3+7=10 и 10+19=29.
//Следва числото 4, което не е просто и го прибавяме към съответната сума 9+4=13.
//Получаваме команда stop. Програмата прекъсва своето изпълнение и отпечатваме двете суми.
