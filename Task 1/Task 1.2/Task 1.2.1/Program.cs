using System;
using System.Text;

namespace Task_1._2._1
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
            
            string[] words = input.Split(separators , StringSplitOptions.RemoveEmptyEntries);
            //Средняя длина округляться не будет
            
            float sum = 0;

            for (int i = 0; i < words.Length; i++)
            {
                sum += words[i].Length;
            }

            float average = sum / words.Length;

            
            Console.WriteLine("Средняя длина слова в строке: " + average);
        }
    }
}
