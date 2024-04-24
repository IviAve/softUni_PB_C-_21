using System;

namespace T08.Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int year = 1;
            double totalGrades = 0;
            int failCounter = 0;
            

            while (year <=12)
            {
                double yearGrade = double.Parse(Console.ReadLine());

               
                

                if (yearGrade < 4)
                {
                    failCounter++;
                    if (failCounter == 2)
                    {
                        
                        Console.WriteLine($"{name} has been excluded at {year} grade");
                        break;
                    }
                    continue;
                    

                }
                totalGrades += yearGrade;
                year++;
            }
            double averageGrade = totalGrades / 12;

            if (year>=12)
            {
                Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
            }
        
            
                
           
               
        }
    }
}

//Напишете програма, която изчислява средната оценка на ученик от цялото му обучение.
//На първия ред ще получите името на ученика, а на всеки следващ ред неговите годишни оценки.
//Ученикът преминава в следващия клас, ако годишната му оценка е по-голяма или равна на 4.00.
//Ако ученикът бъде скъсан повече от един път, то той бива изключен и програмата приключва,
//като се отпечатва името на ученика и в кой клас бива изключен.
// При успешно завършване на 12-ти клас да се отпечата : 
//"{име на ученика} graduated. Average grade: {средната оценка от цялото обучение}"
//В случай, че ученикът е изключен от училище, да се отпечата:
//"{име на ученика} has been excluded at {класа, в който е бил изключен} grade"
//Стойността трябва да бъде форматирана до втория знак след десетичната запетая.  
