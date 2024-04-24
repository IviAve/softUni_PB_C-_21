using System;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вход
            //От конзолата се четат 4 числа:
            //1.Първи ред – брой на хората. Цяло число в интервала [1…100]
            //2.Втори ред – такса вход.Реално число в интервала[0.00…50.00]
            //3. Трети ред – цена един за шезлонг. Реално число в интервала [0.00…50.00]
            //4. Четвърти ред – цена за един чадър. Реално число в интервала [0.00...50.00]
            int numOfPeople = int.Parse(Console.ReadLine());
            double taxEntry = double.Parse(Console.ReadLine());
            double priceForDeckChair = double.Parse(Console.ReadLine());
            double priceForUmbrrela = double.Parse(Console.ReadLine());

            double totalsum = 0;

            double totalsumEntry = numOfPeople * taxEntry;
            double totalsumUmbrrela = Math.Ceiling((double)numOfPeople / 2) * priceForUmbrrela;
            double totalSumdeckChairs =Math.Ceiling ((double)numOfPeople * 0.75) * priceForDeckChair;
            totalsum = totalSumdeckChairs + totalsumEntry + totalsumUmbrrela;

            Console.WriteLine($"{totalsum:f2} lv.");
        }
    }
}

//Преподавателският екип на СофтУни организира работен ден на басейн по случай настъпването на лятото.
//Вашата задача е да напишете програма, която да изчислява каква сума трябва да се заплати. За всеки един
//човек от екипа трябва да се заплати такса вход. Трябва да имате предвид, че един чадър стига за двама
//души. Знае се, че само 75% от екипа искат шезлонги. При изчислението на броя на чадърите и шезлонгите,
//техният брой да се закръгли до по-голямото цяло число.
//Изход
//"{сумата за покриване на разходите} lv."
//Резултатът да се форматира до втората цифра след десетичния зн