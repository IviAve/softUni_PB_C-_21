﻿using System;

namespace T02.MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a <= 10; a++)
            {
                for (int b =1 ; b <= 10; b++)
                {
                    int sum = a * b;

                    Console.WriteLine($"{a} * {b} = {sum}");
                }
            }
        }
    }
}
