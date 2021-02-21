using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину");
            int length = inp();

            Console.WriteLine("Введите ширину");
            int width = inp();

            int s = length * width;

            Console.WriteLine("Площадь = " + s);
            Console.ReadKey();
        }

        private static int inp()
        {
            for (; ; )
            {
                int input;
                bool a = Int32.TryParse(Console.ReadLine(), out input);
                if (a == true)
                {
                    if (input <= 0) Console.WriteLine("Ошибка: введите положительное значение");
                    else return input;
                }
                else
                {
                    continue;
                }
            }
        }
    
    }
}
