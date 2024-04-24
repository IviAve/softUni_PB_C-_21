using System;

namespace T04.TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string presentation = Console.ReadLine();

            int countStudent = 0;
            double grade = 0;

            while (presentation != "Finish")
            {
                double personalGrade = 0;
                countStudent++;
                for (int i = 1; i <= n ; i++)
                {
                    personalGrade +=double.Parse (Console.ReadLine());

                }
                personalGrade = personalGrade / n;
                grade += personalGrade;

                Console.WriteLine($"{presentation} - {personalGrade:F2}.");
                presentation = Console.ReadLine();
            }
            grade = grade / countStudent;
            Console.WriteLine($"Student's final assessment is {grade:F2}.");
        }
    }
}

//Курсът "Train the trainers" е към края си и финалното оценяване наближава.
//Вашата задача е да помогнете на журито което ще оценява презентациите,
//като напишете програма в която да изчислява средната оценка от представянето на всяка една презентация от даден студент,
//а накрая средният успех от всички тях.
//От конзолата на първият ред се прочита броят на хората в журито n - цяло число в интервала [1…20]

//След това на отделен ред се прочита името на презентацията - текст
//За всяка една презентация на нов ред се четат n - на брой оценки - реално число в интервала [2.00…6.00]
//След изчисляване на средната оценка за конкретна презентация, на конзолата се печата
// "{името на презентацията} - {средна оценка}."
//След получаване на команда "Finish" на конзолата се печата "Student's final assessment is {среден успех от всички презентации}." и програмата приключва.
//Всички оценки трябва да бъдат форматирани до втория знак след десетичната запетая.
