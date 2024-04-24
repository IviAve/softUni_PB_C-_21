using System;

namespace _08.CinemaTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();

            int priceForTicket = 0;

            if (day == "Monday" || day == "Tuesday" || day == "Friday")
            {
                priceForTicket = 12;
            }
            else if (day == "Wednesday" || day == "Thursday")
            {
                priceForTicket = 14;
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                priceForTicket = 16;
            }
            Console.WriteLine(priceForTicket);
        } 
    }
}

//Да се напише програма която чете ден от седмицата (текст) – въведен от потребителя и принтира на конзолата цената на билет за кино според деня от седмицата:
//Monday Tuesday	Wednesday	Thursday	Friday	Saturday	Sunday
//12	  12	     14	         14	         12	      16	     16

