using System;
using System.Collections.Generic;
using System.IO;

namespace Task_4._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string mainFolder = @"E:\epam\Task 4\4.1\Task 4.1.1\Files";
            string backupStorageFolder = @"E:\epam\Task 4\4.1\Task 4.1.1\Storage";

            List<string> MenuItems = new List<string>() { "Режим наблюдения", "Режим отката изменений", "Выход" };

            Console.CursorVisible = false;

            while (true)
            {
                switch (Menu(MenuItems))
                {
                    case "Режим наблюдения":
                        {
                            BackupTool backupTool = new(mainFolder);
                            backupTool.Start();
                            break;
                        }
                    case "Режим отката изменений":
                        {
                            RollbackTool.RollBack(backupStorageFolder, mainFolder);
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
        public static string Menu(List<string> menuItems)
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
