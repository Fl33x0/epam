using System;

namespace Task_1._1._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] ArrayOfInt = new int[5, 5];
            for (int i = 0; i < ArrayOfInt.GetLength(0); i++)
            {                
                for (int j = 0; j < ArrayOfInt.GetLength(1); j++)
                {
                    ArrayOfInt[i, j] = GetRandom();
                }
            }

            Console.WriteLine("Массив: ");

            for (int i = 0; i < ArrayOfInt.GetLength(0); i++)
            {
                for (int j = 0; j < ArrayOfInt.GetLength(1); j++)
                {                    
                    Console.Write("{0,3}", ArrayOfInt[i, j]);
                }
                Console.WriteLine();
            }

            
            int summ = 0;

            for (int i = 0; i < ArrayOfInt.GetLength(0); i++)
            {
                for (int j = 0; j < ArrayOfInt.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        summ += ArrayOfInt[i, j];
                    }
                    
                }
            }

            Console.WriteLine("Cумма элементов массива, стоящих на чётных позициях: " + summ);

        }

        static int GetRandom()
        {
            Random RandomNumbers = new Random();
            int Rnd = RandomNumbers.Next(-5, 5);
            return Rnd;
        }
    }
}
