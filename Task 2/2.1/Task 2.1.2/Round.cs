using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._1._2
{
    class Round : Circle, IHaveArea // круг
    {
        public Round(double x, double y, double Radius) : base(x, y, Radius)
        {
            center.x = x;
            center.y = y;
            this.Radius.Size = Radius;
        }
        public Round() : base()
        {
            
        }
        public double GetArea
        {
            get { return Math.PI * Radius.Size * Radius.Size; }
        }
        public override void GetInfo()
        {
            Console.WriteLine("Тип фигуры: круг");
            Console.WriteLine("Координаты центра фигуры: " + "x = " + this.center.x + " y = " + this.center.y);
            Console.WriteLine("Длина окружности = " + Perimeter);
            Console.WriteLine("Площадь = " + GetArea);
            Console.WriteLine();
        }
    }
}
