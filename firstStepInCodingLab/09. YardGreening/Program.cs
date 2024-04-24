using System;

namespace _09._YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вход
            //От конзолата се прочита само един ред:
            //1.Кв.метри, които ще бъдат озеленени – реално число в интервала [0.00 … 10000.00]
            double kvm = double.Parse(Console.ReadLine());

            double price = kvm * 7.61;
            double discount = price * 0.18;
            double totalSum = price - discount;

            //Изход
            //На конзолата се отпечатват два реда:
            //•	"The final price is: {крайна цена на услугата} lv."
            //•	"The discount is: {отстъпка} lv."
            Console.WriteLine($"The final price is: {totalSum} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");

        }


    }
}

