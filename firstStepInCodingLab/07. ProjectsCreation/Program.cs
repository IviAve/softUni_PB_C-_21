using System;

namespace _07._ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            const int timeForProject= 3;
            string name = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());

            int totalHours = projects * timeForProject;

            Console.WriteLine($"The architect {name} will need {totalHours} hours to complete {projects} project/s.");
         }
    }
}

//Напишете програма, която изчислява колко часа ще са необходими на един архитект, за да изготви проектите на няколко строителни обекта.
//Изготвянето на един проект отнема три часа.
//Вход
//От конзолата се четат 2 реда:
//1.Името на архитекта - текст
//2.	Брой на проектите, които трябва да изготви - цяло число в интервала [0 … 100]
//Изход
//На конзолата се отпечатва:
//•	"The architect {името на архитекта} will need {необходими часове} hours to complete {брой на проектите} project/s."
