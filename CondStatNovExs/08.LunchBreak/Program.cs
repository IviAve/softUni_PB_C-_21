using System;

namespace _08.LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfSerial = Console.ReadLine();
            int timeOfSeries = int.Parse(Console.ReadLine());
            int timeOfTimeout = int.Parse(Console.ReadLine());

            double eatingTime = timeOfTimeout / 8.0;
            double timeForBreak = timeOfTimeout / 4.0;

            double freeTime = timeOfTimeout - eatingTime - timeForBreak;
            double difference = freeTime - timeOfSeries;

            Console.WriteLine(freeTime >= timeOfSeries?$"You have enough time to watch {nameOfSerial} and left with {Math.Ceiling(difference)} minutes free time.":
                $"You don't have enough time to watch {nameOfSerial}, you need {Math.Ceiling(timeOfSeries -freeTime)} more minutes.");
            
        }
    }
}

//По време на обедната почивка искате да изгледате епизод от своя любим сериал. Вашата задача е да напишете програма,
//с която ще разберете дали имате достатъчно време да изгледате епизода. По време на почивката отделяте време за обяд и време за отдих.
//Времето за обяд ще бъде 1/8 от времето за почивка, а времето за отдих ще бъде 1/4 от времето за почивка. 
//Изход
//На конзолата да се изпише един ред:
//•	Ако времето е достатъчно да изгледате епизода: 
//"You have enough time to watch {име на сериал} and left with {останало време} minutes free time."
//•	Ако времето не Ви е достатъчно:
//"You don't have enough time to watch {име на сериал}, you need {нужно време} more minutes."
//Времето да се закръгли до най-близкото цяло число нагоре.
