using System;

namespace _07.WorkingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            if ( day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday" || day == "Saturday")
            {
                if (hour >= 10 && hour <=18)
                {
                    Console.WriteLine("open");
                }
                else
                {
                    Console.WriteLine("closed");
                }
            }
            else
            {
                Console.WriteLine("closed");
            }        
        }
    }
}

//Да се напише програма, която чете час от денонощието(цяло число) и ден от седмицата(текст) -въведени от потребителя
//и проверява дали офисът на фирма е отворен, като работното време на офисът е от 10-18 часа,
//от понеделник до събота включително 
//1	Monday
//2	Tuesday
//3	Wednesday
//4	Thursday
//5	Friday
//6	Saturday
//7	Sunday

