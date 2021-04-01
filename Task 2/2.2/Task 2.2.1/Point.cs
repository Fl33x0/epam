using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._2._1
{
    public class Point
    {        
        public int x { get; set; }
        public int y { get; set; }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Point() { this.x = 0; this.y = 0; }        
    }
}
