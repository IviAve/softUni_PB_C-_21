using System;

namespace TaskAreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

          

            double area = 0;

            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                area = a * a;
            }
            else if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                area = a * b;
            }
            else if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                area = r * r * Math.PI;

            }
            else if (figure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double ha = double.Parse(Console.ReadLine());
                area = a * ha / 2;

            }
            Console.WriteLine($"{area:f3}");
        }
    }
}

//Да се напише програма, в която потребителят въвежда вида и размерите на геометрична фигура и пресмята лицето й.
//Фигурите са четири вида: квадрат(square), правоъгълник(rectangle), кръг(circle) и триъгълник(triangle).
//На първия ред на входа се чете вида на фигурата (текст със следните възможности: square, rectangle, circle или triangle). 
//•	Ако фигурата е квадрат (square): на следващия ред се чете едно дробно число - дължина на страната му
//•	Ако фигурата е правоъгълник (rectangle): на следващите два реда четат две дробни числа - дължините на страните му
//•	Ако фигурата е кръг (circle): на следващия ред чете едно дробно число - радиусът на кръга
//•	Ако фигурата е триъгълник (triangle): на следващите два реда четат две дробни числа - дължината на страната му и дължината на височината към нея
//Резултатът да се закръгли до 3 цифри след десетичната запетая. 
//Примерен вход и изход

