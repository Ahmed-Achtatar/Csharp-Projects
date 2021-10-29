using System;
using System.Collections.Generic;
using System.Linq;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Hero> heros = new List<Hero>(){
            new Hero("Ahmed",9187.0009,2898.22,9,10),
            new Hero("Brahim", 9187009, 87.22, 92, 100),
            new Hero("Omar", 9187.0009, 28982, 72, 1001),
            new Hero("3mimi", 91.0009, 28987.2, 9724, 1000),
            new Hero("Mouad", 9187.09, 289.22, 9722, 100000)
            };
        

        var orderheros = from hero in heros

                             orderby hero.HP descending
                             select hero;
            Console.WriteLine("Heros ranking by HP");
            foreach (var hero in orderheros)
            {
                Console.WriteLine($"hero: {hero.NAME} hp: {hero.HP} ATK: {hero.ATK} DEF: {hero.DEF} SPD: {hero.SPD}");
            }
            
        }


        class Hero
        {
            /// <Variables>
            
            public double ATK { get; private set; }
            public double DEF { get; private set; }
            public double SPD { get; private set; }
            public double HP { get; private set; }

            public string NAME;

            /// </Variables>

            public Hero(string name, double atk, double def, double spd, double hp){
                ATK = atk;
                DEF = def;
                SPD = spd;
                HP = hp;
                NAME = name; 
            }
        }
    }
}
