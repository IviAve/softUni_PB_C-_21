using System;

namespace T08.OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вход
            //От конзолата се четат 4 цели числа (по едно на ред), въведени от потребителя:
            //•	Първият ред съдържа час на изпита – цяло число от 0 до 23.
            //•	Вторият ред съдържа минута на изпита – цяло число от 0 до 59.
            //•	Третият ред съдържа час на пристигане – цяло число от 0 до 23.
            //•	Четвъртият ред съдържа минута на пристигане – цяло число от 0 до 59.
            int hourForExam = int.Parse(Console.ReadLine());
            int minutesForExam = int.Parse(Console.ReadLine());
            int hourForArrival = int.Parse(Console.ReadLine());
            int minutesForArrival = int.Parse(Console.ReadLine());

            int difference = 0;
            int hour = 0;
            int minutes = 0;

            minutesForExam += hourForExam * 60;
            minutesForArrival += hourForArrival * 60;

            if (minutesForArrival > minutesForExam)
            {
                difference = minutesForArrival - minutesForExam;

                Console.WriteLine($"Late");

                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes after the start");
                }
                else
                {
                    hour = difference / 60;
                    minutes = difference % 60;
                    Console.WriteLine($"{hour}:{minutes:d2} hours after the start");
                }

            }
            else if (minutesForArrival < minutesForExam - 30)

            {
                difference = minutesForExam - minutesForArrival;
                Console.WriteLine($"Early");

                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else
                {
                    hour = difference / 60;
                    minutes = difference % 60;
                    Console.WriteLine($"{hour}:{minutes:d2} hours before the start");
                }
            }
            else
            {
                Console.WriteLine($"On time");
                difference = minutesForExam - minutesForArrival;
                Console.WriteLine($"{difference} minutes before the start");
            }

            
        }
    }
}

//Студент трябва да отиде на изпит в определен час (например в 9:30 часа). Той идва в изпитната зала в даден час на пристигане (например 9:40).
//Счита се, че студентът е дошъл навреме, ако е пристигнал в часа на изпита или до половин час преди това. Ако е пристигнал по-рано повече от 30 минути, той е подранил.
//Ако е дошъл след часа на изпита, той е закъснял. Напишете програма, която прочита време на изпит и време на пристигане и отпечатва дали студентът е дошъл навреме,
//дали е подранил или е закъснял и с колко часа или минути е подранил или закъснял.
//Изход
//На първият ред отпечатайте:
//•	“Late”, ако студентът пристига по-късно от часа на изпита.
//•	“On time”, ако студентът пристига точно в часа на изпита или до 30 минути по-рано.
//•	“Early”, ако студентът пристига повече от 30 минути преди часа на изпита.
//Ако студентът пристига с поне минута разлика от часа на изпита, отпечатайте на следващия ред:
//•	
//“mm minutes after the start” за закъснение под час.
//•	“hh:mm hours after the start” за закъснение от 1 час или повече. Минутите винаги печатайте с 2 цифри, например “1:03”.

