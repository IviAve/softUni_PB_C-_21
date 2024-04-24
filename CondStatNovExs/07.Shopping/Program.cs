using System;

namespace _07.Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            const double vCardPrice = 250;
            double budget = double.Parse(Console.ReadLine());
            int vCardPc = int.Parse(Console.ReadLine());
            int processorsPc = int.Parse(Console.ReadLine());
            int ramPc = int.Parse(Console.ReadLine());

            double sumVCards = vCardPc * vCardPrice;

            double processorsPrice = sumVCards * 0.35;
            double ramPrice = sumVCards * 0.10;
            double totalSum = sumVCards + (processorsPc * processorsPrice) + (ramPc * ramPrice);

            if (vCardPc > processorsPc)
            {
                totalSum -= totalSum * 0.15;
            }

            double difference = budget - totalSum;

            Console.WriteLine(  budget >= totalSum ? $"You have {difference:f2} leva left!": $"Not enough money! You need {totalSum - budget:f2} leva more!");
        }
    }
}

//Петър иска да купи N видеокарти, M процесора и P на брой рам памет.
//Ако броя на видеокартите е по-голям от този на процесорите получава 15% отстъпка от крайната сметка.
//Важат следните цени:
//•	Видеокарта – 250 лв./ бр.
//•	Процесор – 35 % от цената на закупените видеокарти/бр.
//•	Рам памет – 10% от цената на закупените видеокарти/бр.
//Да се изчисли нужната сума за закупуване на материалите и да се пресметне дали бюджета ще му стигне.
//Изход
//На конзолата се отпечатва 1 ред, който трябва да изглежда по следния начин:
//•	Ако бюджета е достатъчен:
//"You have {остатъчен бюджет} leva left!"
//•	Ако сумата надхвърля бюджета:
//"Not enough money! You need {нужна сума} leva more!"
//Резултатът да се форматира до втория знак след десетичната запетая.
