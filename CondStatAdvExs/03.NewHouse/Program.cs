using System;

namespace _03.NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PRICE_ROSES = 5;
            const double PRICE_DAHLIAS = 3.80 ;
            const double PRICE_TULIPS = 2.80;
            const double PRICE_NARCISSUS = 3;
            const double PRICE_GLADIOLUS = 2.50;

            string flower = Console.ReadLine();
            int pcFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

           double totalSum = 0;

            switch (flower)
            {
                case "Roses":
                    if (pcFlowers > 80)
                    {
                        totalSum -= pcFlowers * PRICE_ROSES * 0.10;
                    }
                    totalSum += pcFlowers * PRICE_ROSES;
                    break;
                case "Dahlias":
                    if (pcFlowers > 90)
                    {
                        totalSum -= pcFlowers * PRICE_DAHLIAS * 0.15;
                    }
                    totalSum += pcFlowers * PRICE_DAHLIAS;
                    break;
                case "Tulips":
                    if (pcFlowers > 80)
                    {
                        totalSum -= pcFlowers * PRICE_TULIPS * 0.15;
                    }
                    totalSum += pcFlowers * PRICE_TULIPS;
                    break;
                case "Narcissus":
                    if (pcFlowers < 120)
                    {
                        totalSum += pcFlowers * PRICE_NARCISSUS * 0.15;
                    }
                    totalSum += pcFlowers * PRICE_NARCISSUS;
                    break;
                case "Gladiolus":
                    if (pcFlowers < 80)
                    {
                        totalSum += pcFlowers * PRICE_GLADIOLUS * 0.20;
                    }
                    totalSum += pcFlowers * PRICE_GLADIOLUS;
                    break;
                    
            }
           
            double difference = budget - totalSum;
            //if (budget >= totalSum)
            //{
            //    Console.WriteLine($"Hey, you have a great garden with {pcFlowers} {flower} and {difference:f2} leva left.");
            //}
            //else
            //{
            //    Console.WriteLine($"Not enough money, you need {(totalSum - budget):f2} leva more.");
            //}

            Console.WriteLine(budget >= totalSum ? $"Hey, you have a great garden with {pcFlowers} {flower} and {difference:f2} leva left." :
             $"Not enough money, you need {(totalSum - budget):f2} leva more."); 



        }
    }
}

//Марин и Нели си купуват къща не далеч от София. Нели толкова много обича цветята,
//че Ви убеждава да напишете програма която да изчисли колко  ще им струва,
//да си засадят определен брой цветя и дали наличния бюджет ще им е достатъчен. Различните цветя са с различни цени. 
//цвете             Роза	Далия	Лале	Нарцис	Гладиола
//Цена на брой в лева	5	3.80	2.80	  3	       2.50
//Съществуват следните отстъпки:
//•	Ако Нели купи повече от 80 Рози - 10% отстъпка от крайната цена
//•	Ако Нели купи повече от 90  Далии - 15% отстъпка от крайната цена
//•	Ако Нели купи повече от 80 Лалета - 15% отстъпка от крайната цена
//•	Ако Нели купи по-малко от 120 Нарциса - цената се оскъпява с 15%
//•	Ако Нели Купи по-малко от 80 Гладиоли - цената се оскъпява с 20%
//От конзолата се четат 3 реда:
//•	Вид цветя - текст с възможности - "Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"
//•	Брой цветя - цяло число в интервала [10…1000]
//•	Бюджет - цяло число в интервала [50…2500]
//Да се отпечата на конзолата на един ред:
//•	Ако бюджета им е достатъчен - "Hey, you have a great garden with {броя цвета} {вид цветя} and {останалата сума} leva left."
//•	Ако бюджета им е НЕ достатъчен - "Not enough money, you need {нужната сума} leva more."
//Сумата да бъде форматирана до втория знак след десетичната запетая.
