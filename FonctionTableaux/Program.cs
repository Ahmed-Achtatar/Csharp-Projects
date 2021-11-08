using System;

namespace FonctionTableaux
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            insere()
            insere()
        }

    }
    class Tableau
    {
        // LES ATTRIBUTS
        private string[] Tstr;
        private int[] Tint;
        private double[] Tdbl;
        private bool[] Tbool;
        private int Dimension;



        // LES METHODS
        public Tableau(a, int dimension)
        {
        this.Dimension = dimension;

        }
        public void inserer(string val)
        {
            for (int i = 0; i < Dimension; i++)
            {
                if(Tstr[i] != null) { 
                    this.Tstr[i] = val;
                    break;
                }
            }
        }
        public void supprimer()
        {

        }
        public void modifier()
        {

        }
        public void trouver() { 
            
        }
        public void fusionner()
        {

        }
        public void trier()
        {

        }
        public void nbrOccurence()
        {

        }
        public void Concatener()
        {

        }
    }
}
