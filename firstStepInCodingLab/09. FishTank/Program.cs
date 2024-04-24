using System;

namespace _09._FishTank
{
    class Program
    {
        static void Main(string[] args)
        {

            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent= double.Parse(Console.ReadLine());

            double V = length * width * height;
            double vLitres = V * 0.001;

            double litresWater = vLitres - (vLitres * percent / 100);

            Console.WriteLine(litresWater);
        }
    }
}

//За рождения си ден Любомир получил аквариум с формата на паралелепипед.
//Първоначално прочитаме от конзолата на отделни редове размерите му –
//дължина, широчина и височина в сантиметри. Трябва да се пресметне колко литра вода ще събира аквариума,
//ако се знае, че определен процент от вместимостта му е заета от пясък, растения, нагревател и помпа. 
//Един литър вода се равнява на един кубичен дециметър/ 1л=1 дм3/. 
//Да се напише програма, която изчислява литрите вода, която са необходими за напълването на аквариума.
//Изход
//Да се отпечата на конзолата едно число:
//•	литрите вода, които ще  събира аквариума.
