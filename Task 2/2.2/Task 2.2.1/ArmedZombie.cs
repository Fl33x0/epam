using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._2._1
{
    class ArmedZombie : Monster
    {   
        
        public ArmedZombie(Point p)
        {
            Name = "ArmedZombie";
            speed = 1;
            P = p;
        }
    }
}
