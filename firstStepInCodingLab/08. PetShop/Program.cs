using System;

namespace _08._PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodForDogs = int.Parse(Console.ReadLine());
            int foodForCats = int.Parse(Console.ReadLine());

            double price1 = foodForDogs * 2.50;
            double price2 = foodForCats * 4.00;

            double totalSum = price1 + price2;

            Console.WriteLine($"{totalSum} lv.");
        }
    }
}

//Напишете програма, която пресмята нужните разходи за закупуването на храна за кучета и котки.  
//    Храната се пазарува от зоомагазин, като една опаковка храна за кучета е на цена 2.50 лв, а опаковка храна за котки струва 4 лв.
//Вход
//От конзолата се четат 2 реда:
//1.Броят на опаковките храна за кучета – цяло число в интервала [0… 100]
//2.Броят на опаковките храна за котки –  цяло число в интервала [0… 100]
//Изход
//На конзолата се отпечатва: 
//"{крайната сума} lv."


