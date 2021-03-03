using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину");
            int length = InputTool();

            Console.WriteLine("Введите ширину");
            int width = InputTool();

            int s = length * width;

            Console.WriteLine("Площадь = " + s);
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
