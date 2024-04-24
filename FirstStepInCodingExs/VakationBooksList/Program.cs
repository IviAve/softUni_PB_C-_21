using System;

namespace VakationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int pagesInBook = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int timeForRead = pagesInBook / pagesPerHour;
            double hourPerDay = timeForRead / days;

            Console.WriteLine(hourPerDay);

        }
    }
}


//Общо време за четене на книгата: 212 страници / 20 страници за час = 10 часа общо
//Необходимите часове на ден: 10 часа / 2 дни = 5 часа на ден



//1.Брой страници в текущата книга – цяло число в интервала [1…1000]
//2.Страници, които прочита за 1 час – цяло число в интервала [1…1000]
//3.Броят на дните, за които трябва да прочете книгата – цяло число в интервала [1…1000]
//Изход
//Да се отпечата на конзолата броят часове, които Жоро трябва да отделя за четене всеки ден.

