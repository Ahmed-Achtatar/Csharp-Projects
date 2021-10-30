using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            /// DECLARATIONS
            /// ---------------------------------------------
            List<Hero> heroList = new List<Hero>(){
            new Hero("Ahmed",9187.0009,2898.22,9,10),
            new Hero("Brahim", 9187009, 87.22, 92, 100),
            new Hero("Omar", 9187.0009, 28982, 72, 1001),
            new Hero("3mimi", 91.0009, 28987.2, 9724, 1000),
            new Hero("Mouad", 9187.09, 289.22, 9722, 100000)
            };

            /// QUERIES
            /// ---------------------------------------------
            var heroByHp = from hero in heroList

                             orderby hero.Hp descending
                             select hero;
            Console.WriteLine("Heros ranking by HP");

            /// INSTRUCTIONS
            /// ---------------------------------------------
            foreach (var hero in heroByHp)
            {
                Console.WriteLine($"hero: {hero.Name} hp: {hero.Hp} ATK: {hero.Atk} DEF: {hero.Def} SPD: {hero.Spd}");
            }
            
        }

        /// CLASSES------------------------------
        /// ---------------------------------------------
        class Hero
        {
            /// VARIABLES
            /// ---------------------------------------------
            public double Atk { get; private set; }
            public double Def { get; private set; }
            public double Spd { get; private set; }
            public double Hp { get; private set; }

            public string Name;

            /// CONSTRUCTOR
            /// ---------------------------------------------

            public Hero(string name, double atk, double def, double spd, double hp){
                Atk = atk;
                Def = def;
                Spd = spd;
                Hp = hp;
                Name = name; 
            }
            /// METHODS
            /// ---------------------------------------------
        }
    }
}
