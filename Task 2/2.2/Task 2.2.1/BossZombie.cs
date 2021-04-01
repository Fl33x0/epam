using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._2._1
{
    class BossZombie : Monster
    {        
        public BossZombie(Point p)
        {
            Name = "BossZombie";
            speed = 2;
            P = p;
        }
    }
}
