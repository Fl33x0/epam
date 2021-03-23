using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._1._2
{
    class Ring : Circle, IHaveArea
    {
        private Dimension innerRadius = new Dimension();

        
        public double GetArea
        {
            get
            {
                return Math.PI * (Radius.Size * Radius.Size - innerRadius.Size * innerRadius.Size);
            }
        }
        public override double Perimeter
        {
            get
            {
                return 2 * Math.PI * Radius.Size + 2 * Math.PI * innerRadius.Size;
            }
        }

        public Ring(double x, double y, double Radius, double innerRadius) : base(x, y, Radius)
        {
            if (innerRadius > Radius)
            {
                throw new Exception("Inner radius should be less than external");
            }
            center.x = x;
            center.y = y;
            this.Radius.Size = Radius;
            this.innerRadius.Size = innerRadius;
        }

        public Ring() : base()
        {            
            Console.WriteLine("Введите внутренний радиус");
            innerRadius.Size = double.Parse(Console.ReadLine());
        }

        public override void GetInfo()
        {
            Console.WriteLine("Тип фигуры: кольцо");
            Console.WriteLine("Координаты центра фигуры: " + "x = " + this.center.x + " y = " + this.center.y);
            Console.WriteLine("Длина окружности = " + Perimeter);
            Console.WriteLine("Площадь = " + GetArea);
            Console.WriteLine();
        }
    }
}
