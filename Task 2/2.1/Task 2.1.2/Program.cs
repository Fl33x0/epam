using System;
using System.Collections.Generic;

namespace Task_2._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Figure> figures = new List<Figure>(); 
            while (true)
            {
                Console.WriteLine("Выберите действие: ");
                Console.WriteLine("1. Добавить фигуру");
                Console.WriteLine("2. Вывести фигуры");
                Console.WriteLine("3. Очистить холст");
                Console.WriteLine("4. Выход");


                int selection = Int32.Parse(Console.ReadLine());
                switch (selection)
                {
                    case 1:
                        {
                            figures.Add(FigureChoice());
                            Console.WriteLine("Фигура добавлена"); 
                            break;
                        }
                       
                    case 2:
                        {
                            foreach (var item in figures)
                            {
                                item.GetInfo();
                            }
                            break;
                        }
                    case 3:
                        {
                            figures.Clear();
                            Console.WriteLine("Холст очищен");
                            break;
                        }
                            
                    case 4: Environment.Exit(0); break;
                }
            } 
        }

        public static Figure FigureChoice()
        {          

            Console.WriteLine("Выберите тип фигуры: ");
            Console.WriteLine("1. Линия");
            Console.WriteLine("2. Окружность");
            Console.WriteLine("3. Круг");
            Console.WriteLine("4. Кольцо");
            Console.WriteLine("5. Треугольник");
            Console.WriteLine("6. Прямоугольник");
            Console.WriteLine("7. Квадрат");

            int selection = Int32.Parse(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    {
                        return new Line();
                    }
                case 2:
                    {                      
                        return new Circle();
                    }
                case 3:
                    {
                        return new Round();
                    }
                case 4:
                    {
                        return new Ring();
                    }
                case 5:
                    {
                        return new Triangle();
                    }
                case 6:
                    {
                        return new Rectangle();
                    }
                case 7:
                    {
                        return new Square();
                    }
                default:
                    Console.WriteLine("Вы нажали не ту кнопку");
                    return null;
                    break;
                    
            }
        }                
    }
}
