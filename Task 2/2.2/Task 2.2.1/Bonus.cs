using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._2._1
{
    public class Bonus : FieldObject
    {
        public enum BonusType
        {
            EnergyDrink,
            Amulet,
            Pills
        }
        public Bonus(BonusType type, Point p)
        {
            switch (type)
            {
                case BonusType.EnergyDrink:
                    Name = BonusType.EnergyDrink.ToString();
                    break;
                case BonusType.Amulet:
                    Name = BonusType.Amulet.ToString();
                    break;
                case BonusType.Pills:
                    Name = BonusType.Pills.ToString();
                    break;                
            }
            P = p;
        }
    }
}
