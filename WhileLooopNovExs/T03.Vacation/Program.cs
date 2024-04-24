using System;

namespace T03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вход
            double neededMoney = double.Parse(Console.ReadLine());
            double curentMoney = double.Parse(Console.ReadLine());

            int days = 0;
            int spendCounter = 0;

            while (spendCounter !=5)
            {
                string input = Console.ReadLine();
                    double totalMoney = double.Parse(Console.ReadLine());
                days++;
                if (input == "save")
                {
                    curentMoney += totalMoney;
                    spendCounter = 0;

                }
                else if (input == "spend")
                {
                    spendCounter++;
                    if (totalMoney > curentMoney)
                    {
                        curentMoney = 0;
                    }
                    else
                    {
                        curentMoney -= totalMoney;     
                    }

                }
                if (curentMoney >= neededMoney)
                {
                    Console.WriteLine($"You saved the money for {days} days.");
                    break;
                }



            }


            if (spendCounter == 5)
            {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine($"{days}");

            }
            

        }
    }
}

//3.Почивка
//Джеси е решила да събира пари за екскурзия и иска от вас да ѝ помогнете да разбере дали ще успее да събере необходимата сума.
//Тя спестява или харчи част от парите си всеки ден. Ако иска да похарчи повече от наличните си пари, то тя ще похарчи колкото има и ще ѝ останат 0 лева.
//Изход
//Програмата трябва да приключи при следните случаи:
//•	Ако 5 последователни дни Джеси само харчи, на конзолата да се изпише:
//o "You can't save the money."
//o "{Общ брой изминали дни}"
//•	Ако Джеси събере парите за почивката на конзолата се изписва:
//o "You saved the money for {общ брой изминали дни} days."
