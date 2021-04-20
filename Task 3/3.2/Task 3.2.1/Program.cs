using System;
using System.Collections.Generic;

namespace Task_3._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Методы Add и AddRange:");
            DynamicArray<int> myArray = new DynamicArray<int>();
            for (int i = 0; i < 6; i++)
            {
                myArray.Add(4);
            }

            List<int> list = new List<int>() { 1, 2, 3 };
            myArray.AddRange(list);                       
            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Конструктор с другой коллекцией:");
            DynamicArray<int> myArray2 = new(myArray);
            foreach (var item in myArray2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Результат удаления элемента:");
            Console.WriteLine(myArray2.Remove(4));
            Console.WriteLine(myArray2.Remove(4));
            foreach (var item in myArray2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Результат вставки элемента в произвольную позицию:");

            Console.WriteLine(myArray.Insert(101, 9)); 
            foreach (var item in myArray)
            {                
                Console.WriteLine(item);
            }
        }
    }
}
