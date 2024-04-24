using System;

namespace T06.BarcodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int fourthDigitNum1 = num1 % 10;
            int fourthDigitNum2 = num2 % 10;
            num1 /= 10;
            num2 /= 10;

            int thirdDigitNum1 = num1 % 10;
            int thirdDigitNum2 = num2 % 10;
            num1 /= 10;
            num2 /= 10;

            int secondDigitNum1 = num1 % 10;
            int secondDigitNum2 = num2 % 10;
            num1 /= 10;
            num2 /= 10;

            //int firstDigitNum1 = num1 % 10;
            //int firstDigitNum2 = num2 % 10;
            //num1 /= 10;
            //num2 /= 10;
            for (int a = num1; a <=num2 ; a++)
            {
                for (int b = secondDigitNum1; b <=secondDigitNum2; b++)
                {
                    for (int c = thirdDigitNum1; c <= thirdDigitNum2; c++)
                    {
                        for (int d = fourthDigitNum1; d <=fourthDigitNum2 ; d++)
                        {
                            if (a % 2 != 0 && b % 2 != 0&& c % 2 != 0 && d % 2 != 0 )
                            {
                                Console.Write($"{a}{b}{c}{d} ");
                            }
                        }
                    }
                }
            }

        }
    }
}

//Техниката в магазин за коледни украси се разваля.
//Артикулите, които съдържат четни числа в своя баркод не могат да бъдат маркирани от касиерите.
//Вашата задача е, да напишете програма, която генерира всички баркодове, които НЕ съдържат четни цифри в себе си.
//Вход:
//•	Две четирицифрени числа, които показват обхвата на баркодовете, които трябва да промените.
//•	Първи ред – четирицифрено число – началото на обхвата. Цяло число в интервала [1000…9999]
//•	Втори ред – четирицифрено число – края на обхвата. Цяло число в интервала [1000…9999]
//Изход:
//На конзолата трябва да се отпечатат всички "баркодове", които НЕ съдържат четна цифра в себе си, разделени с интервал.
