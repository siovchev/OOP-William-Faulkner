namespace JustRpg.Units
{
    using System;

    class HeroRanger : Hero
    {
        private const int initialHitPoints = 350;
        private const int initialAttackPoints = 25;
        private const int initialDefencePoints = 10;
        private const int initialSpeed = 2;

        public HeroRanger(string name, char[,] body) 
            : base(name, initialHitPoints, initialAttackPoints, initialDefencePoints, initialSpeed, body)
        {
        }
    }
}
