using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._1._2
{
    class Ring : Circle, IHaveArea
    {
        private Dimension innerRadius;

        
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
            center.x = x;
            center.y = y;
            this.Radius.Size = Radius;
            this.innerRadius.Size = innerRadius;
        }
    }
}
