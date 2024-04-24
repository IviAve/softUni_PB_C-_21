using System;

namespace T08.TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вход
            //От конзолата първо се четат два реда:
            //•	Брой турнири, в които е участвал – цяло число в интервала [1…20] 
            //•	Начален брой точки в ранглистата - цяло число в интервала [1...4000]
            int Ntournaments = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());
            int points = 0;
            points = startPoints;
            int totalWinTour = 0;
            
           
            for (int i = 1; i <= Ntournaments; i++)
            {
                string posicion = Console.ReadLine();

                switch (posicion)
                {
                    case "W":
                        points += 2000;
                        totalWinTour++;
                        break;
                    case "F":
                       points += 1200;
                        break;
                    case "SF":
                        points += 720;
                        break;
                    
                }
            }
            double average = (points - startPoints) / Ntournaments;
            double percent =(double)totalWinTour /Ntournaments * 100;

            Console.WriteLine($"Final points: {points}");
            Console.WriteLine($"Average points: {Math.Floor(average)}");
            Console.WriteLine($"{percent:f2}%");
        }
    }
}

//Григор Димитров е тенисист, чиято следваща цел е изкачването в световната ранглиста по тенис за мъже. 
//През годината Гришо участва в определен брой турнири, като за всеки турнир получава точки, които зависят от позицията,
//на която е завършил в турнира. Има три варианта за завършване на турнир:
//	W - ако е победител получава 2000 точки
//	F - ако е финалист получава 1200 точки
//	SF - ако е полуфиналист получава 720 точки
//Напишете програма, която изчислява колко ще са точките на Григор след изиграване на всички турнири,
//като знаете с колко точки стартира сезона. Също изчислете колко точки средно печели от всички изиграни турнири
//и колко процента от турнирите е спечелил. 
//За всеки турнир се прочита отделен ред:
//•	Достигнат етап от турнира – текст – "W", "F" или "SF"
//Изход
//Отпечатват се три реда в следния формат:
//•	"Final points: {брой точки след изиграните турнири}"
//•	"Average points: {средно колко точки печели за турнир}"
//•	"{процент спечелени турнири}%"
//Средните точки да бъдат закръглени към най-близкото цяло число надолу, а процентът да се форматира до втората цифра след десетичния знак.
