using System;

namespace Task_1._1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N");
            int N = InputTool();
            int starsmax = 2 * N - 1;
            int M = (starsmax - 1) / 2;
            int j = 1;

            for (int i = 1; i <= N; i++)
            {                
                string spaces = new string(' ', M);
                string stars = new string('*', j);
                string s = spaces + stars + spaces;
                Console.WriteLine(s);
                M = M - 1;
                j = j + 2;
            }

            Console.ReadKey();
        }
        public static int InputTool()
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
