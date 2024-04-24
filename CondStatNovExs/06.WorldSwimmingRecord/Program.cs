using System;

namespace _06.WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distanceInMetr = double.Parse(Console.ReadLine());
            double timeInSecForOneMetr = double.Parse(Console.ReadLine());

            double delay = Math.Floor(distanceInMetr / 15) * 12.5;
            

            double recordIvan = distanceInMetr * timeInSecForOneMetr + delay;

            if (recordIvan < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {recordIvan:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {(recordIvan - record):f2} seconds slower.");
            }
        }
    }
}

//Иван решава да подобри Световния рекорд по плуване на дълги разстояния.
//На конзолата се въвежда рекордът в секунди, който Иван трябва да подобри,
//разстоянието в метри, което трябва да преплува и времето в секунди, за което плува разстояние от 1 м.
//Да се напише програма, която изчислява дали се е справил със задачата, като се има предвид, че:
//съпротивлението на водата го забавя на всеки 15 м. с 12.5 секунди. Когато се изчислява колко пъти Иванчо ще се забави,
//в резултат на съпротивлението на водата, резултатът трябва да се закръгли надолу до най-близкото цяло число.
//Да се изчисли времето в секунди, за което Иванчо ще преплува разстоянието и разликата спрямо Световния рекорд. 
//Изход
//Отпечатването на конзолата зависи от резултата:
//•	Ако Иван е подобрил Световния рекорд (времето му е по-малко от рекорда) отпечатваме:
//o   " Yes, he succeeded! The new world record is {времето на Иван} seconds."
//•	Ако НЕ е подобрил рекорда (времето му е по-голямо или равно на рекорда) отпечатваме:
//o   "No, he failed! He was {недостигащите секунди} seconds slower."
//Резултатът трябва да се форматира до втория знак след десетичната запетая.
