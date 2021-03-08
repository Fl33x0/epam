using System;
using System.Text;
using System.Collections.Generic;

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

            for (int i = 0; i < sentences.Length; i++)
            {
                sentences[i] = sentences[i].Trim();
            }

            string[] outSentences = new string[sentences.Length];

            for (int i = 0; i < sentences.Length; i++)
            {
                StringBuilder str = new StringBuilder();
                str.Append(sentences[i]);
                str.Insert(0, Char.ToUpper(sentences[i][0]));
                str.Remove(1, 1);
                
                outSentences[i] = str.ToString();
                //str.Replace(sentences[i][0], Char.ToUpper(sentences[i][0]));
            }           

            char[] inputChars = input.ToCharArray();
          
            List<char> separatorsInInput = new List<char>();
            
            for (int i = 0; i < inputChars.Length; i++)
            {
                if ((inputChars[i] == '?' | inputChars[i] == '.' | inputChars[i] == '!') == true)
                {
                    separatorsInInput.Add(inputChars[i]);                        
                }

            }

            if (separatorsInInput.Count < outSentences.Length)
            {
                Console.WriteLine("Введено предложение без знака препинания в конце. Перезапустите программу и введите со знаком");
                Environment.Exit(0);
            }                    
           
            for (int i = 0; i < outSentences.Length; i++)
            {
                Console.Write(outSentences[i] + separatorsInInput[i] + " ");
            }
        }
    }
}

