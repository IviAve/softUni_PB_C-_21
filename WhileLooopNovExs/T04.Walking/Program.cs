using System;

namespace T04.Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            const int GOAL_PER_DAY = 10000;
            
            int totalSteps = 0;
            

            while (totalSteps < GOAL_PER_DAY)
            {
                string input = Console.ReadLine();

                if (input == "Going home")
                {
                    int stepsLeft = int.Parse(Console.ReadLine());
                    totalSteps += stepsLeft;
                    
                    break;
                }
                int currentSteps = int.Parse(input);
                totalSteps += currentSteps;
            }
            if (totalSteps >= GOAL_PER_DAY)
            {
                Console.WriteLine($"Goal reached! Good job!");
                Console.WriteLine($"{totalSteps-GOAL_PER_DAY} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{GOAL_PER_DAY - totalSteps} more steps to reach goal.");
            }
        }
    }
}

//Габи иска да започне здравословен начин на живот и си е поставила за цел да върви 10 000 стъпки всеки ден.
//Някои дни обаче е много уморена от работа и ще иска да се прибере преди да постигне целта си.
//Напишете програма, която чете от конзолата по колко стъпки изминава тя всеки път като излиза през деня
//и когато постигне целта си да се изписва "Goal reached! Good job!"
//и колко стъпки повече е извървяла "{разликата между стъпките} steps over the goal!"
//Ако иска да се прибере преди това,
//тя ще въведе командата "Going home" и ще въведе стъпките, които е извървяла докато се прибира.
//След което, ако не е успяла да постигне целта си, на конзолата трябва да се изпише: "{разликата между стъпките} more steps to reach goal."
