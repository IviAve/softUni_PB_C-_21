﻿using System;

namespace T05.Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            const int FACEBOOK = 150;
            const int INSTAGRAM = 100;
            const int REDDIT = 50;
            
            int openTabs = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            double penalty = 0;

            for (int i = 1; i <= openTabs; i++)
            {
                string site =Console.ReadLine();

                switch (site)
                {
                    case "Facebook":
                        penalty += FACEBOOK;
                        break;
                    case "Instagram":
                        penalty += INSTAGRAM;
                        break;
                    case "Reddit":
                        penalty += REDDIT;
                        break;
                       
                }
                if (penalty >= salary)
                {
                    break;

                    
                }
            }
            if (penalty>= salary)
            {
                Console.WriteLine($"You have lost your salary.");
            }
            else
            {
                
                Console.WriteLine(salary- penalty);
            }
        }
    }
}

//Шеф на компания забелязва че все повече служители прекарват  време в сайтове, които ги разсейват.  
//За да предотврати това, той въвежда изненадващи проверки на отворените табове на браузъра на служителите си. 
//Според отворения сайт в таба се налагат следните глоби:
//•	"Facebook"-> 150 лв.
//•	"Instagram"-> 100 лв.
//•	"Reddit"-> 50 лв.
//От конзолата се четат два реда:
//•	Брой отворени табове в браузъра n - цяло число в интервала [1...10]
//•	Заплата - число в интервала[500...1500]
//След това n – на брой пъти се чете име на уебсайт – текст
//Изход
//•	Ако по време на проверката заплатата стане по-малка или равна на 0 лева, на конзолата се изписва 
//"You have lost your salary." и програмата приключва. 
//•	В противен случай след проверката на конзолата се изписва остатъкът от заплатата (да се изпише като цяло число).
