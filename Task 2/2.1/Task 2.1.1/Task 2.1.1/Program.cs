using System;
using MyStringClass;

namespace Task_2._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку 1: ");
            MyString newString1 = new MyString(Console.ReadLine());            

            Console.WriteLine("Введите строку 2: ");
            MyString newString2 = new MyString(Console.ReadLine());

            Console.WriteLine("Результат проверки на идентичность строк: ");
            Console.WriteLine(MyString.Equals(newString1, newString2));

            Console.WriteLine("Введите символ для поиска в строке 1: ");
            char k = (char)Console.Read();

            Console.WriteLine("Индекс первого вхождения введенного символа в строке 1 = " + newString1.IndexOf(k));

            Console.WriteLine("Конкатенация строк 1 и 2: ");
            Console.WriteLine((MyString.Concat(newString1, newString2)).ToString());

            Console.WriteLine("Число слов в строке 1 = " + newString1.GetWordsQuantity());
            Console.WriteLine("Число слов в строке 2 = " + newString2.GetWordsQuantity());

            Console.ReadKey();
        }
    }
}
