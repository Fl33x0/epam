using System;
using System.Threading;

namespace Task_3._3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer oleg = new Customer("Oleg");
            oleg.MakeOrder("я хочу пиццу");

            Thread.Sleep(1000);

            Customer olga = new Customer("Olga");
            olga.MakeOrder("я хочу две пиццы");

            Console.ReadKey();
        }
    }
}
