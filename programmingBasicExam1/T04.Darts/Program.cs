using System;

namespace T04.Darts
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int points = 301;
            int successfulShots = 0;
            int unsuccessfulShots = 0;

            string sector = Console.ReadLine();
            while (sector != "Retire")
            {
                int currentPoints = int.Parse(Console.ReadLine());

                int totalCurrentPoints = 0;

                if (sector == "Single")
                {
                    totalCurrentPoints = currentPoints;
                }
                else if (sector == "Double")
                {
                    totalCurrentPoints = currentPoints * 2;
                }
                else if (sector == "Triple")
                {
                    totalCurrentPoints = currentPoints * 3;
                }

                if (points >= totalCurrentPoints)
                {
                    points -= totalCurrentPoints;
                    successfulShots++;
                }
                else
                {
                    unsuccessfulShots++;
                }

                if (points == 0)
                {
                    Console.WriteLine($"{name} won the leg with {successfulShots} shots.");
                    break;
                }

                sector = Console.ReadLine();
            }

            if (points != 0)
            {
                Console.WriteLine($"{name} retired after {unsuccessfulShots} unsuccessful shots.");
            }
        }
    }
}

//Вашата задача е да напишете програма, която да изчислява, дали даден играч е успял да спечели лег. (Лег се нарича единична игра на дартс)
//Първоначално играчът започва с 301 точки. Играчът хвърля стрелата върху таблото, като за всяко улучено поле, той получава определен брой точки.
//Всяко поле има по три сектора: единичен(Single) сектор от който се взимат броят точки от полето.
//Двоен (Double), от него се взимат удвоените точки от полето
//и троен (Triple) сектор, точките от който са умножени по 3.
//Получените точки от всеки изстрел се изваждат от началните точки, до достигане на 0.
//Забележка: При изстрел, даващ повече точки от наличните,
//той се зачита за неуспешен и играчът трябва да хвърля отново, докато не уцели точки равни на оставащите или по-малки, такъв удар се счита за успешен.
//Пример: При налични точки 100, удар даващ повече от 100 точки, неуспешен
//При налични точки 100, удар даващ по-малко или равни на 100 точки, успешен
//Вход 
//Първоначално се чете един ред:
//•	Името на играча - текст
//След това до получаване на команда "Retire" се четат многократно по два реда:
//1.Поле – текст("Single", "Double" или "Triple")
//2.Точки – цяло число в интервала [0… 100]
//Изход
//Играта приключва при въвеждане на команда "Retire" или при изравняване на началните 301 точки към 0. На конзолата трябва да се напечата един ред:
//•	Ако играчът е спечелил лега:
//o "{името на играча} won the leg with {успешните изстрели} shots."
//•	Ако играчът се е отказал от играта:
//o "{името на играча} retired after {неуспешни изстрели} unsuccessful shots."
