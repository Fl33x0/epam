using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._2._1
{
    public abstract class Monster : FieldObject, IMovable
    {
        protected double speed;

        public void KillPlayer() { }

        public void Move() { }
    }
}
