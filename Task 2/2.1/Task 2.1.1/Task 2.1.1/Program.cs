using System;
using MyStringClass;

namespace Task_2._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyString newString = new MyString(Console.ReadLine());

            Console.WriteLine(newString.ToString());
        }
    }
}
