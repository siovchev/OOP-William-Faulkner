<<<<<<< HEAD
﻿namespace JustRpg
{
    using System;
    using System.IO;

    using JustRpg.Units;
    using JustRpg.EngineAndRenderer;
    

    class Program
    {
        public static void DrawTestIntro()
        {
            using (StreamReader sr = new StreamReader("../../Art/Intro.txt"))
            {
                var x = sr.ReadLine();

                while (x != null)
                {
                    Console.WriteLine(x);
                    x = sr.ReadLine();
                }
            }
        }

        public static void Main(string[] args)
        {
            
            var renderer = new Renderer();
            var engine = new Engine(renderer);
            //ddd
            //testing the hero creation
            engine.CreateHero("assassin", "radoi", new char[,]{{'O'}});
            //Console.WriteLine(engine.GetHero.GetType()  ); 
            Hero hero = engine.GetHero;
            hero.TopLeft = new MatrixCoords(5, 5);
            engine.GetRenderer.EnqueueForRendering(hero);
            engine.GetRenderer.RenderAll();

            DrawTestIntro();
            //test
        }
    }
=======
﻿namespace JustRpg
{
    using System;
    using System.IO;

    using JustRpg.Units;
    using JustRpg.EngineAndRenderer;
    

    class Program
    {
        public static void DrawTestIntro()
        {
            using (StreamReader sr = new StreamReader("../../Art/Intro.txt"))
            {
                var x = sr.ReadLine();

                while (x != null)
                {
                    Console.WriteLine(x);
                    x = sr.ReadLine();
                }
            }
        }

        public static void Main(string[] args)
        {
            
            var renderer = new Renderer();
            var engine = new Engine(renderer);
            //ddd
            //testing the hero creation
            engine.CreateHero("assassin", "radoi", new char[,]{{'O'}});
            //Console.WriteLine(engine.GetHero.GetType()  ); 
            Hero hero = engine.GetHero;
            hero.TopLeft = new MatrixCoords(5, 5);
            engine.GetRenderer.EnqueueForRendering(hero);
            engine.GetRenderer.RenderAll();

            //DrawTestIntro();
        }
    }
>>>>>>> parent of aa3e2be... test
}