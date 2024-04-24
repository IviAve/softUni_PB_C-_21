using System;

namespace _08.CircleAreaAndPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double S = Math.PI * r * r;
            double P = 2 * Math.PI * r;

            Console.WriteLine($"{S:f2}");                        
            Console.WriteLine($"{P:f2}");                        
        }
    }
}

//Напишете програма, която чете от конзолата число r и пресмята и отпечатва лицето и периметъра на кръг / окръжност с радиус r,
//като форматирате изхода в следния вид: "<calculated area>"
//"<calculated parameter>".Форматирайте изходните данни до втория знак след десетичната запетая.
//P = 2*pi*r  i S = pi*r*r
