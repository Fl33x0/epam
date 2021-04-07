using System;
using System.Collections.Generic;

namespace Task_3._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> circle = new();

            Console.WriteLine("Введите число человек в круге");

            int.TryParse(Console.ReadLine(), out int N);            

            for (int i = 0; i < N; i++)
            {
                circle.Add(new Person(i + 1));
            }

            Console.WriteLine("Укажите, какой по номеру человек будет вычеркиваться в каждом раунде");

            int.TryParse(Console.ReadLine(), out int removalNumber);

            int currentNumber = 0;

            int j = 0;

            while (circle.Count >= removalNumber)
            {
                j ++;
                currentNumber = Round(circle, currentNumber, removalNumber);
                Console.WriteLine("Раунд " + j + ". Вычеркнут человек. Людей осталось: " + circle.Count);
            }

            Console.WriteLine("Игра окончена. Невозможно вычеркнуть больше людей.");
            Console.WriteLine("Остались люди под номерами: ");

            foreach (var item in circle)
            {
                Console.WriteLine(item.StartNumber);
            }
            
        }

        public static int Round(List<Person> _circle, int _currentNumber, int _removalNumber)
        {
            int N = _circle.Count;            

            if (_currentNumber + _removalNumber > _circle.Count)
            {
                _currentNumber = _currentNumber + _removalNumber - _circle.Count - 1;
            }
            else
            _currentNumber += _removalNumber - 1;

            _circle.RemoveAt(_currentNumber);
                      
            return _currentNumber;
        }
    }
}
