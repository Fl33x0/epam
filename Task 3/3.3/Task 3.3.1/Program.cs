using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Task_3._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 5, 5, 6, 6, 100, 54 };

            Console.WriteLine("Сумма всех элементов: " + a.SumItem());
            Console.WriteLine("Среднее: " + a.AverageValue());
            Console.WriteLine("Самый повторяющийся элемент: " + a.MostFrequently());
        }
    }
}
