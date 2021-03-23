using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._1._2
{
    class Circle : Figure
    {
        private static double size;
        public Dimension Radius = new Dimension(size);

        public override double Perimeter
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
    }
}
