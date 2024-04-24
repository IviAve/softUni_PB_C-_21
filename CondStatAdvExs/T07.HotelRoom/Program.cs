using System;

namespace T07.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            //Хотел предлага 2 вида стаи: студио и апартамент. Напишете програма, която изчислява цената за целия престой за студио и апартамент.
            //Цените зависят от месеца на престоя:
            //   Май и октомври	             Юни и септември	                Юли и август
            //Студио – 50 лв./нощувка	   Студио – 75.20 лв./нощувка	    Студио – 76 лв./нощувка
            //Апартамент – 65 лв./нощувка	Апартамент – 68.70 лв./нощувка	Апартамент – 77 лв./нощувка
            const double STUDIO_PRICE_FOR_MAY_AND_OCTOBER = 50;
            const double APARTMENT_PRICE_FOR_MAY_AND_OCTOBER = 65;
            const double STUDIO_PRICE_FOR_JUNE_AND_SEPTEMBER = 75.20;
            const double APARTMENT_PRICE_FOR_JUNE_AND_SEPTEMBER = 68.70;
            const double STUDIO_PRICE_FOR_JULY_AND_AUGUST = 76;
            const double APARTMENT_PRICE_FOR_JULY_AND_AUGUST = 77;
            //Вход
            //Входът се чете от конзолата и съдържа точно 2 реда, въведени от потребителя:
            //•	На първия ред е месецът – May, June, July, August, September или October
            //•	На втория ред е броят на нощувките – цяло число в интервала [0 ... 200]

            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double totalStudioPrice = 0.0;
            double totalApartmentPrice = 0.0;

            switch (month)
            {
                case "May":
                case "October":
                    totalStudioPrice = nights * STUDIO_PRICE_FOR_MAY_AND_OCTOBER;
                    totalApartmentPrice = nights * APARTMENT_PRICE_FOR_MAY_AND_OCTOBER;
                    if (nights >7 && nights <= 14)
                    {
                        totalStudioPrice -= totalStudioPrice * 0.05;
                    }
                   else if (nights > 14)
                    {
                        totalStudioPrice -= totalStudioPrice * 0.30;
                    }
                    break;
                case "June":
                case "September":
                    totalStudioPrice = nights * STUDIO_PRICE_FOR_JUNE_AND_SEPTEMBER;
                    totalApartmentPrice = nights * APARTMENT_PRICE_FOR_JUNE_AND_SEPTEMBER;
                    if (nights > 14)
                    {
                        totalStudioPrice -= totalStudioPrice * 0.20;
                    }
                    break;
                case "July":
                case "August":
                    totalStudioPrice = nights * STUDIO_PRICE_FOR_JULY_AND_AUGUST;
                    totalApartmentPrice = nights * APARTMENT_PRICE_FOR_JULY_AND_AUGUST;
                    break;

            }
            if (nights > 14)
            {
                totalApartmentPrice -= totalApartmentPrice * 0.10;
            }
            Console.WriteLine($"Apartment: {totalApartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {totalStudioPrice:f2} lv.");
        }
    }
}


//Предлагат се и следните отстъпки:
//•	За студио, при повече от 7 нощувки през май и октомври : 5 % намаление.
//•	За студио, при повече от 14 нощувки през май и октомври : 30 % намаление.
//•	За студио, при повече от 14 нощувки през юни и септември: 20 % намаление.
//•	За апартамент, при повече от 14 нощувки, без значение от месеца : 10 % намаление.
//Изход
//Да се отпечатат на конзолата 2 реда:
//•	На първия ред: “Apartment: { цена за целият престой}
//lv.”
//•	На втория ред: “Studio: { цена за целият престой}
//lv.“
//Цената за целия престой форматирана с точност до два знака след десетичната запетая.
