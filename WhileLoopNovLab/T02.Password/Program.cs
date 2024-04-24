using System;

namespace T02.Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != password)
            {
                input = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {username}!");
        }
    }
}

//Напишете програма, която първоначално прочита име и парола на потребителски профил. След това чете парола за вход.
//•	при въвеждане на грешна парола: потребителя да се подкани да въведе нова парола.
//•	при въвеждане на правилна парола: отпечатваме "Welcome {username}!".
