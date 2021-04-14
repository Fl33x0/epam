using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task_3._1._2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<string> MenuItems = new List<string>() { "Вставить текст для анализа", "Выход" };
            
            Console.CursorVisible = false;

            while (true)
            {
                switch (Menu(MenuItems))
                {
                    case "Вставить текст для анализа":
                        {
                            Console.WriteLine("Вставьте текст для анализа");
                            string input = Console.ReadLine().ToLower();

                            char[] inputChars = input.ToCharArray();
                            char[] separators = new char[inputChars.Length];

                            for (int i = 0; i < inputChars.Length; i++)
                            {
                                if (Char.IsSeparator(inputChars[i]) || Char.IsPunctuation(inputChars[i]))
                                {
                                    separators[i] = inputChars[i];
                                }
                            }

                            string[] words = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);                                                                             

                            var result = words.GroupBy(x => x)
                              .Select(x => new { Word = x.Key, Frequency = x.Count() })
                              .OrderBy(x => x.Frequency);

                            foreach (var item in result)
                            {
                                Console.WriteLine("Слово: {0}\tКоличество повторов: {1}", item.Word, item.Frequency);
                            }

                            break;
                        }
                    case "Выход":
                        {
                            Environment.Exit(0);
                            break;
                        }
                }

            }                    

        }

        private static int currentSelection = 0;
        private static string Menu(List<string> menuItems)
        {
            string str = string.Empty;

            for (int i = 0; i < menuItems.Count; i++)
            {
                if (i == currentSelection)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                }

                Console.WriteLine(menuItems[i]);
                Console.ResetColor();
            }

            ConsoleKeyInfo currentKey = Console.ReadKey();

            switch (currentKey.Key)
            {                
                case ConsoleKey.Enter:
                    {
                        str = menuItems[currentSelection];
                        break;
                    }   
                case ConsoleKey.UpArrow:
                    {
                        if (currentSelection == 0)
                        {
                            currentSelection = menuItems.Count - 1;
                        }
                        else
                        {
                            currentSelection--;
                        }
                        break;
                    }
                case ConsoleKey.DownArrow:
                    {
                        if (currentSelection == menuItems.Count - 1)
                        {
                            currentSelection = 0;
                        }
                        else
                        {
                            currentSelection++;
                        }
                        break;
                    }                                   
            }

            Console.Clear();
            return str;
        }
    }
}
