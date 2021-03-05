using System;
using System.Text;

namespace Task_1._2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string input = Console.ReadLine();

            //char[] inputChars = input.ToCharArray();
            char[] separators = { '?', '.', '!' };

            string[] sentences = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder str = new StringBuilder();

            for (int i = 0; i < sentences.Length; i++)
            {
                str.Append(sentences[i]);
                str.Replace(sentences[i][0], Char.ToUpper(sentences[i][0]));
            }

            Console.WriteLine(str);
        }
    }
}

