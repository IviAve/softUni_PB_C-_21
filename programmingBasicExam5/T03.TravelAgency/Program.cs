using System;

namespace T03.TravelAgency
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вход
            //От конзолата се четат 4 реда:
            //1.Име на града - текст с възможности ("Bansko",  "Borovets", "Varna" или "Burgas")
            //3.Притежание на VIP отстъпка - текст с възможности  "yes" или "no"
            //4.	Дни за престой - цяло число в интервала [1 … 10000]

            string townName = Console.ReadLine();
            string offerType = Console.ReadLine();
            string vipDiscount = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            
            double totalPrice = 0;
            if (days > 7)
            {
                days -= 1;
            }
            if (townName == "Bansko"|| townName == "Borovets")
            {
                switch (offerType)
                {
                    case "noEquipment":
                        totalPrice = days * 80;
                        if (vipDiscount == "yes")
                        {
                            totalPrice = totalPrice * 0.95;
                        }
                        break;
                    case "withEquipment":
                        totalPrice = days * 100;
                        if (vipDiscount == "yes")
                        {
                            totalPrice = totalPrice * 0.90;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }
            }
            else if (townName == "Varna"|| townName == "Burgas")
            {
                switch (offerType)
                {
                    case "noBreakfast":
                        totalPrice = days * 100;
                        if (vipDiscount == "yes")
                        {
                            totalPrice = totalPrice * 0.93;
                        }
                        break;
                    case "withBreakfast":
                        totalPrice = days * 130;
                        if (vipDiscount == "yes")
                        {
                            totalPrice = totalPrice * 0.88;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }

             if (days < 1)
            {
                Console.WriteLine("Days must be positive number!");
            }
            
            if (totalPrice !=0)
            {
                
                Console.WriteLine($"The price is {totalPrice:f2}lv! Have a nice time!");
            }



            //2.Вид на пакета - текст с възможности ("noEquipment",  "withEquipment", "noBreakfast" или "withBreakfast")

            //   Цена за ден      Банско/ Боровец          Варна / Бургас

            //          с екипировка    без екипировка  със закуска без закуска

            //              100лв.            80лв          130лв.      100лв.
            //VIP отстъпка    10 %             5 %           12 %         7 %


        }
    }
}

//Туристическа агенция има нужда от система за изчисляване на дължимата сума при резервация.
//В зависимост от различните дестинации и различните пакети, цената е различна.
//Ако клиентът е заявил престой повече от 7 дни, получава единия ден безплатно.
//Изход
//На конзолата се отпечатва 1 ред:
//•	Когато потребителят е въвел всички данни правилно, отпечатваме: 
//"The price is {цената, форматирана до втория знак}lv! Have a nice time!"
//•	Ако потребителят е въвел по-малко от 1 ден за престой, отпечатваме: 
//"Days must be positive number!"
//•	Когато при въвеждането на града или вида на пакета се въведат невалидни данни, отпечатваме: "Invalid input!"
