using System;
using System.Collections.Generic;
namespace FonctionTableaux
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }

    }
    class Tableau
    {
        // LES ATTRIBUTS
        public string[] Tstr { get; private set; }
        public int[] Tint { get; private set; }
        public double[] Tdouble { get; private set; }
        public bool[] Tbool { get; private set; }
        public string DataType { get; private set; }
 



        // LES METHODS
        public Tableau(string dataType, int dimension)
        {
            if (dataType == "string")
            {
                Tstr = new string[dimension];
            }
            else if (dataType == "int")
            {
                Tint = new int[dimension];
            }
            else if (dataType == "double")
            {
                Tdouble = new double[dimension];
            }
            else if (dataType == "bool")
            {
                Tbool = new bool[dimension];
            }
        }
        public void Inserer(string val)
        {
            if (DataType == "string")
            {
                for (int i = 0; i < Tstr.Length; i++)
                {
                    if (Tstr[i] != null)
                    {
                        this.Tstr[i] = val;
                        break;
                    }
                }
            }

        }
            
        public bool Inserer(int val)
        {
            bool insertComplete = false; 
            if (DataType == "int")
            {
                for (int i = 0; i < Tint.Length; i++)
                {
                    bool isExist = String.IsNullOrEmpty(Tint[i].ToString());
                    if (!isExist)
                    {
                        this.Tint[i] = val;
                        insertComplete = true;
                    }
                }
            }

            return insertComplete;
        }
        public void supprimer(string val)
        {
            for (int i = 0; i < Dimension; i++)
            {
                if (Tstr[i] == typeof()val)
                {
                    this.Tstr[i] = null;
                }
        }

        }
        public void modifier(string valTrouv,string valchang)
        {
            for (int i = 0; i < Dimension; i++)
            {
                if (Tstr[i] == valTrouv)
                {
                    this.Tstr[i] = valchang;
                }
            }

    }
        public int Trouver(string valTrouv) {
            int pos = 0;
            for (int i = 0; i < Dimension; i++)
            {
                if (this.Tstr[i] == valTrouv)
                {
                    pos = i;
                    break;
                }
            }
                        else if (DataType == "string")

        return pos;
        }
        public bool Istrouv(string valTrouv) {
            bool resultat = false;
            for (int i = 0; i < Dimension; i++)
            {
                if (Tstr[i] == valTrouv)
                {
                    resultat = true;
                    break;
                }
            }

        return resultat;
        }
        public void Fusionner()
        {

        }
        public void trier()
        {

        }
        public int NbrOccurence(string valTrouv)
        {
            int compte = 0 ;
            for (int i = 0; i < Dimension; i++)
            {
                if (Tstr[i] == valTrouv)
                {
                    compte++;
                }
            }
            return compte;
        }
        public void Concatener()
        {

        }
    }
}
