using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._2._1
{
    public abstract class FieldObject
    {
        public virtual Point P { get; protected set; }
        public virtual string Name { get; protected set; }
    }

    public interface IMovable
    {
        public void Move() { }
    }
}
