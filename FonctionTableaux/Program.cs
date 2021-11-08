using System;

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
            if (dataType == "int")
            {
                Tint = new int[dimension];
            }
            if (dataType == "double")
            {
                Tdouble = new double[dimension];
            }
            if (dataType == "bool")
            {
                Tbool = new bool[dimension];
            }
        }
        public void Inserer(string val)
        {
            if (DataType == "string") { 
            for (int i = 0; i < Tstr.Length; i++)
            {
                if(Tstr[i] != null) { 
                    this.Tstr[i] = val;
                    break;
                }
            }
            }
            else if (DataType == "string")
            {

            }
            else if (DataType == "int")
            {

            }
            else if (DataType == "double")
            {

            }
            else if (DataType == "bool")
            {

            }


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
                        else if (DataType == "string")
            {

            }
            else if (DataType == "int")
            {

            }
            else if (DataType == "double")
            {

            }
            else if (DataType == "bool")
            {

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
                        else if (DataType == "string")
        {

        }
        else if (DataType == "int")
        {

        }
        else if (DataType == "double")
        {

        }
        else if (DataType == "bool")
        {

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
        {

        }
        else if (DataType == "int")
        {

        }
        else if (DataType == "double")
        {

        }
        else if (DataType == "bool")
        {

        }
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
                        else if (DataType == "string")
        {

        }
        else if (DataType == "int")
        {

        }
        else if (DataType == "double")
        {

        }
        else if (DataType == "bool")
        {

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
