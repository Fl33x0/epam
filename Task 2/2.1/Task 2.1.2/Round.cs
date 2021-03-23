using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._1._2
{
    class Round : Circle, IHaveArea
    {
        public Round(double x, double y, double Radius) : base(x, y, Radius)
        {
            center.x = x;
            center.y = y;
            this.Radius.Size = Radius;
        }
        public double GetArea
        {
            get { return Math.PI * Radius.Size * Radius.Size; }
        }
    }
}
