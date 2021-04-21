using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._3._3
{
    class Customer
    {
        public string Name { get; set; }
        public int MyOrderNumber { get; set; }

        public Customer(string name)
        {
            Name = name;
        }

        public void MakeOrder(string orderedItems)
        {
            MyOrderNumber = Pizzeria.GetOrderAsync(orderedItems).Result;
            
            Order.OrderIsReady += GetPizza;
        }

        public void GetPizza(int _orderNumber)
        {            
            if (_orderNumber == MyOrderNumber)
            {
                Console.WriteLine(this.Name + ": \"Я забрал пиццу!!\"");
            }            
        }
    }
}
