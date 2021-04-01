using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._2._1
{
    class UnarmedZombie : Monster
    {
        public UnarmedZombie(Point p)
        {
            Name = "UnarmedZombie";
            speed = 1;
            P = p;
        }
    }
}
