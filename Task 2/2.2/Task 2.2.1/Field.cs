using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._2._1
{
    class Field
    {
        public Player player;

        public List<Monster> monsters;

        public List<Bonus> bonuses;

        public List<Barrier> barriers;

        public int Width { get; set; }

        public int Height { get; set; }
        public Point RandomPoint()
        {
            Random rnd = new Random();
            int xx = rnd.Next(0, 99);
            int yy = rnd.Next(0, 99);
            return new Point { x = xx, y = yy };
        }

        public void AddPlayer(string name)
        {
            player = new Player(name, RandomPoint());
        }

        public void AddMonsters()
        {
            monsters = new List<Monster>();
            monsters.Add(new ArmedZombie(RandomPoint()));
            monsters.Add(new UnarmedZombie(RandomPoint()));
            monsters.Add(new BossZombie(RandomPoint()));
        }
        public void AddBonuses()
        {
            bonuses = new List<Bonus>();
            bonuses.Add(new Bonus(Bonus.BonusType.Amulet, RandomPoint()));
            bonuses.Add(new Bonus(Bonus.BonusType.EnergyDrink, RandomPoint()));
            bonuses.Add(new Bonus(Bonus.BonusType.Pills, RandomPoint()));
        }

        public void AddBarrieres()
        {
            barriers = new List<Barrier>();
            barriers.Add(new Barrier(Barrier.BarrierType.Hole, RandomPoint()));
            barriers.Add(new Barrier(Barrier.BarrierType.Stone, RandomPoint()));
            barriers.Add(new Barrier(Barrier.BarrierType.Tree, RandomPoint()));
            barriers.Add(new Barrier(Barrier.BarrierType.Wall, RandomPoint()));
        }

        public Field(int width, int height)
        {
            Width = width;
            Height = height;            
            AddBonuses();
            AddMonsters();
            AddBarrieres();
        }
    }
}
