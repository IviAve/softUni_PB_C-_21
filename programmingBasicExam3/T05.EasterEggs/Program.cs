using System;

namespace T05.EasterEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numfEggs = int.Parse(Console.ReadLine());

            int redEggsCount = 0;
            int orangeEggsCount = 0;
            int blueEggsCount = 0;
            int greenEggsCount = 0;

            int maxEggsCount = int.MinValue;
            string color = "";

            for (int i = 0; i < numfEggs; i++)

            {
                string colorOfEgg = Console.ReadLine();
                switch (colorOfEgg)
                {
                    case "red":
                        redEggsCount++;
                        if (redEggsCount >maxEggsCount)
                        {
                            maxEggsCount = redEggsCount;
                            color = colorOfEgg;
                        }
                        break;
                    case "orange":
                        orangeEggsCount++;
                        if (orangeEggsCount > maxEggsCount)
                        {
                            maxEggsCount = orangeEggsCount;
                            color = colorOfEgg;
                        }
                        break;
                    case "blue":
                        blueEggsCount++;
                        if (blueEggsCount > maxEggsCount)
                        {
                            maxEggsCount = blueEggsCount;
                            color = colorOfEgg;
                        }
                        break;
                    case "green":
                        greenEggsCount++;
                        if (greenEggsCount > maxEggsCount)
                        {
                            maxEggsCount = greenEggsCount;
                            color = colorOfEgg;
                        }
                        break;
                }


            }
            Console.WriteLine($"Red eggs: {redEggsCount}");
            Console.WriteLine($"Orange eggs: {orangeEggsCount}");
            Console.WriteLine($"Blue eggs: {blueEggsCount}");
            Console.WriteLine($"Green eggs: {greenEggsCount}");
            Console.WriteLine($"Max eggs: {maxEggsCount} -> {color}");
        }
    }
}

//Предстои Великден и едно от най-вълнуващите неща е боядисването на яйца. Наличните цветове за боядисване са:
//•	червено(red)
//•	оранжев(orange)
//•	син(blue)
//•	зелен(green)
//Напишете програма, която изчислява какъв е броят на яйцата от всеки цвят и от кой цвят яйцата са най - много, като знаете общия им брой и цвета на всяко яйце.
//Вход
//От конзолата се чете 1 ред:
//•	 Броят на боядисаните яйца – цяло число в интервала [1 ... 100]
//За всяко яйце се чете:
//o Цветът на яйцето – текст с възможности: "red", "orange", "blue", "green"
//Изход
//Да се отпечатат на конзолата 5 реда:
//•	"Red eggs: {брой на червените яйца}"
//•	"Orange eggs: {брой на оранжевите яйца}"
//•	"Blue eggs: {брой на сините яйца}"
//•	"Green eggs: {брой на зелените яйца}"
//•	"Max eggs: {максимален брой на яйцата от цвят} -> {цвят}"
