﻿using System;

namespace _03.AnimalType
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string animal = Console.ReadLine();
            switch (animal)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    Console.WriteLine("reptile");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }

        }
    }
}

//Напишете програма, която отпечатва класа на животното според неговото име, въведено от потребителя.
//1.	dog -> mammal
//2.	crocodile, tortoise, snake -> reptile
//3.	others -> unknown
