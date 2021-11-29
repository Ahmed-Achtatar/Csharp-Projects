using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApp
{
    class Etdiant
    {

        public static int Cmp { get; set; }
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public double Note { get; set; }

        // CONTRUCTORS
        public Etdiant(string nom, string prenom, double note) {
            this.Id = ++Cmp;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Note = note;
        }
    }
}
