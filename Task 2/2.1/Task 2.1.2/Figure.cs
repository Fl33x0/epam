using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._1._2
{
    public interface IHaveArea
    {
        public double GetArea { get; }
    }
    public abstract class Figure
    {
        private static double _x;
        private static double _y;
        public Point center = new Point(_x, _y);
        public class Dimension
        {

            private double _size;
            public double Size
            {
                get
                {
                    return _size;
                }
                set
                {
                    if (value > 0)
                    {
                        _size = value;
                    }
                    else
                    {
                        throw new Exception("Dimension length should be positive");
                    }
                }
            }

            public Dimension(double size)
            {
                this.Size = size;
            }
        }

        public virtual double Perimeter { get; }

    }
}
