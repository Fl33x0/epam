using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._1._2
{
    class Square : Figure, IHaveArea
    {
        public Dimension side = new Dimension();

        public Square(double x, double y, double sideLength)
        {
            center.x = x;
            center.y = y;
            side.Size = sideLength;
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
    }
}
