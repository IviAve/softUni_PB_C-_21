using System;

namespace T06.CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int student = 0;
            int standard = 0;
            int kid = 0;
            int sum = 0;
            
            while (name != "Finish")
            {
                int ticket = int.Parse(Console.ReadLine());
                for (int i = 0; i < ticket; i++)
                {
                    string type = Console.ReadLine();

                    if (ticket == i - 1 || type == "End" || type == "Finish")
                    {
                        break;
                    }
                    else
                    {
                        if (type == "student")
                        {
                            student++;
                        }
                        else if (type == "standard")
                        {
                            standard++;
                        }
                        else if (type == "kid")
                        {
                            kid++;
                        }
                    }
                    sum++;
                }
                Console.WriteLine($"{name} - {100.0 * sum / ticket:f2}% full.");
                sum = 0;
                name = Console.ReadLine();
            }
            int totalTicket = student + standard + kid;
            Console.WriteLine($"Total tickets: {totalTicket}");
            Console.WriteLine($"{100.0 * student / totalTicket:f2}% student tickets.");
            Console.WriteLine($"{100.0 * standard / totalTicket:f2}% standard tickets.");
            Console.WriteLine($"{100.0 * kid / totalTicket:f2}% kids tickets.");
        }
    }
}

//Вашата задача е да напишете програма, която да изчислява процента на билетите за всеки тип от продадените билети:
//студентски(student), стандартен(standard) и детски(kid), за всички прожекции.
//Трябва да изчислите и колко процента от залата е запълнена за всяка една прожекция.
//Вход
//Входът е поредица от цели числа и текст:
//•	На първия ред до получаване на командата "Finish" - име на филма – текст
//•	На втори ред – свободните места в салона за всяка прожекция – цяло число [1 … 100]
//•	За всеки филм, се чете по един ред до изчерпване на свободните места в залата или до получаване на командата "End":
//o Типа на закупения билет - текст ("student", "standard", "kid")
//Изход
//На конзолата трябва да се печатат следните редове:
//•	След всеки филм да се отпечата, колко процента от кино залата е пълна
//"{името на филма} - {процент запълненост на залата}% full."
//•	При получаване на командата "Finish" да се отпечатат четири реда:
//o "Total tickets: {общият брой закупени билети за всички филми}"
//o "{процент на студентските билети}% student tickets."
//o "{процент на стандартните билети}% standard tickets."
//o "{процент на детските билети}% kids tickets
