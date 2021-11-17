using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FonctionTableaux
{
    class Tableau
    {

        // LES ATTRIBUTS
        public string[] Tab { get; private set; }   //  le tableau ou on va stocker des valeurs 
        public int NbrVal = 0; //  nombre d'Objets
        public bool IsTrie { get; private set; }



        // LES METHODS
        // LES CONSTRUCTEURS
        public Tableau(int dimension,bool istrie)
        {
            Tab = new string[dimension];
            IsTrie = istrie;
        }
        /// <summary>
        /// Tri 
        /// </summary>
        /// <param name="tab">C'est le tableau qu'on veut trier</param>
        /// <param name="first">Première case du tableau</param>
        /// <param name="last">Dernière case du tableau</param>
        public void QuickSort(string[] tab, int first, int last ) 
        {
            int nbr = tab.Length;
            var arr = new double[nbr];
            int pivot, left, right;
            double tmp;
            for(int i = 0; i < tab.Length; i++ )
            {
                arr[i] = double.Parse(tab[i]);
            }
            if(first < last)
            {
                pivot = first;
                left = first;
                right = last;
                while (left < right)
                {
                    while ((arr[left] <= arr[pivot]) && (left < last))
                        left++;
                    while (arr[right] > arr[pivot])
                        right--; 
                    if(left < right)
                    {
                        tmp = arr[left];
                        arr[right] = arr[right];
                        arr[right] = tmp;
                    }
                }
                
                tmp = arr[pivot];
                arr[pivot] = arr[right];
                arr[right] = arr[pivot];
                for (int i = 0; i < tab.Length; i++)
                {
                    tab[i] = tab[i].ToString();
                }
                QuickSort(tab, first, right - 1);
                QuickSort(tab, right + 1, last);
            }

        }
        // AJOUTER
        public bool Ajouter(string val)
        {
            bool addComplete = false;
            if (IsTrie == false)
            {
                    Tab[NbrVal] = val;
                    addComplete = true;
                NbrVal++;
            }
            else
            {
                
                    Tab[NbrVal] = val;
                    addComplete = true;
                    NbrVal++;
                    QuickSort(Tab, 0, NbrVal - 1);
                
            }
            return addComplete;

        }

        // SUPPRIMER
        public bool Supprimer(string val)
        {
            bool suppComplet = false;
            for (int i = 0; i < this.NbrOccurence(val); i++)
            {
                string tmp;
                for (int j = this.Trouver(val); j < Tab.Length; j++)
                {
                    // test next values
                    tmp = Tab[i];
                    Tab[i] = Tab[i + 1];
                    Tab[i + 1] = tmp;
                }
                NbrVal--;
                suppComplet = true;
            }
            return suppComplet;
        }

        
        public void modifier(string valTrouv, string valchang)
        {
            for (int i = 0; i < Tab.Length; i++)
            {
                if (Tab[i] == valTrouv)
                {
                    this.Tab[i] = valchang;
                }
            }

        }
        public int Trouver(string valTrouv)
        {
            int pos = 0;
            for (int i = 0; i < Tab.Length; i++)
            {
                if (this.Tab[i] == valTrouv)
                {
                    pos = i;
                    break;
                }
            }
             return pos;
        }
        public bool Istrouv(string valTrouv)
        {
            bool resultat = false;
            for (int i = 0; i < Tab.Length; i++)
            {
                if (Tab[i] == valTrouv)
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
            int compte = 0;
            for (int i = 0; i < Tab.Length; i++)
            {
                if (Tab[i] == valTrouv)
                {
                    compte++;
                }
            }
            return compte;
        }
        public void Concatener()
        {

        }
    } }


