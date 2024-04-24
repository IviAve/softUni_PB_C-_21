using System;

namespace T06.Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            const double MIN_POINTS = 1250.5;

            //Вход
            //•	Име на актьора - текст
            //•	Точки от академията - реално число в интервала [2.0... 450.5]
            //•	Брой оценяващи n - цяло число в интервала[1… 20]
            string nameActor = Console.ReadLine();
            double pointsFromAcademy = double.Parse(Console.ReadLine());
            int nJury = int.Parse(Console.ReadLine());

            

            for (int i = 1; i <=nJury ; i++)
            {
                string nameJury = Console.ReadLine();
                double pointsFromJury = double.Parse(Console.ReadLine());

                pointsFromAcademy += (nameJury.Length * pointsFromJury) / 2;
                

                if (pointsFromAcademy > MIN_POINTS)
                {
                    break;
                }
            }
            if (pointsFromAcademy > MIN_POINTS)
            {
                Console.WriteLine($"Congratulations, {nameActor} got a nominee for leading role with {pointsFromAcademy:f1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {nameActor} you need {MIN_POINTS - pointsFromAcademy:f1} more!");
            }

      

        }
    }
}

//Поканени сте от академията да напишете софтуер, който да пресмята точките за актьор/актриса.
//Академията ще ви даде първоначални точки за актьора. След това всеки оценяващ ще дава своята оценка.
//Точките, които актьора получава се формират от: дължината на името на оценяващия умножено по точките, които дава делено на две. 
//Ако резултатът в някой момент надхвърли 1250.5 програмата трябва да прекъсне и да се отпечата, че дадения актьор е получил номинация.
//Изход
//Да се отпечата на конзолата един ред:
//•	Ако точките са над 1250.5:
//"Congratulations, {име на актьора} got a nominee for leading role with {точки}!"
//•	Ако точките не са достатъчни:
//	"Sorry, {име на актьора} you need {нужни точки} more!"
//Резултатът да се форматирана до първата цифра след десетичния знак!
