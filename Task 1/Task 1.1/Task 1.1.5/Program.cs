using System;

namespace Task_1._1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int summ = 0;

            for (int i = 1; i < 10; i++)
            {
                int x = i % 3;
                int y = i % 5;

                if ((y == 0) | (x == 0))
                {
                    summ += i;
                } 
            }
            Console.WriteLine(summ);
        }
    }
}
