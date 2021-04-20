using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task_3._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите строку для проверки: ");
                string input = Console.ReadLine();
                SuperString.CheckLanguage(input);
                Console.WriteLine();
            }
        }
    }
}
