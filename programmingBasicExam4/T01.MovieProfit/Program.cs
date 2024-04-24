using System;

namespace T01.MovieProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вход
            //От конзолата се четат 5 реда:
            //1.Име на филм - текст
            //2.	Брой дни - цяло число в диапазона [1… 90]
            //3.Брой билети - цяло число в диапазона [100… 100000]
            //4.Цена на билет - реално число в диапазона [5.0… 25.0]
            //5.Процент за киното - цяло число в диапазона [5... 35]
            string nameOfFilm = Console.ReadLine();
            int numDays = int.Parse(Console.ReadLine());
            int numTicketPerDay = int.Parse(Console.ReadLine());
            double priceForTicket = double.Parse(Console.ReadLine());
            int percentForCinema = int.Parse(Console.ReadLine());

            double totalTickets = numDays * numTicketPerDay;
            double sum = (totalTickets * priceForTicket);
                double percent = sum * percentForCinema / 100;
            double totalSum = sum - percent;

            Console.WriteLine($"The profit from the movie {nameOfFilm} is {totalSum:f2} lv.");
        }
    }
}

//Наети сте от "SoftUni Studios" да напишете програма, която пресмята потенциалната печалба от продажбата на билети за филм.
//Прожекцията на филма трае предварително зададен брой дни, като всеки ден се продават определен брой билети.
//Цената на 1 билет се определя от студиото. За излъчване на продукцията, определен процент от общия приход остава за киното.  
//Изход
//Да се отпечата на конзолата приходът от продажбите, в следния формат:
//•	"The profit from the movie {име на филм} is {приход на студиото} lv."
//Цената на прихода да бъде форматирана до втората цифра след десетичния знак
