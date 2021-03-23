using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._1._2
{
    public class Point
    {
        public double x 
        {
            get; set;
        }

        public double y
        {
            get; set;
        }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Point() { this.x = 0; this.y = 0; }
    }
}
