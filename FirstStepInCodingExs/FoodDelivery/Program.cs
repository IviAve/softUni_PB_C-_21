using System;

namespace FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int chickenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int veganMenu = int.Parse(Console.ReadLine());

            double priceChicken = chickenMenu * 10.35;
            double priceFish = fishMenu * 12.40;
            double priceVegan = veganMenu * 8.15;

            double sumMenu = priceChicken + priceFish + priceVegan;
            double dessert = sumMenu * 0.20;
            double priceForDeliv = 2.5;
            double totalPrice = sumMenu + dessert + priceForDeliv;

            Console.WriteLine(totalPrice);

        }
    }
}


//Вход
//От конзолата се четат 3 реда:
//•	Брой пилешки менюта – цяло число в интервала [0 … 99]
//•	Брой менюта с риба – цяло число в интервала [0 … 99]
//•	Брой вегетариански менюта – цяло число в интервала [0 … 99]
//Изход
//Да се отпечата на конзолата един ред:  "{цена на поръчката}"
