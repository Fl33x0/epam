using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._3._1
{
    public static class SuperArray
    {
        static double _sum;


        public static void EachElementFunc<T>(this T[] someArray, Func<T, T> function)
        {
            if (function is null)
            {
                throw new NullReferenceException("function is null");
            }

            for (int i = 0; i < someArray.Length; i++)
            {
                someArray[i] = function(someArray[i]);
            }
        }

        public static double SumItem(this double[] array) => array.Sum();

        public static int SumItem(this int[] array) => array.Sum();

        public static float SumItem(this float[] array) => array.Sum();

        public static byte SumItem(this byte[] array)
        {
            byte _sum = 0;
            foreach (var item in array)
            {
                _sum += item;
            }
            return _sum;
        }

        public static short SumItem(this short[] array)
        {
            short _sum = 0;
            foreach (var item in array)
            {
                _sum += item;
            }
            return _sum;
        }

        public static double AverageValue(this int[] array) => array.Average();

        public static double AverageValue(this double[] array) => array.Average();

        public static float AverageValue(this float[] array) => array.Average();

        public static byte AverageValue(this byte[] array)
        {
            return (byte)(array.SumItem() / array.Length);
        }

        public static short AverageValue(this short[] array)
        {
            return (short)(array.SumItem() / array.Length);
        }

        public static int MostFrequently(this int[] array)
        {
            return array.GroupBy(x => x).OrderByDescending(x => x.Count())
                .FirstOrDefault()
                .Key;
        }
        public static float MostFrequently(this float[] array)
        {
            return array.GroupBy(x => x).OrderByDescending(x => x.Count())
                .FirstOrDefault()
                .Key;
        }
        public static double MostFrequently(this double[] array)
        {
            return array.GroupBy(x => x).OrderByDescending(x => x.Count())
                .FirstOrDefault()
                .Key;
        }
        public static byte MostFrequently(this byte[] array)
        {
            return array.GroupBy(x => x).OrderByDescending(x => x.Count())
                .FirstOrDefault()
                .Key;
        }

    }
}