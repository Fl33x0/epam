using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._1._2
{
    class Triangle : Figure, IHaveArea
    {
        public Dimension side1;
        public Dimension side2;
        public Dimension side3;

        public override double Perimeter
        {
            get { return side1.Size + side2.Size + side3.Size; }
        }

        public double GetArea
        {
            get
            {
                double p = (side1.Size + side2.Size + side3.Size) / 2;
                return Math.Sqrt(p * (p - side1.Size) * (p - side2.Size) * (p - side3.Size));
            }
        }
    }
}
