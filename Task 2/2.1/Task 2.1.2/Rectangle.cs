using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._1._2
{
    class Rectangle : Polygon, IHaveArea
    {

        private static double size;
        public Dimension length = new Dimension();
        public Dimension width = new Dimension();

        public override double Perimeter
        {
            get { return 2 * length.Size + 2 * width.Size; }
        }

        public double GetArea
        {
            get { return length.Size * width.Size; }
        }

        public Rectangle(double x, double y, double length, double width)
        {            
            center.x = x;
            center.y = y;
            this.length.Size = length;
            this.width.Size = width;
        }

        public Rectangle()
        {
            Console.WriteLine("Введите координату Х центра");
            center.x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату У центра");
            center.y = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите длину");
            length.Size = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите ширину");
            width.Size = double.Parse(Console.ReadLine());
        }

        public override void GetInfo()
        {
            Console.WriteLine("Тип фигуры: прямоугольник");
            base.GetInfo();
            Console.WriteLine("Периметр = " + Perimeter);
            Console.WriteLine("Площадь = " + GetArea);
            Console.WriteLine();
        }
    }
}
