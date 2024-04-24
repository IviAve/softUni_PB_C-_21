using System;

namespace T02_ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вход
            //•	На първи ред - брой незадоволителни оценки - цяло число в интервала [1…5]
            //•	След това многократно се четат по два реда:
            //o Име на задача - текст (низ)
            //o Оценка - цяло число в интервала [2…6]
            int feilGrade = int.Parse(Console.ReadLine());
            string job = Console.ReadLine();
            int feilGradeCounter = 0;
            int totalJobs = 0;
            int sumOfGrades = 0;
            string lastJob = "";
//            a.брояч за незадоволителни оценки -с първоначална стойност 0
//b.брояч за решените упражнения -с първоначална стойност 0
//c.сумата на всички оценки -с първоначална стойност 0
//d.коя е последната задача -с първоначална стойност празен текст
//e.дали се е провалил или не


            while (job != "Enough")
            {
                int curentGrade = int.Parse(Console.ReadLine());
                totalJobs++;
                sumOfGrades += curentGrade;
                if (curentGrade <= 4)
                {
                    feilGradeCounter++;
                    if (feilGradeCounter == feilGrade)
                    {
                        Console.WriteLine($"You need a break, {feilGradeCounter} poor grades.");
                        break;
                    }
                    

                }
                lastJob = job;

                job = Console.ReadLine();
                

            }
            double average = (double)sumOfGrades / totalJobs;
            if (job== "Enough")
            {
                Console.WriteLine($"Average score: {average:f2}");
                Console.WriteLine($"Number of problems: {totalJobs}");
                Console.WriteLine($"Last problem: {lastJob}");
                

            }


        }
    }
}

//Напишете програма, в която Марин решава задачи от изпити докато не получи съобщение "Enough" от лектора си.
//При всяка решена задача той получава оценка.
//Програмата трябва да приключи прочитането на данни при команда "Enough" или ако Марин получи определения брой незадоволителни оценки.
//Незадоволителна е всяка оценка, която е по-малка или равна на 4.
//Изход
//•	Ако Марин стигне до командата "Enough", отпечатайте на 3 реда: 
//o "Average score: {средна оценка}"
//o "Number of problems: {броя на всички задачи}"
//o "Last problem: {името на последната задача}"
//•	Ако получи определеният брой незадоволителни оценки:
//o "You need a break, {брой незадоволителни оценки} poor grades."
//Средната оценка да бъде форматирана до втория знак след десетичната запетая. 
