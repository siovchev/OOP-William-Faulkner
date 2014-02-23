namespace JustRpg.Units
{
    using System;

    using JustRpg.Interfaces;
   
    public abstract class Hero : Unit, IHero
    {
        public Hero(string name, int hitP, int attP, int defP, int speed, char[,] body)
            : base(hitP, attP, defP, speed, body)
        {
            this.Name = name;
            this.HitPoints = hitP;
            this.AttackPoints = attP;
            this.DefensePoints = defP;
            this.Speed = speed;
            this.Experience = 0;
        }

        public string Name { get; set; }

        public int Experience { get; set; }
    }
}
