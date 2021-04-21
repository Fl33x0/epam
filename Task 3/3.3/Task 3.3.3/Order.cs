using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_3._3._3
{
    public class Order
    {
        public int OrderNumber { get; private set; }

        private static int _temp = 1000; //just for 4-digits order number

        public string OrderedItems { get; set; }

        public delegate void methodContainer(int _orderNumber);

        public static event methodContainer OrderIsReady;

        public void OrderProcessing()
        {
            Thread.Sleep(1600);

            Console.WriteLine("Заказ " + this.OrderNumber + " готов!");

            OrderIsReady?.Invoke(OrderNumber);
        }

        public Order(string orderedItems)
        {
            OrderedItems = orderedItems;

            OrderNumber = _temp;

            _temp++;
        }
    }
}
