using System;

namespace T05.MovieRatings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вход
            //От конзолата първо се чете един ред:
            //•	Брой филми, които си е набелязала Деси – цяло число в интервала [1…20]
            //За всеки филм се прочитат два отделни реда:
            //•	Име на филма – текст 
            //•	Рейтинг на филма - реално число в интервала [1.00…10.00]
            int numOfFilms = int.Parse(Console.ReadLine());
            string highRatedFilm = "";
            double maxRating = double.MinValue;
            string lowestRatedFilm = "";
            double minRating = double.MaxValue;

            double ratingSum = 0;

            for (int film = 0; film < numOfFilms; film++)

            {
                
                string nameOfFilm = (Console.ReadLine());
                double rating =double.Parse (Console.ReadLine());
                ratingSum += rating;

                if (rating > maxRating)
                {
                    highRatedFilm = nameOfFilm;
                    maxRating = rating;
                }
                else if (rating < minRating)
                {
                    lowestRatedFilm = nameOfFilm;
                    minRating = rating;
                }
            }
            double averageRating = ratingSum / numOfFilms;
            Console.WriteLine($"{highRatedFilm} is with highest rating: {maxRating:f1}");
            Console.WriteLine($"{lowestRatedFilm} is with lowest rating: {minRating:f1}");
            Console.WriteLine($"Average rating: {averageRating:f1}");

        }
    }
}

//Деси много обича да гледа филми, но често й е трудно да си избере подходящ за гледане.
//Набелязва си определен брой филми и иска да си избере кой филм да гледа спрямо рейтинга на филмите.
//Напишете програма, която показва кой филм е с най-висок рейтинг, кой е с най-нисък и колко е средният рейтинг от всички филми,
//които си е набелязала да гледа.
//Изход
//Отпечатват се три реда в следния формат:
//•	"{име на филма с най-висок рейтинг} is with highest rating: {рейтинг на филма}"
//•	"{име на филма с най-нисък рейтинг} is with lowest rating: {рейтинг на филма}"
//•	"Average rating: {средният рейтинг на всички филми}"
//Максималният, минималният и средният рейтинг да се форматира до първата цифра след десетичния знак.

