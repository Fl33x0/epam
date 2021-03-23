using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._1._2
{
    class Rectangle : Figure, IHaveArea
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
    }
}
