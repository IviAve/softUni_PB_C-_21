using System;

namespace _06.Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            const double priceForMussel = 7.50;

            double priceForMackerel = double.Parse(Console.ReadLine());
            double priceForSprat = double.Parse(Console.ReadLine());
            double kgPalamud = double.Parse(Console.ReadLine());
            double kgSafrid = double.Parse(Console.ReadLine());
            int kgMussel = int.Parse(Console.ReadLine());

            double priceForPalamud = priceForMackerel + (priceForMackerel * 0.60);
            double priceForSafrid = priceForSprat + (priceForSprat * 0.80);

            double sum = (kgPalamud * priceForPalamud) + (kgSafrid * priceForSafrid) + (kgMussel * priceForMussel);

                Console.WriteLine($"{sum:f2}");
            
        }
    }
}

//Георги ще има гости вечерта и решава да ги нагости с паламуд, сафрид и миди. Затова отива на рибната борса, за да си купи по няколко килограма.
//Oт конзолата се въвеждат цените в лева на скумрията и цацата. Също количеството на паламуд, сафрид и миди в килограми.
//Колко пари ще са му необходими, за да плати сметката си, ако цените на борсата са:
//•	Паламуд – 60 % по - скъп от скумрията
//•	Сафрид – 80% по-скъп от цацата
//•	Миди – 7.50 лв. за килограм
//Изход
//Да се отпечата на конзолата едно число с плаваща запетая: колко пари ще са нужни на Георги, за да си плати сметката. Числото трябва да е форматирано до вторият знак след десетичната запетая (1.2457 -> 1.25).
