using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._1._2
{
    class Triangle : Figure, IHaveArea
    {
        
        public Dimension side1 = new Dimension();
        public Dimension side2 = new Dimension();
        public Dimension side3 = new Dimension();

        public override double Perimeter
        {
            get { return side1.Size + side2.Size + side3.Size; }
        }

        public double GetArea
        {
            get
            {
                double p = (side1.Size + side2.Size + side3.Size) / 2;
                return (double) Math.Sqrt(p * (p - side1.Size) * (p - side2.Size) * (p - side3.Size));
            }
        }

        public Triangle(double side1, double side2, double side3)
        {
            if (side1 + side2 <= side3 | side2 + side3 <= side2 | side1 + side3 <= side2)
            {
                throw new Exception("Summ of two sides of triangle should be bigger then 3rd side");
            }
            this.side1.Size = side1;
            this.side2.Size = side2;
            this.side3.Size = side3;
        }
    }
}
