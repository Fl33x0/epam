using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._1._2
{
    class Line
    {
        private static double x;
        private static double y;
        public Point start = new Point(x, y);
        public Point end = new Point(x, y);

        
        public double Length
        {
            get
            {
                return Math.Sqrt((end.x - start.x) * (end.x - start.x) + (end.y - start.y) * (end.y - start.y));
            }
        }

        public Line(double x1, double y1, double x2, double y2)
        {
            start.x = x1;
            start.y = y1;
            end.x = x2;
            end.y = y2;
        }

    }
}
