using System;

namespace Task_1._1._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] Numbers = new int[5, 5, 5];

            for (int i = 0; i < Numbers.GetLength(0); i++)
            {
                for (int j = 0; j < Numbers.GetLength(1); j++)
                {
                    for (int k = 0; k < Numbers.GetLength(2); k++)
                    {
                        Numbers[i, j, k] = GetRandom();
                    }
                }
               
            }
            
            Console.WriteLine("Массив: ");
            for (int i = 0; i < Numbers.GetLength(0); i++)
            {
                for (int j = 0; j < Numbers.GetLength(1); j++)
                {
                    for (int k = 0; k < Numbers.GetLength(2); k++)
                    {
                        Console.Write(Numbers[i, j, k] + " ");
                    }
                }

            }
            Console.WriteLine("");

            
            Console.WriteLine("Массив без положительных элементов: ");

            for (int i = 0; i < PositiveReplace(Numbers).GetLength(0); i++)
            {
                for (int j = 0; j < PositiveReplace(Numbers).GetLength(1); j++)
                {
                    for (int k = 0; k < PositiveReplace(Numbers).GetLength(2); k++)
                    {
                        Console.Write(PositiveReplace(Numbers)[i, j, k] + " ");
                    }
                }

            }

        }
        static int GetRandom()
        {
            Random RandomNumbers = new Random();
            int Rnd = RandomNumbers.Next(-5, 5);
            return Rnd;
        }

        static int[,,] PositiveReplace(int[,,] NPMassive)
        {
            for (int i = 0; i < NPMassive.GetLength(0); i++)
            {
                for (int j = 0; j < NPMassive.GetLength(1); j++)
                {
                    for (int k = 0; k < NPMassive.GetLength(2); k++)
                    {
                        if (NPMassive[i, j, k] > 0)
                        {
                            NPMassive[i, j, k] = 0;
                        }
                       
                    }
                }

            }
            return NPMassive;
        }
    }
}
