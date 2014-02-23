namespace JustRpg.Units
{
    using System;

    class HeroAssassin : Hero
    {
        private const int initialHitPoints = 450;
        private const int initialAttackPoints = 15;
        private const int initialDefencePoints = 15;
        private const int initialSpeed = 3;

        public HeroAssassin(string name, char[,] body)
            : base(name, initialHitPoints, initialAttackPoints, initialDefencePoints, initialSpeed, body)
        {
        }
    }
}
