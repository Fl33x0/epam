using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._2._1
{
    class Barrier : FieldObject
    {
        public enum BarrierType
        {
            Stone,
            Tree,
            Wall,
            Hole
        }

        public int Size { get; set; }
        public Barrier(BarrierType type, Point p)
        {
            switch (type)
            {
                case BarrierType.Stone:
                    Name = BarrierType.Stone.ToString();
                    Size = 1;
                    break;
                case BarrierType.Tree:
                    Name = BarrierType.Tree.ToString();
                    Size = 2;
                    break;
                case BarrierType.Wall:
                    Name = BarrierType.Wall.ToString();
                    Size = 3;
                    break;
                case BarrierType.Hole:
                    Name = BarrierType.Hole.ToString();
                    Size = 4;
                    break;
            }
            P = p;
        }
    }
}
