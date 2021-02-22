using System;

namespace Task_1._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = inp();
            string chars = null;

            for (int i = 1; i <= N; i++)
            {
                chars += "*";
                Console.WriteLine(chars);
            }

            Console.ReadKey();
        }
        public static int inp()
        {
            for (; ; )
            {
                int input;
                bool a = Int32.TryParse(Console.ReadLine(), out input);
                if (a == true)
                {
                    if (input <= 0) Console.WriteLine("Ошибка: введите положительное целое значение");
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
