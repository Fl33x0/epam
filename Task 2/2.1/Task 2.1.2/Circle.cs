using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._1._2
{
    class Circle : Polygon // Окружность
    {
        private static double size;
        public Dimension Radius = new Dimension();

        public override double Perimeter // circumference
        {
            get
            {
                return 2 * Math.PI * Radius.Size;
            }
        }


        public Circle(double x, double y, double Radius)
        {
            center.x = x;
            center.y = y;
            this.Radius.Size = Radius;
        }

        public Circle()
        {
            Console.WriteLine("Введите координату Х центра");
            center.x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату У центра");
            center.y = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите радиус");
            Radius.Size = double.Parse(Console.ReadLine());
        }

        public override void GetInfo()
        {
            Console.WriteLine("Тип фигуры: Окружность");
            base.GetInfo();
            Console.WriteLine("Длина окружности = " + Perimeter);
            Console.WriteLine();
        }

        
    }
}
