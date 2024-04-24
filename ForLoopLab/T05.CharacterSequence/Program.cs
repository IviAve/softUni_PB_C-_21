using System;

namespace T05.CharacterSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {

                Console.WriteLine(word[i]);
            }

            //string input = Console.ReadLine();

            //for (int i = 0; i < input.Length; i++)
            //{
            //    char word = input[i];
            //    Console.WriteLine(word);
            //}

        }


    }
}
//Напишете програма, която чете текст (стринг), въведен от потребителя и печата всеки символ от текста на отделен ред.