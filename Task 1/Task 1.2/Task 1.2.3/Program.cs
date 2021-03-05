using System;

namespace Task_1._2._3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите строку: ");
            string input = Console.ReadLine();

            char[] inputChars = input.ToCharArray();
            char[] separators = new char[inputChars.Length];

            for (int i = 0; i < inputChars.Length; i++)
            {
                if (Char.IsSeparator(inputChars[i]) | Char.IsPunctuation(inputChars[i]) == true)
                {
                    separators[i] = inputChars[i];
                }
            }

            string[] words = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            int sum = 0;

            for (int i = 0; i < words.Length; i++)
            {
                if (Char.IsUpper(words[i][0]) == false)
                {
                    sum++;
                }

            }

            Console.WriteLine("Число слов, начинающихся с маленькой буквы: " + sum);
        }

    }
}