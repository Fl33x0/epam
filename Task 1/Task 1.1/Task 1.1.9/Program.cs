using System;

namespace Task_1._1._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] NPMassive = new int[10];
            for (int i = 0; i < NPMassive.Length; i++)
            {
                NPMassive[i] = GetRandom();
            }

            int NNSumm = 0;
            for (int i = 0; i < NPMassive.Length; i++)
            {
                if (NPMassive[i] > 0)
                {
                    NNSumm += NPMassive[i];
                }

            }
            

            Console.WriteLine("Массив: ");
            ArrayCW(NPMassive);
            Console.WriteLine("Сумма неотрицательных элементов массива: ");
            Console.WriteLine(NNSumm);
        }
        static int GetRandom()
        {
            Random RandomNumbers = new Random();
            int Rnd = RandomNumbers.Next(-5, 5);
            return Rnd;
        }

        static void ArrayCW(int[] Nmbrs)
        {
            for (int i = 0; i < Nmbrs.Length; i++)
            {
                if (i == Nmbrs.Length - 1)
                {
                    Console.Write(Nmbrs[i]);
                    continue;
                }
                Console.Write(Nmbrs[i] + ", ");

            }
            Console.WriteLine("");
        }
    }
}
