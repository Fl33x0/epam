using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._1._2
{
    public class Line : Figure
    {
        private static double x;
        private static double y;
        public Point start = new Point(x, y);
        public Point end = new Point(x, y);

        
        public double Length
        {
            get
            {
                return Math.Sqrt((end.x - start.x) * (end.x - start.x) + (end.y - start.y) * (end.y - start.y));
            }
        }

        public Line(double x1, double y1, double x2, double y2)
        {
            start.x = x1;
            start.y = y1;
            end.x = x2;
            end.y = y2;
        }
        public Line()
        {
            Console.WriteLine("Введите координату Х начала линии");
            start.x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату У начала линии");
            start.y = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату Х конца линии");
            end.x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату У конца линии");
            end.y = double.Parse(Console.ReadLine());                        
        }

        public override void GetInfo()
        {
            Console.WriteLine("Тип фигуры: линия");
            Console.WriteLine("Координаты начала: " + "x = " + start.x + " y = " + start.y);
            Console.WriteLine("Координаты конца: " + "x = " + end.x + " y = " + end.y);
            Console.WriteLine("Длина: " + Length);
            Console.WriteLine();
        }

        
    }
}
