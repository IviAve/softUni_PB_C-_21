using System;

namespace _05.GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int pcStatists = int.Parse(Console.ReadLine());
            double clothingPriceForOne = double.Parse(Console.ReadLine());

            double decorPrice = budget * 0.10;
            double sumForClothing = pcStatists * clothingPriceForOne;

            if (pcStatists > 150)
            {
                sumForClothing -= sumForClothing * 0.10;
            }

            double totalPrice = decorPrice + sumForClothing;

            double defference = Math.Abs (budget - totalPrice);

            if (totalPrice > budget)
            {
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {defference:f2} leva more.");
            }
            else if (totalPrice <= budget)
            {
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {defference:f2} leva left.");
            }
        }
    }
}

//Снимките за дългоочаквания филм "Годзила срещу Конг" започват. Сценаристът Адам Уингард ви моли да напишете програма,
//която да изчисли, дали предвидените средства са достатъчни за снимането на филма. За снимките  ще бъдат нужни определен брой статисти,
//облекло за всеки един статист и декор.
//Известно е, че:
//•	Декорът за филма е на стойност 10% от бюджета. 
//•	При повече от 150 статиста, има отстъпка за облеклото на стойност 10%.
//Изход
//На конзолата трябва да се отпечатат два реда:
//•	Ако парите за декора и дрехите са повече от бюджета:
//o "Not enough money!"
//o "Wingard needs {парите недостигащи за филма} leva more."
//•	Ако парите за декора и дрехите са по малко или равни на бюджета:
//o "Action!"
//o "Wingard starts filming with {останалите пари} leva left."
//Резултатът трябва да е форматиран до втория знак след десетичната запетая.
