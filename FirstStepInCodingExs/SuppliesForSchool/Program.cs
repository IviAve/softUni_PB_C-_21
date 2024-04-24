using System;

namespace SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            int packOfPens = int.Parse(Console.ReadLine());
            int packOfMarckers = int.Parse(Console.ReadLine());
            int litresOfBoardCleaner = int.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());

            double priceForPens = packOfPens * 5.80;
            double priceForMarckers = packOfMarckers * 7.20;
            double priceForCleaner = litresOfBoardCleaner * 1.20;
            double totalPrice = priceForPens + priceForMarckers + priceForCleaner;
            
            double sum = totalPrice - (totalPrice * percent / 100.0);

            Console.WriteLine(sum);

        }
    }
}


//Вход
//От конзолата се четат 4 числа:
//•	Брой пакети химикали - цяло число в интервала [0...100]
//•	Брой пакети маркери - цяло число в интервала [0...100]
//•	Литри препарат за почистване на дъска - цяло число в интервала [0…50]
//•	Процент намаление - цяло число в интервала [0...100]
//Изход
//Да се отпечата на конзолата колко пари ще са нужни на Ани, за да си плати сметката.

