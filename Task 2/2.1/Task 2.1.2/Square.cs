using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._1._2
{
    class Square : Polygon, IHaveArea
    {
        public Dimension side = new Dimension();

        public Square(double x, double y, double sideLength)
        {
            center.x = x;
            center.y = y;
            side.Size = sideLength;
        }
        
        public Square()
        {
            Console.WriteLine("Введите координату Х центра");
            center.x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату У центра");
            center.y = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите длину стороны");
            side.Size = double.Parse(Console.ReadLine());            
        }
        

        public override double Perimeter
        {
            get
            {
                return 4 * side.Size;
            }
        }

        public double GetArea
        {
            get { return side.Size * side.Size; }
        }
        public override void GetInfo()
        {
            Console.WriteLine("Тип фигуры: квадрат");
            base.GetInfo();
            Console.WriteLine("Периметр = " + Perimeter);
            Console.WriteLine("Площадь = " + GetArea);
            Console.WriteLine();
        }
    }
}
