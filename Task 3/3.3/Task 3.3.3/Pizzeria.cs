using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_3._3._3
{
    public static class Pizzeria
    {
        
        public static async Task<int> GetOrderAsync(string orderedItems)
        {
            Order _currentOrder = new Order(orderedItems);
                        
            Task.Run(() => _currentOrder.OrderProcessing());

            Console.WriteLine("Заказ получен. Ваш номер заказа: " + _currentOrder.OrderNumber);

            return _currentOrder.OrderNumber; 
        }

    }    
}
