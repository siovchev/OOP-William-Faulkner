namespace JustRpg.EngineAndRenderer
{
    using System;
    using System.Collections.Generic;
    using JustRpg.Units;

    public class Engine
    {
        private Renderer renderer;
        private IEnumerable<Unit> units;
        private List<string> commands;
        private Hero hero;

        public Engine(Renderer render)
        {
            this.renderer = render;
            var units = new List<Unit>();
        }

        public Hero GetHero
        {
            get
            {
                return this.hero;
            }
        }

        public void ProcessCommands(IEnumerable<string> commands)
        {
            // TODO 
        }

        public void CreateHero(string newHero, string name, char[,] body)
        {
            switch (newHero.ToLower())
            {
                case "assassin": hero = new HeroAssassin(name, body);
                    break;
                case "barbarian": hero = new HeroBarbarian(name, body);
                    break;
                case "ranger": hero = new HeroRanger(name, body);
                    break;
                default: throw new InvalidOperationException("Can't create a hero of unknown type!");
            }
        }

        public void AttackUnit(Unit unit)
        {
            // TODO Implement function
        }

        public Renderer GetRenderer
        {
            get
            {
                return this.renderer;
            }
        }

        public void TestAdjacentUnits(IEnumerable<Unit> listOfEnnemies)
        {
            // TODO : compare each ennemy to hero's position, if adjacent - Attack()
        }

        public void Attack(Hero hero, Ennemy ennemy)
        {

        }
    }
}