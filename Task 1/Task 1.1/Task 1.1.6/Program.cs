using System;

namespace Task_1._1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputnum = inp ();
            title_parameters title = new title_parameters ();

            title.Bold = false;
            title.Italic = false;
            title.Underline = false;

            if (inputnum == 1) { title.Bold = !title.Bold; }
            if (inputnum == 2) { title.Italic = !title.Italic; }
            if (inputnum == 3) { title.Underline = !title.Underline; }
            
            Console.WriteLine(title.Bold, title.Italic, title.Underline);
        }

        public static int inp()
        {
            for (; ; )
            {
                int input;
                bool a = Int32.TryParse(Console.ReadLine(), out input);
                if (a == true)
                {
                    if ((input <= 0) | (input > 3)) Console.WriteLine("Ошибка: введите значение от 1 до 3");
                    else return input;
                }
                else
                {
                    continue;
                }
            }
        }

        public static string outp(bool title_parameter1, bool title_parameter2, bool title_parameter3)
        {
            Console.WriteLine("Параметры надписи:");
            if (title_parameter1 == true) { Console.WriteLine("Bold"); }
            if (title_parameter2 == true) { Console.WriteLine("Italic"); }
            if (title_parameter3 == true) { Console.WriteLine("Underline"); }

        }
    }
}
