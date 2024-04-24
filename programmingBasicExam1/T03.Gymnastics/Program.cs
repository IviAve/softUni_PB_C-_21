using System;

namespace T03.Gymnastics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вход
            //Входът се чете от конзолата и се състои от два реда:
            //•	Първи ред – държава – текст ("Russia", "Bulgaria" или "Italy")
            //•	Втори ред – уред - текст ("ribbon", "hoop" или "rope")
            string country = (Console.ReadLine());
            string device = (Console.ReadLine());

            double totalRating = 0;

            if (country == "Russia")
            {
                switch (device)
                {
                    case "ribbon":
                        totalRating = 9.100 + 9.400;
                        break;
                    case "hoop":
                        totalRating = 9.300 + 9.800;
                        break;
                    case "rope":
                        totalRating = 9.600 + 9.000;
                        break;
                    default:
                        break;
                }
            }
            if (country == "Bulgaria")
            {
                switch (device)
                {
                    case "ribbon":
                        totalRating = 9.600 + 9.400;
                        break;
                    case "hoop":
                        totalRating = 9.550 + 9.750;
                        break;
                    case "rope":
                        totalRating = 9.500 + 9.400;
                        break;
                    default:
                        break;
                }
            }
            if (country == "Italy")
            {
                switch (device)
                {
                    case "ribbon":
                        totalRating = 9.200 + 9.500;
                        break;
                    case "hoop":
                        totalRating = 9.450 + 9.350;
                        break;
                    case "rope":
                        totalRating = 9.700 + 9.150;
                        break;
                    default:
                        break;
                }
            }
            double percent = (20 - totalRating) / 20 * 100;
            Console.WriteLine($"The team of {country} get {totalRating:f3} on {device}.");
            Console.WriteLine($"{percent:f2}%");

        }
    }
}

//На световно първенство по художествена гимнастика три от държавите се изявяват като лидери в класирането (Русия, България, Италия).
//Вашата задача е да изчислите каква е оценката дадена от журито за конкретно съчетание, като знаете държавата,
//която е играла и с кой уред е играла - лента, обръч или въже.
//За съчетанието си, отбора е получил две оценки:
//оценка за трудност и оценка за изпълнение на съчетанието, като крайната оценка е сбор на двете оценки.
//В таблицата са показани какви оценки за трудност и изпълнение са получили ансамблите за всеки един уред.
//Напишете програма, която изчислява каква е оценката на дадена държава за определен уред и
//колко процента не им достигат, за да имат максималната оценка, която е 20.
//Изход
//На конзолата трябва да се отпечатат два реда:
//•	Първи ред: "The team of {държава} get {обща оценка} on {уред}."
//•	Втори ред:  "{процентът, който не им достига до максималния брой точки}%"
//Общата оценка да бъде форматирана до третата цифра след десетичния знак, а процентът да бъде форматиран до втората цифра след десетичния знак.
