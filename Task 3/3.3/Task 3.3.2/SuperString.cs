using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task_3._3._2
{
    public static class SuperString
    {
        public static void CheckLanguage(this string input)
        {    
            Regex regexRussian = new Regex(@"^[А-Яё]+$", RegexOptions.IgnoreCase);
            MatchCollection matchesRussian = regexRussian.Matches(input);

            Regex regexEnglish = new Regex(@"^[a-z]+$", RegexOptions.IgnoreCase);
            MatchCollection matchesEnglish = regexEnglish.Matches(input);

            Regex regexNumbers = new Regex(@"^[0-9]+$", RegexOptions.IgnoreCase);
            MatchCollection matchesNumbers = regexNumbers.Matches(input);

            if (matchesRussian.Count > 0)
            {
                Console.WriteLine("Введено русское слово");
            }
            else if (matchesEnglish.Count > 0)
            {
                Console.WriteLine("Введено английское слово");
            }
            else if (matchesNumbers.Count > 0)
            {
                Console.WriteLine("Введено число");
            }
            else if (input == "")
            {
                Console.WriteLine("Введена пустая строка");
            }
            else
            {
                Console.WriteLine("Введена совокупность нескольких слов, микс символов или букв");
            }
        }
    }
}
