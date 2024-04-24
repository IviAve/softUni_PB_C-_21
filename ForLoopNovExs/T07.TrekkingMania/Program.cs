using System;

namespace T07.TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вход
            //От конзолата се четат поредица от числа, всяко на отделен ред:
            //•	На първия ред – броя на групите от катерачи – цяло число в интервала [1...1000]
            //•	За всяка една група на отделен ред – броя на хората в групата – цяло число в интервала [1...1000]
            int numOfGroups = int.Parse(Console.ReadLine());
            
            int groupe1 = 0;
            int groupe2 = 0;
            int groupe3 = 0;
            int groupe4 = 0;
            int groupe5 = 0;

            for (int i = 1; i <= numOfGroups; i++)
            {
                int climbersCount = int.Parse(Console.ReadLine());

                if (climbersCount < 6)
                {
                    groupe1 += climbersCount;
                }
                else if (climbersCount < 13)
                {
                    groupe2 += climbersCount;
                }
                else if (climbersCount < 26)
                {
                    groupe3 += climbersCount;
                }
                else if (climbersCount < 41)
                {
                    groupe4 += climbersCount;
                }
                else
                {
                    groupe5 += climbersCount;
                }
            }

            int totalClimbers = groupe1 + groupe2 + groupe3 + groupe4 + groupe5;

            double percentP1 = (double)groupe1 / totalClimbers * 100;
            double percentP2 = (double)groupe2 / totalClimbers * 100;
            double percentP3 = (double)groupe3 / totalClimbers * 100;
            double percentP4 = (double)groupe4 / totalClimbers * 100;
            double percentP5 = (double)groupe5 / totalClimbers * 100;

            Console.WriteLine($"{percentP1:f2}%");
            Console.WriteLine($"{percentP2:f2}%");
            Console.WriteLine($"{percentP3:f2}%");
            Console.WriteLine($"{percentP4:f2}%");
            Console.WriteLine($"{percentP5:f2}%");

        }
    }
}

//Катерачи от цяла България се събират на групи и набелязват следващите върхове за изкачване.
//Според размера на групата, катерачите ще изкачват различни върхове.
//•	Група до 5 човека – изкачват Мусала
//•	Група от 6 до 12 човека – изкачват Монблан
//•	Група от 13 до 25 човека – изкачват Килиманджаро
//•	Група от 26 до 40 човека –  изкачват К2
//•	Група от 41 или повече човека – изкачват Еверест
//Да се напише програма, която изчислява процента на катерачите изкачващи всеки връх.
//Изход
//Да се отпечатат на конзолата 5 реда, всеки от които съдържа процент между 0.00% и 100.00% с точност до втората цифра след десетичната запетая.
//•	Първи ред - процентът изкачващи Мусала
//•	Втори ред – процентът изкачващи Монблан
//•	Трети ред – процентът изкачващи Килиманджаро
//•	Четвърти ред – процентът изкачващи К2
//•	Пети ред – процентът изкачващи Еверест
