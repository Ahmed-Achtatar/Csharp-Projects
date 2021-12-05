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
        /// <summary>
        /// Donner la position du premier valeur trouvé
        /// </summary>
        /// <param name="valTrouv">Valeur à trouver</param>
        /// <returns></returns>
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
        /// <summary>
        /// Tester si cette valeur existe dans le tableau
        /// </summary>
        /// <param name="valTrouv">Valeur à trouver</param>
        /// <returns><code>true</code> si trouvé,  <code>false</code> sinon</returns>
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
        /// <summary>
        /// Concatener avec le quicksort
        /// </summary>
        /// <param name="T2">Tableau 2</param>
        /// <returns><code>Tableau 3</code></returns>
        public Tableau Fusionner(Tableau T2)
        {
            int dim1 = this.NbrVal;
            int dim2 = T2.NbrVal;
            Tableau T3 = new Tableau(dim1 + dim2, true);
            for (int i = 0; i < dim1; i++)
            {
                T3.Ajouter(this.Tab[i]);
            }
            for (int i = 0; i < dim2; i++)
            {
                T3.Ajouter(T2.Tab[i]);
            }
            return T3;
        }
        public void Trier()
        {
            QuickSort(this.Tab, int.Parse(Tab[0]), int.Parse(Tab[NbrVal]));
        }
        /// <summary>
        /// nombre de valeurs égal au parametre dans le tableau
        /// </summary>
        /// <param name="valTrouv"> valeur à trouver</param>
        /// <returns>nombre d'occurence</returns>
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
        /// <summary>
        /// ajouter le tableau 2 au tablau 1 sans fusion
        /// </summary>
        /// <param name="T2">tableau 2</param>
        /// <returns>Tableau 3</returns>
        public Tableau Concatener(Tableau T2)
        {
            int dim1 = this.NbrVal;
            int dim2 = T2.NbrVal;
            Tableau T3 = new Tableau(dim1 + dim2, false);
            for (int i = 0; i < dim1; i++)
            {
                T3.Ajouter(this.Tab[i]);
            }
            for (int i = 0; i < dim2; i++)
            {
                T3.Ajouter(T2.Tab[i]);
            }
            return T3;
        }
        /// <summary>
        /// inverser le tableau
        /// </summary>
        public void Inverser()
        {
            for (int i = 0; i < this.NbrVal / 2; i++)
            {
                int tmp = this.Tab[i];
                this.Tab[i] = this.Tab[this.NbrVal - i - 1];
                this.Tab[this.NbrVal - i - 1] = tmp;
            }
        }
        /// <summary>
        /// est'ce que le nombre de valeurs à droite et le meme à gauche
        /// </summary>
        /// <returns>true if symmetric, else false </returns>
        public bool IsSymetric()
        {
            if (this.NbrVal % 2 == 0)
                return true;
            else
                return false;
        }

    } }


