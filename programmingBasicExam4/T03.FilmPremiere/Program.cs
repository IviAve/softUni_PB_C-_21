using System;

namespace T03.FilmPremiere
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вход
            //От конзолата се четат 3 реда:
            //1.Време за снимки – цяло число в диапазона [0… 1440]
            //2.Брой сцени  – цяло число в диапазона [5… 25]
            //3.Времетраене на сцена – цяло число в диапазона [20… 90]
            int timeForPhoto = int.Parse(Console.ReadLine());
            int numOfScenes = int.Parse(Console.ReadLine());
            int timeForOneScene = int.Parse(Console.ReadLine());

            double teren = timeForPhoto * 0.15;
            double totalTime = (timeForOneScene * numOfScenes) + teren;
            double diff =Math.Abs (timeForPhoto - totalTime);
            if (totalTime <= timeForPhoto)
            {
                Console.WriteLine($"You managed to finish the movie on time! You have {Math.Round(timeForPhoto-totalTime)} minutes left!");
            }
            else
            {
                Console.WriteLine($"Time is up! To complete the movie you need {diff} minutes.");
            }

            


        }
    }
}

//Вие сте режисьор на филма "Програмирането е забавно", като имате определено време за снимки.
//От вас се иска да напишете програма, с която ще разберете дали снимачният ден ще ви стигне да заснемете филма.
//Снимачният ден започва с подготовка на терен, което е 15 процента от времето за снимки!
//Филмът има определен брой сцени, които се заснемат за определено време.
//Изход
//На конзолата да се отпечата един ред:
//•	Ако времето за заснемане на филма ви стигне: 
//  "You managed to finish the movie on time! You have {останало време} minutes left!"
//•	Ако времето НЕ ВИ стигне:
//  "Time is up! To complete the movie you need {нужно време} minutes."
//Останалото време да се закръгли до най-близкото цяло число.
