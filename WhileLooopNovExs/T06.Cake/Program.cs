using System;

namespace T06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            int allPeacesOfCake = lenght * width;

            while (allPeacesOfCake >0)
            {
                string input = Console.ReadLine();
                if (input == "STOP")
                {
                    break;
                }

                int peaceCake = int.Parse(input);
                allPeacesOfCake -= peaceCake;
            }
            if (allPeacesOfCake >= 0)
            {
                Console.WriteLine($"{allPeacesOfCake} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(allPeacesOfCake)} pieces more.");
            }
        }
    }
}

//Поканени сте на 30-ти рожден ден, на който рожденикът черпи с огромна торта.
//Той обаче не знае колко парчета могат да си вземат гостите от нея.
//Вашата задача е да напишете програма, която изчислява броя на парчетата,
//които гостите са взели, преди тя да свърши.
//Ще получите размерите на тортата (широчина и дължина – цели числа в интервала [1...1000])
//и след това на всеки ред, до получаване на командата "STOP" или докато не свърши тортата, броят на парчетата, които гостите вземат от нея. 
//Бележка: Едно парче торта е с размер 1х1 см.
//Да се отпечата на конзолата един от следните редове:
//•	"{брой парчета} pieces are left." - ако стигнете до STOP и не са свършили парчетата торта
//•	"No more cake left! You need {брой недостигащи парчета} pieces more."
