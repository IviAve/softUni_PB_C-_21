﻿using System;

namespace T07.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int freeSpace = width * length * height;

            int sumOfMeters = 0;
            string input = (Console.ReadLine());

            while (input != "Done")
            {

                int currentMeters = int.Parse(input);
                sumOfMeters += currentMeters;

                
                if (freeSpace < sumOfMeters)
                {
                    int difference = sumOfMeters - freeSpace;
                    Console.WriteLine($"No more free space! You need {difference} Cubic meters more.");
                    break;
                }
                input = Console.ReadLine();
            }
            if (input == "Done")
            {
                int freeMeters = freeSpace - sumOfMeters;
                Console.WriteLine($"{freeMeters} Cubic meters left.");
            }


        }
    }
}

//На осемнадесетия си рожден ден на Хосе взел решение, че ще се изнесе да живее на квартира.
//Опаковал багажа си в кашони и намерил подходяща обява за апартамент под наем.
//Той започва да пренася своя багаж на части, защото не може да пренесе целия наведнъж.
//Има ограничено свободно пространство в новото си жилище, където може да разположи вещите, така че мястото да бъде подходящо за живеене.
//Напишете програма, която изчислява свободния обем от жилището на Хосе, който остава след като пренесе багажа си. 
//Бележка: Един кашон е с точни размери:  1m.x 1m.x 1m.
//Вход
//Потребителят въвежда следните данни на отделни редове:
//1.Широчина на свободното пространство - цяло число в интервала [1...1000]
//2.Дължина на свободното пространство - цяло число в интервала [1...1000]
//3.Височина на свободното пространство - цяло число в интервала [1...1000]
//4.На следващите редове(до получаване на команда "Done") -брой кашони, които се пренасят в квартирата - цяло число в интервала [1...10000]
//Програмата трябва да приключи прочитането на данни при команда "Done" или ако свободното място свърши.
//Изход
//Да се отпечата на конзолата един от следните редове:
//•	Ако стигнете до командата "Done" и има още свободно място:
//"{брой свободни куб. метри} Cubic meters left."
//•	Ако свободното място свърши преди да е дошла команда "Done":
//"No more free space! You need {брой недостигащи куб. метри} Cubic meters more."
