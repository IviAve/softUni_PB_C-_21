using System;

namespace _05.SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0.0;

            if (town == "Sofia")
            {
                //град / продукт  coffee water	beer	sweets	peanuts

                //Sofia	           0.50	 0.80	1.20	  1.45	   1.60

                if (product == "coffee")
                {
                    price = 0.50; 
                }
                else if (product == "water" )
                {
                    price = 0.80;
                }
                else if (product == "beer")
                {
                    price = 1.20;
                }
                else if (product == "sweets")
                {
                    price = 1.45;
                }
                else if (product == "peanuts")
                {
                    price = 1.60;
                }


            }
            //град / продукт  coffee water	beer	sweets	peanuts

            //Plovdiv	       0.40	 0.70	1.15	  1.30	   1.50

            else if (town == "Plovdiv")
            {
                if (product == "coffee")
                {
                    price = 0.40;
                }
                else if (product == "water")
                {
                    price = 0.70;
                }
                else if (product == "beer")
                {
                    price = 1.15;
                }
                else if (product == "sweets")
                {
                    price = 1.30;
                }
                else if (product == "peanuts")
                {
                    price = 1.50;
                }
            }
            //град / продукт  coffee water	beer	sweets	peanuts
            //Varna	           0.45	 0.70	1.10	  1.35	   1.55

            else if (town == "Varna")
            {
                if (product == "coffee")
                {
                    price = 0.45;
                }
                else if (product == "water")
                {
                    price = 0.70;
                }
                else if (product == "beer")
                {
                    price = 1.10;
                }
                else if (product == "sweets")
                {
                    price = 1.35;
                }
                else if (product == "peanuts")
                {
                    price = 1.55;
                }
            }

            double total = quantity * price;

            Console.WriteLine(total);
            


        }
    }
}

//Предприемчив българин отваря квартални магазинчета в няколко града и продава на различни цени според града:
//град / продукт  coffee water	beer	sweets	peanuts
//Sofia	           0.50	 0.80	1.20	  1.45	   1.60
//Plovdiv	       0.40	 0.70	1.15	  1.30	   1.50
//Varna	           0.45	 0.70	1.10	  1.35	   1.55
//Напишете програма, която чете продукт (низ), град(низ) и количество(десетично число), въведени от потребителя,
//и пресмята и отпечатва колко струва съответното количество от избрания продукт в посочения град. 
