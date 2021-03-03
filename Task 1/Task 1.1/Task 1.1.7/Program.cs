using System;

namespace Task_1._1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[10];

            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = GetRandom();
            }

            Console.WriteLine("Массив: ");
            MassiveCW(Numbers);

            int[] SortNumbers = Sort(Numbers);
            Console.WriteLine("Отсортированный массив: ");
            MassiveCW(SortNumbers);

            Console.WriteLine("Максимальное значение: " + GetMax(Numbers));
            Console.WriteLine("Минимальное значение: " + GetMin(Numbers));

        }

        static int GetRandom()
        {
            Random RandomNumbers = new Random();
            int Rnd = RandomNumbers.Next(1, 10);
            return Rnd;
        }

        static int[] Sort(int[] Nmbrs)
        {
            for (int i = 0; i < Nmbrs.Length; i++)
            {

                for (int j = 0; j < Nmbrs.Length; j++)
                {
                    int m = Nmbrs[i];
                    if (Nmbrs[i] > Nmbrs[j])
                    {
                        Nmbrs[i] = Nmbrs[j];
                        Nmbrs[j] = m;
                    }
                }
            }
            return Nmbrs;
        }

        static void MassiveCW(int[] Nmbrs)
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

        static int GetMax(int[] M)
        {
            int Max = M[0];
            for (int i = 0; i < M.Length; i++)
            {
                if (M[i] > Max) Max = M[i];
            }
            return Max;
        }

        static int GetMin(int[] M)
        {
            int Min = M[0];
            for (int i = 0; i < M.Length; i++)
            {
                if (M[i] < Min) Min = M[i];
            }
            return Min;

        }
    }
}
