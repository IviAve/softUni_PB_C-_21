using System;

namespace ClockTestAlarmBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;

            for (int hour = 0; hour <= 23; hour++)
            {
                for (int min = 0; min <= 59; min++)
                {
                    Console.WriteLine($"{hour}:{min}");
                    if (hour == 0 && min == 15)
                    {
                        flag = true;
                        break;
                       // (return;) ili ( Environment.Exit(0);) bez buleva
                    }

                }
                if (true)
                {
                    break;
                }
            }

}


    }
}
