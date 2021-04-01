using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._2._1
{
    public class Player : FieldObject, IMovable
    {      
        private string name;

        private Point p;

        private double speed;
        

        public Player(string name, Point p)
        {
            Name = name;
            P = p;
        }

        public void TakeBonus() { }

        public void Move() { }

        public void Restart() { }
    }
}
